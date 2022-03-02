using System;
using System.Text.RegularExpressions;

namespace RegexPattern
{
    public class Pattern
    {
        public static string REGEX_FIRSTNAME = "^[A-Z]{1}[A-Za-z]{2,}$"; //Vba

        //Method for first name 
        public bool validateFirstName(string fname)
        {
            return Regex.IsMatch(fname, REGEX_FIRSTNAME);
        }
        
    }
}
