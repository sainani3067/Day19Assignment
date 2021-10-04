using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19Regex
{
    class UC1FirstName
    {
        public static string Regex_FName = "^[A-Z][a-z]{2,}$";
        public bool ValidateFName(string Firstname)
        {
            return Regex.IsMatch(Firstname, Regex_FName);
        }

    }
}
  
