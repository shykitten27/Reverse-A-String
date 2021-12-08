using System;
using System.Linq;

namespace Reverse_A_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to be reversed.");
            string input = Console.ReadLine();
            var resultstring = new string(input.ToCharArray().Reverse().ToArray());
            Console.WriteLine(resultstring);
        }
    }
}
