using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp87.Validations
{
    class UserValidations
    {
        public static bool IsvalidText(string text)
        {
            Regex regex = new Regex(@"^(?=[A-Z]{1})([A-Za-z]{3,30})$");
            if (regex.IsMatch(text))
            {
                return true;
            }

            Console.WriteLine("Sehv var.");
            return false;

        }

        public static bool IsvalidFinkod(string text)
        {
            Regex regex = new Regex(@"^[\w -\.] +@([\w -] +\.) +[\w -]{ 2,4}$");
            if (regex.IsMatch(text))
            {
                return true;
            }

            return false;
        }
    }
}
