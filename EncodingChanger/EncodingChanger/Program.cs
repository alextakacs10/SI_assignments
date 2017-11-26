using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EncodingChanger
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = new StreamReader(@"C:\TEST\boot.txt");
            StreamWriter streamWriter = new StreamWriter(@"C:\TEST\boot-utf7.txt", false, Encoding.UTF7);

            streamWriter.WriteLine(streamReader.ReadToEnd());
            streamWriter.Close();
            streamReader.Close();
        }
    }
}
