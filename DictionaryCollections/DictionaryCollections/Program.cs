using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DictionaryCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable table = new Hashtable();
            table["0"] = "Zero";
            table["1"] = "One";
            table["2"] = "Two";
            table["3"] = "Three";
            table["4"] = "Four";
            table["5"] = "Five";
            table["6"] = "Six";
            table["7"] = "Seven";
            table["8"] = "Eight";
            table["9"] = "Nine";

            String myString = "8276123";

            foreach(char c in myString){
                String character = c.ToString();
                if (table.Contains(character))
                {
                    Console.WriteLine("Value for {0}: {1}", character, table[character]);
                }
            }
            Console.ReadKey();
        }
    }
}
