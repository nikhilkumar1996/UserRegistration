using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpressions
{
    public class FirstNameRegEx
    {
        string firstName = "^[A-Z|a-z]{2,}$";
        public void Validating()
        {
            Regex regex = new Regex(firstName);
            Console.WriteLine("Validating the first name");
            ValidatingFirstName();

        }



        public void ValidatingFirstName()
        {
            Regex regex = new Regex(firstName);
            Console.WriteLine("Enter the first name:");
            string input = Console.ReadLine();
            bool val = regex.IsMatch(input);
            if (val)
            {
                Console.WriteLine("First Name is Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
