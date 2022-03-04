using System;

namespace RegexPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Pattern pattern = new Pattern();

            // Console.WriteLine(pattern.validateFirstName("Vba"));
            // Console.WriteLine(pattern.validateLastName("Rao"));        

            //Console.WriteLine(pattern.validateEmail("abc@bl.in"));

            // Console.WriteLine(pattern.validateEmailSample("abc-111@yahoo.co.in"));

            /* string[] Emailsample = { "abc@yahoo.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc111@abc.com", "abc-100@abc.net", "abc.100@abc.com.au", "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com" };
             pattern.validateEmailSample(Emailsample);*/

            Console.WriteLine("Enter Your First Name");
            string fname = Console.ReadLine();
            Console.WriteLine(pattern.validateFirstName(fname));

            Console.WriteLine("Enter Your Last Name");
            string lname = Console.ReadLine();
            Console.WriteLine(pattern.validateLastName(lname));

            Console.WriteLine("Enter Your Email Address");
            string email = Console.ReadLine();
            Console.WriteLine(pattern.validateEmail(email));

            Console.WriteLine("Enter Your Mobile Number");
            string phNo = Console.ReadLine();
            Console.WriteLine(pattern.validateMobileNumber(phNo));

            Console.WriteLine("Enter Your Password");
            string prule1 = Console.ReadLine();
            Console.WriteLine(pattern.validatePaswordRule1(prule1));

            Console.WriteLine("Enter Your Password2");
            string prule2 = Console.ReadLine();
            Console.WriteLine(pattern.validatePaswordRule1(prule2));

            Console.WriteLine("Enter Your Password3");
            string prule3 = Console.ReadLine();
            Console.WriteLine(pattern.validatePaswordRule1(prule3));

            Console.WriteLine("Enter Your Password4");
            string prule4 = Console.ReadLine();
            Console.WriteLine(pattern.validatePaswordRule1(prule4));

            //Validating Sample Emails
            List<string> sampleEmailList = new List<string>()
            {
                "abc@yahoo.com",
                "abc-100@yahoo.com",
                "abc.100@yahoo.com",
                "abc111@abc.com",
                "abc-100@abc.net",
                "abc.100@abc.com.au",
                "abc@1.com",
                "abc@gmail.com.com",
                "abc+100@gmail.com"
            };
            foreach (string data in sampleEmailList)
            {
                if (pattern.validateEmail(data))
                {
                    Console.WriteLine("Valid Email");
                }
                else
                {
                    Console.WriteLine("Invalid Email");
                }
            }
        }
    }
}
        
    
