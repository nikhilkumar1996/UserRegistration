using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpressions
{
    public class PhoneNoRegex
    {
        static string phNumber = (@"^[0-9]{10}$");
        Regex regex = new Regex(phNumber);

        public void Validating()
        {
            Console.WriteLine("Validating Phone Number");
            ValidatingPhoneNo();
        }

        public void ValidatingPhoneNo()
        {
            Console.WriteLine("Enter Phone Number");
            string phNo = Console.ReadLine();
            bool val = regex.IsMatch(phNo);
            if (val)
            {
                Console.WriteLine("Phone No is Valid");

            }
            else
            {
                Console.WriteLine("Phone No is Invalid");
            }
        }
    }
}
