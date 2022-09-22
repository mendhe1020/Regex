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
        }
    }
}