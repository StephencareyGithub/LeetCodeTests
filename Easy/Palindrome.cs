using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTests.Easy
{
    internal class Palindrome
    {
        public bool IsPalindrome(int x)
        {
            char[] characters = x.ToString().ToCharArray();
            char[] reverse = characters.Reverse().ToArray();

            for (int index = 0; index < characters.Length; index ++)
            {
                if (characters[index] != reverse[index])
                    return false;
            }

            return true;
        }

    }
}
