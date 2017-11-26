using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace StringReformat
{
    class Reformatter
    {
        public static string ReformatPhone(string phonenumber)
        {
            string pattern = @"^\(?(\d{3})\)?[\s\-]?(\d{3})\-?(\d{4})$";
            if(Regex.IsMatch(phonenumber, pattern))
            {
                Match match = Regex.Match(phonenumber, pattern);
                return String.Format("({0}) {1}-{2}", match.Groups[1], match.Groups[2], match.Groups[3]);

            }
            return "Not a valid US phone number.";
        }
    }
}
