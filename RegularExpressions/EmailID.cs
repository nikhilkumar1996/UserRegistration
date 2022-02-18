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
        static string emailId = (@"(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?!.*[<>`])(?=[^.,:;'!@#$%^&*_+=|(){}[?\-\]\/\\]*[.,:;'!@#$%^&*_+=|(){}[?\-\]\/\\][^.,:;'!@#$%^&*_+=|(){}[?\-\]\/\\]*$).{8,}$");
        Regex regex = new Regex(emailId);

        public void Validating()
        {
            Console.WriteLine("Validating EmailId");
            ValidatingEamilId();
        }

        public void ValidatingEamilId()
        {
            string[] email = { "Vishal4@gmail.com", "sakti_32@gmail,com", "rohan45@gmail.com", "prath@gmail.com" };
            bool val=regex.IsMatch(email);
            if (val)
            {
                Console.WriteLine("Email Ids are Valid");
            }
            else
            {
                Console.WriteLine("Email Ids are Invalid");
            }
        }
    }
}
