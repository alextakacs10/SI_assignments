using System.Text.RegularExpressions;

namespace InputValidation
{
    class EntryValidator
    {
        public static bool ValidName(string entry)
        {
            if (Regex.IsMatch(entry, @"^([A-Za-z]*\s*)+$"))
            {
                return true;
            }
            return false;
        }

        public static bool ValidPhone(string entry)
        {
            if (Regex.IsMatch(entry, @"^((\(\d{3}\)?)|(\d{3}-))?\d{3}-\d{4}$"))
            {
                return true;
            }
            return false;
        }

        public static bool ValidEmail(string entry)
        {
            if (Regex.IsMatch(entry, @"^[^@]+@((\w|-)+\.)*\.[a-z]+$"))
            {
                return true;
            }
            return false;
        }
    }
}
