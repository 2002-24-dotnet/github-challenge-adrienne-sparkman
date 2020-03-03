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
            
            Console.WriteLine(l.isPalindrome(s));
        }
    }
}
