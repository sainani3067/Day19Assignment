using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19_Assignments
{
    class UC2LastName
    {
        public static string Regex_LName = "^[A-Z][a-z]{2,}$";
        public bool ValidateLName(string Lastname)
        {
            return Regex.IsMatch(Lastname, Regex_LName);
        }

    }
}
  
