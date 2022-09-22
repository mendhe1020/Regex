using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regexs
{
    public class Patterns
    {
        public static string REGEX_FIRSTNAME = "^[A-Z]{1}[a-z]{2,}$";
        public static string REGEX_LASTNAME = "^[A-Z]{1}[a-z]{2,}$";

        //UC1 FIRST NAME
        public bool ValidetFirstName(string FirstName)
        {
            return Regex.IsMatch(FirstName, REGEX_FIRSTNAME);
        }

        //UC1 LAST NAME
        public bool ValidLastName(string LasttName)
        {
            return Regex.IsMatch(LasttName, REGEX_LASTNAME);
        }
    }
}
