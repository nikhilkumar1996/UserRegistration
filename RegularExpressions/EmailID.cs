using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpressions
{
    public class EmailID
    {
        static string emailId = ("^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$");
        Regex regex = new Regex(emailId);

        public void Validating()
        {
            Console.WriteLine("Validating EmailId");
            ValidatingEamilId();
        }

        public void ValidatingEamilId()
        {
            Console.WriteLine("Enter Email Id");
            string email=Console.ReadLine();
            bool val=regex.IsMatch(email);
            if (val)
            {
                Console.WriteLine("Email Id is Valid");
            }
            else
            {
                Console.WriteLine("Email Id is Invalid");
            }
        }
    }
}
