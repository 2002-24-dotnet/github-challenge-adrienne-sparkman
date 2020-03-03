using System;

namespace Palindrome.Domain
{
    public class Logic
    {

        public string simplify(string s)
        {
            s= s.ToLower();
            s= s.Replace(" ", "");
            s= s.Replace(".", "");
            s= s.Replace("?", "");
            s= s.Replace(",", "");
            s= s.Replace("!", "");
            return s;
        }
        public bool isPalindrome(string s)
        {
            s=simplify(s);
            char[] letters = new char[s.Length];
            for(int i=0; i<s.Length; i++)
            {
                letters[i] = s[s.Length-i-1];
            }

            string reverse = new string(letters);
            return Equals(s,reverse);
        }
    }
}
