using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegularExpressions
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Program");
            Console.WriteLine("1.First Name Validation" +
                              "\n2.Last Name Validation" +
                              "\n3.Exit");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Choose Options");
                int choose=Convert.ToInt32(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        Console.WriteLine("User Registration Validating using Regular Expression!");
                        FirstNameRegEx regexSample = new FirstNameRegEx();
                        regexSample.Validating();
                        break;

                    case 2:
                        Console.WriteLine("User Registration Validating using Regular Expression!");
                        LastNameRegex regexSample1 = new LastNameRegex();
                        regexSample1.Validating();
                        break;

                    case 3:
                        flag = false;
                        break;

                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
            }
        }
    }
}
