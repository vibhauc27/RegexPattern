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


        public bool validateFirstName(string firstName) => (Regex.IsMatch(firstName, REGEX_FIRSTNAME));
        public bool validateLastName(string lastName) => (Regex.IsMatch(lastName, REGEX_LASTNAME));
        public bool validateEmail(string email) => (Regex.IsMatch(email, REGEX_EMAIL));
        public bool validateMobileNumber(string phNo) => (Regex.IsMatch(phNo, REGEX_MOBILENUMBER));
        public bool validatePaswordRule1(string prule1) => (Regex.IsMatch(prule1, REGEX_PASSWORDRULE1));
        public bool validatePaswordRule2(string prule2) => (Regex.IsMatch(prule2, REGEX_PASSWORDRULE2));
        public bool validatePaswordRule3(string prule3) => (Regex.IsMatch(prule3, REGEX_PASSWORDRULE3));
        public bool validatePaswordRule4(string prule4) => (Regex.IsMatch(prule4, REGEX_PASSWORDRULE4));

    }
}
