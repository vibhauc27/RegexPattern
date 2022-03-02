using System;
using System.Text.RegularExpressions;

namespace RegexPattern
{
    public class Pattern
    {
        public static string REGEX_FIRSTNAME = "^[A-Z]{1}[A-Za-z]{2,}$"; //Vba
        public static string REGEX_LASTNAME = "^[A-Z]{1}[A-Za-z]{2,}$"; //Rao
        public static string REGEX_EMAIL = "^[a-zA-Z0-9.]+@[A-Za-z0-9]+.[A-Za-z]{2,4}$"; //abc@bl.in

        //Method for first name 
        public bool validateFirstName(string fname)
        {
            return Regex.IsMatch(fname, REGEX_FIRSTNAME);
        }

        
        //Method for last name 
        public bool validateLastName(string lname)
        {
            return Regex.IsMatch(lname, REGEX_LASTNAME);
        }        

        //Method for email 
        public bool validateEmail(string email)
        {
            return Regex.IsMatch(email, REGEX_EMAIL);
        }
    }
}
