using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19_Assignments
{
    class UC4MobileNumber
    {

        public static string Regex_mobilenum = "^[1-9][0-9][ ]?[6-9][0-9]{9}$";
        public bool Validatemobile(string mobilenum)
        {
            return Regex.IsMatch(mobilenum, Regex_mobilenum);
        }
    }
}
