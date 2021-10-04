using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19_Assignments
{
    class UC7password
    {
        public static string Regex_password = "^[a-zA-Z0-9]{8,}$";
        public bool Validatepassword(string password)
        {
            return Regex.IsMatch(password, Regex_password);
        }
    }
}
