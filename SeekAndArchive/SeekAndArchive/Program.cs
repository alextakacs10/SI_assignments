using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeekAndArchive
{
    class Program
    {
        //static variables
        static List<FileInfo> FoundFiles;
        static List<FileSystemWatcher> watchers;
        static List<DirectoryInfo> archiveDirs;

        static void Main(string[] args)
        {
            string fileName = args[0];
            string directoryName = args[1];
            FoundFiles = new List<FileInfo>();

            DirectoryInfo rootDir = new DirectoryInfo(directoryName);

            if(!rootDir.Exists)
            {
                Console.WriteLine("Directory does not exist.");
                return;
            }
             
            RecursiveSearch(FoundFiles, fileName, rootDir);
            Console.WriteLine("File name or pattern to search for: {0}", fileName);
            Console.WriteLine("Search in this directory: {0}", rootDir.FullName);
            Console.WriteLine("\nPress any key to search.");
            Console.ReadKey(true);
            Console.WriteLine("\nFound {0} item(s).", FoundFiles.Count);
            foreach (FileInfo file in FoundFiles)
            {
                Console.WriteLine("{0}", file.FullName);
            }

            watchers = new List<FileSystemWatcher>();

            foreach (FileInfo file in FoundFiles)
            {
                FileSystemWatcher newWatcher = new FileSystemWatcher(file.DirectoryName, file.Name);
                newWatcher.Changed += new FileSystemEventHandler(WatcherChanged);
                newWatcher.EnableRaisingEvents = true;
                watchers.Add(newWatcher);
            }

            archiveDirs = new List<DirectoryInfo>();
            for (int i = 0; i < FoundFiles.Count; i++)
            {
                archiveDirs.Add(Directory.CreateDirectory("archive" + i.ToString()));
            }

            Console.WriteLine("Pres any key to exit.");
            Console.ReadKey(true);

        }

        static void RecursiveSearch(List<FileInfo> foundFiles, string fileName, DirectoryInfo currentDirectory)
        {
            foreach (FileInfo file in currentDirectory.GetFiles(fileName))
            {
                foundFiles.Add(file);
            }

            foreach (DirectoryInfo dir in currentDirectory.GetDirectories())
            {
                RecursiveSearch(foundFiles, fileName, dir);
            }
        }

        static void WatcherChanged(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("{0} has been changed!", e.FullPath);
            FileSystemWatcher senderWatcher = (FileSystemWatcher)sender;
            int index = watchers.IndexOf(senderWatcher, 0);
            ArchiveFiles(archiveDirs[index], FoundFiles[index]);
        }

        static void ArchiveFiles(DirectoryInfo archiveDir, FileInfo fileToArchive)
        {
            FileStream input = fileToArchive.OpenRead();
            FileStream output = File.Create(archiveDir.FullName + @"\" + fileToArchive.Name + ".gz");
            GZipStream compressor = new GZipStream(output, CompressionMode.Compress);

            int b = input.ReadByte();

            while(b != -1)
            {
                compressor.WriteByte((byte)b);
                b = input.ReadByte();
            }
            compressor.Close();
            input.Close();
            output.Close();
        }
    }
}
