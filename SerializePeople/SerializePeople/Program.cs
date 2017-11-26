using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializePeople
{
    class Program
    {
        static void Main(string[] args)
        {
            Person alex = new Person("Alex", new DateTime(1995, 2, 26), Person.Genders.Male);
            alex.Serialize(@"C:\TEST\myfile.bin");
            Person.Deserialize(@"C\TEST\myfile.bin");
        }
    }
}
