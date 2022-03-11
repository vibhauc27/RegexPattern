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
        public static string REGEX_PASSWORDRULE3 = "^(?=.*[A-Z])(?=.*[0-9])[0-9a-zA-Z]{8,}$";
        public static string REGEX_PASSWORDRULE4 = "^([a-zA-Z0-9])[!@#$%^&]{1}([a-zA-Z0-9])*$";
        public static string REGEX_CLEARALLEMAILSAMPLE = "^[a-z]{3,}[_+-.]{0,1}[a-z]{3,}[@][a-z]{5,}[.][a-z]{2}[.][a-z]{2}"; // abc-111@yahoo.co.in


        //Method for first name 
        public bool validateFirstName(string fname)
        {
            if (Regex.IsMatch(fname, REGEX_FIRSTNAME))
                return true;
            else
                throw new InvalidUserDetailException(InvalidUserDetailException.ExceptionType.INVALID_FIRSTNAME, "Invalid First Name");
        }
        
        //Method for last name 
        public bool validateLastName(string lname)
        {
            if (Regex.IsMatch(lname, REGEX_LASTNAME))
                return true;
            else
                throw new InvalidUserDetailException(InvalidUserDetailException.ExceptionType.INVALID_LASTNAME, "Invalid Last Name");
        }

        //Method for email 
        public bool validateEmail(string email)
        {
            if (Regex.IsMatch(email, REGEX_EMAIL))
                return true;
            else
                throw new InvalidUserDetailException(InvalidUserDetailException.ExceptionType.INVALID_EMAIL, "Invalid Email");
        }

        //Method for phone number
        public bool validateMobileNumber(string phNo)
        {
            if (Regex.IsMatch(phNo, REGEX_MOBILENUMBER))
                return true;
            else
                throw new InvalidUserDetailException(InvalidUserDetailException.ExceptionType.INVALID_MOBILE, "Invalid Mobile Number");
        }

        //method for password rule 1
        public bool validatePaswordRule1(string prule1)
        {
            if (Regex.IsMatch(prule1, REGEX_PASSWORDRULE1))
                return true;
            else
                throw new InvalidUserDetailException(InvalidUserDetailException.ExceptionType.INVALID_PASSWORD, "Invalid Password");
        }

        //method for password rule 2
        public bool validatePaswordRule2(string prule2)
        {
            if (Regex.IsMatch(prule2, REGEX_PASSWORDRULE2))
                return true;
            else
                throw new InvalidUserDetailException(InvalidUserDetailException.ExceptionType.INVALID_PASSWORD, "Invalid Password");
        }

        public bool validatePaswordRule3(string prule3)
        {
            if (Regex.IsMatch(prule3, REGEX_PASSWORDRULE3))
                return true;
            else
                throw new InvalidUserDetailException(InvalidUserDetailException.ExceptionType.INVALID_PASSWORD, "Invalid Password");
        }
        public bool validatePaswordRule4(string prule4)
        {
            if (Regex.IsMatch(prule4, REGEX_PASSWORDRULE4))
                return true;
            else
                throw new InvalidUserDetailException(InvalidUserDetailException.ExceptionType.INVALID_PASSWORD, "Invalid Password");
        }

        /*public bool validateEmailSample(string[] Emailsample)
        {
            return Regex.IsMatch(Emailsample, REGEX_CLEARALLEMAILSAMPLE);
        }*/
    }
}
