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
            Console.WriteLine("Found {0} files in {1} with pattern {2}.", FoundFiles.Count, rootDir.FullName, fileName);

            foreach (FileInfo file in FoundFiles)
            {
                Console.WriteLine("{0}", file.FullName);
            }
            Console.ReadKey();
        }

        static void RecursiveSearch(List<FileInfo> foundFiles, string fileName, DirectoryInfo currentDirectory)
        {
            foreach (FileInfo file in currentDirectory.GetFiles(fileName))
            {
                //if(file.Name == fileName)
                //{
                //    foundFiles.Add(file);
                //}
                foundFiles.Add(file);
            }

            foreach (DirectoryInfo dir in currentDirectory.GetDirectories())
            {
                RecursiveSearch(foundFiles, fileName, dir);
            }
        }
    }
}
