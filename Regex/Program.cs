using System;

namespace RegexPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Pattern pattern = new Pattern();
            Console.WriteLine(pattern.validateFirstName("Vba"));
        }
    }
}