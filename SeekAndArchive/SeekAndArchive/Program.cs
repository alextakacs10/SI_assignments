using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeekAndArchive
{
    class Program
    {
        static List<FileInfo> FoundFiles;
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
    }
}
