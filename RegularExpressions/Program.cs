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
                              "\n2.Exit");
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
                        flag = false;
                        break;
                }
            }
        }
    }
}
