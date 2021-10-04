using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19_Assignments
{
    class UC5Password
    {
        public static string Regex_password = "^[a-z]{8,}$";
        public bool Validatepassword(string password)
        {
            return Regex.IsMatch(password, Regex_password);
        }
    }
}
