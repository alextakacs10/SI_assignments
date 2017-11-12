using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();

            dict[44] = "United Kingdom";
            dict[40] = "Romania";
            dict[36] = "Hungary";

            Console.WriteLine("The code 40 is for: {0}", dict[40]);

            foreach(KeyValuePair<int, string> item in dict)
            {
                int code = item.Key;
                string country = item.Value;
                Console.WriteLine("Code {0} : {1}", code, country);
            }

            Console.ReadKey();
        }
    }
}
