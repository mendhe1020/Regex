using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regexs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Name");
            string fName = Console.ReadLine();

            Console.WriteLine("Enter the Name");
            string lName = Console.ReadLine();

            Console.WriteLine("Enter the Email ID");
            string EmailID = Console.ReadLine();

            Console.WriteLine("Enter the Mobile Number");
            string MobileNo = Console.ReadLine();

            Console.WriteLine("Enter the Password");
            string Password = Console.ReadLine();

            Patterns patterns = new Patterns();

            //UC1 FIRST NAME
            bool val = patterns.ValidetFirstName(fName);
            if (val)
                Console.WriteLine("First Name is Valide");
            else
                Console.WriteLine("First Name is Not Valide (First name should starts with Cap and has minimum 3 characters)");

            //UC2 LAST NAME
            bool val1 = patterns.ValidLastName(lName);
            if (val1)
                Console.WriteLine("Last Name is Valide");
            else
                Console.WriteLine("Last Name is Not Valide (Last name should starts with Cap and has minimum 3 characters)");

            //UC3 Email ID
            bool val2 = patterns.ValideEmailID(EmailID);
            if (val2)
                Console.WriteLine("Email Id is Valide");
            else
                Console.WriteLine("Email Id is Not Valide Email should like (E.g. abc.xyz@bl.co.in)");

            //UC4 Mobile ID
            bool val3 = patterns.ValideMobileNo(MobileNo);
            if (val3)
                Console.WriteLine("Mobile no is Valide");
            else
               Console.WriteLine("Mobile Num is Not Valide Mobile Nun should like (E.g. 91 9919819801)");

            //UC5 Password
            bool val4 = patterns.ValidePassword(Password);
            if (val4)
                Console.WriteLine("Password is Valide");
            else
                Console.WriteLine("Password is Not Valide Password should like (Should have at least 1 Upper Case add minimum 8 Characters)");
        }
    }
}