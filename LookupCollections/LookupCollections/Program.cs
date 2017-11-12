using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Specialized;
using System.Globalization;

namespace LookupCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            ListDictionary dict = new ListDictionary(new CaseInsensitiveComparer(CultureInfo.InvariantCulture));
            dict["Estados Unidos"] = "United States";
            dict["Canadá"] = "Canada";
            dict["España"] = "Spain";

            Console.WriteLine(dict["eSpaña"]);
            Console.WriteLine(dict["CanADÁ"]);

            Console.ReadKey();
        }
    }
}
