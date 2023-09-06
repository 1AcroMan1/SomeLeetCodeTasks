using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    internal class PalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            string numbers = x.ToString();
            int c = numbers.Length - 1;
            for (int a = 0; a < numbers.Length; a++)
            {
                if (numbers[c] != numbers[a])
                {
                    return false;
                }
                c--;
            }
            return true;
        }
    }
}
