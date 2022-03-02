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

            Console.WriteLine(pattern.validatePaswordRule1("Qwertyyy"));
        }
    }
}