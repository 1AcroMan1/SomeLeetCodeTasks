using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    internal class ValidPalindrome
    {
        public bool IsPalindrome(string s)
        {
            var result = s.ToLower().Where(q => char.IsLetterOrDigit(q));
            return result.Reverse().SequenceEqual(result);

            //var result = from n in s
            //             where Char.IsLetterOrDigit(n)
            //             select n;
            //string q = "";
            //foreach (var n in result)
            //{
            //    q += n.ToString().ToLower();
            //}
            //return q.Reverse().SequenceEqual(q);
        }
    }
}
