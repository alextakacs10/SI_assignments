using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace AssemblyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\WINDOWS\Microsoft.NET\Framework\v2.0.50727\System.dll";

            Assembly assembly = Assembly.LoadFile(path);
            ShowAssemblyInfo(assembly);

            Assembly ourAssembly = Assembly.GetExecutingAssembly();
            ShowAssemblyInfo(ourAssembly);

            Console.Read();
        }

        static void ShowAssemblyInfo(Assembly assem)
        {
            Console.WriteLine(assem.FullName);
            Console.WriteLine("Global Assembly Cache: {0}", assem.GlobalAssemblyCache);
            Console.WriteLine("Path: {0}", assem.Location);
            Console.WriteLine("Version: {0}", assem.ImageRuntimeVersion);

            foreach (Module m in assem.GetModules())
            {
                Console.WriteLine("Module: {0}", m.Name);
            }
        }
    }
}
