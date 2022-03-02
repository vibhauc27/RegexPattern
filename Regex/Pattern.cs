using System;
using System.Text.RegularExpressions;

namespace RegexPattern
{
    public class Pattern
    {
        public static string REGEX_FIRSTNAME = "^[A-Z]{1}[A-Za-z]{2,}$"; //Vba
        public static string REGEX_LASTNAME = "^[A-Z]{1}[A-Za-z]{2,}$"; //Rao
        public static string REGEX_EMAIL = "^[a-zA-Z0-9.]+@[A-Za-z0-9]+.[A-Za-z]{2,4}$"; //abc@bl.in
        public static string REGEX_MOBILENUMBER = "^91[ ][1-9][0-9]{9}$"; //91 9876543210
        public static string REGEX_PASSWORDRULE1 = "^[a-zA-Z]{8,}$"; //Qwertyyy
        public static string REGEX_PASSWORDRULE2 = "^(?=.*[A-Z])[a-zA-Z]{8,}$";



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

        //Method for phone number
        public bool validateMobileNumber(string phNo)
        {
            return Regex.IsMatch(phNo, REGEX_MOBILENUMBER);
        }

        //method for password rule 1
        public bool validatePaswordRule1(string prule1)
        {
            return Regex.IsMatch(prule1, REGEX_PASSWORDRULE1);
        }

        //method for password rule 2
        public bool validatePaswordRule2(string prule2)
        {
            return Regex.IsMatch(prule2, REGEX_PASSWORDRULE2);
        }
    }
}
