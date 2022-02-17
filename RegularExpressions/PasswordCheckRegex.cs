using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpressions
{
    public class PasswordCheckRegex
    {
        static string password= @"[a-z|A-Z|0-9]{8,}$";
        Regex regex = new Regex(password);

        public void Validating()
        {
            Console.WriteLine("Validating Password");
            ValildatingPassword();
        }
        public void ValildatingPassword()
        {
            Console.WriteLine("Enter Password");
            string pswdCheck=Console.ReadLine();
            bool val=regex.IsMatch(pswdCheck);
            if (val)
            {
                Console.WriteLine("Password has minimum 8 Characters");
            }
            else
            {
                Console.WriteLine("Password is Invalid");
            }
        }
    }
}
