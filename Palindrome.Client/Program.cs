using System;
using Palindrome.Domain;

namespace Palindrome.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Logic l = new Logic();
            Console.WriteLine("Enter the string to check for palindrome");
            string s = Console.ReadLine();

            if(l.isPalindrome(s))
            {
                Console.WriteLine(s + " is a palindrome");
            }
            else
            {
                Console.WriteLine(s + " is not a palindrome");
            }
        }
    }
}
