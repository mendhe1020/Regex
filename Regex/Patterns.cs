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
        public static string REGEX_EMAILID = "^[a-zA-Z0-9]([._+-]{0,1}[a-zA-Z0-9])*[@]{1}[a-zA-Z0-9]{1,}[.]{1}[a-zA-Z]{2,3}([.]{1}[a-zA-Z]{2,3}){0,1}$";
        public static string REGEX_MOBILENO = "^[+]{0,1}[0-9]{2}[' ']?[0-9]{10}$";
        public static string REGEX_PASSWORD = "^(?=.*[A-Z])(?=.*[0-9])[0-9a-zA-Z]{8,}$";

        //UC1 FIRST NAME
        public bool ValidetFirstName(string FirstName)
        {
            return Regex.IsMatch(FirstName, REGEX_FIRSTNAME);
        }

        //UC2 LAST NAME
        public bool ValidLastName(string LasttName)
        {
            return Regex.IsMatch(LasttName, REGEX_LASTNAME);
        }

        //UC3 Email ID
        public bool ValideEmailID(string EmailId)
        {
            return Regex.IsMatch(EmailId, REGEX_EMAILID);
        }

        //UC4 Mobile Num
        public bool ValideMobileNo(string MobileNo)
        {
          return Regex.IsMatch(MobileNo, REGEX_MOBILENO);
        }

        //UC5 Password
        public bool ValidePassword(string Password)
        {
            return Regex.IsMatch(Password, REGEX_PASSWORD);
        }

    }
}
