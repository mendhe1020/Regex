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


            Patterns patterns = new Patterns();


            bool val = patterns.ValidetFirstName(fName);
            if (val)
                Console.WriteLine("First Name is Valide");
            else
                Console.WriteLine("First Name is Not Valide (First name should starts with Cap and has minimum 3 characters)");
        }
    }
}