using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpressions
{
    public class LastNameRegex
    {
        string lastName = "^[A-Z|a-z]{4,}$";
        public void Validating()
        {
            Regex regex = new Regex(lastName);
            Console.WriteLine("Validating the Last name");
            ValidatingLastName();

        }



        public void ValidatingLastName()
        {
            Regex regex = new Regex(lastName);
            Console.WriteLine("Enter the Last name:");
            string input = Console.ReadLine();
            bool val = regex.IsMatch(input);
            if (val)
            {
                Console.WriteLine("Last Name is Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
