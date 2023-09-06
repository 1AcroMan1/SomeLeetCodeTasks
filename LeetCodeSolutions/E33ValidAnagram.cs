using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    internal class ValidAnagram
    {
        public bool IsAnagram(string s, string t)
        {
            s = string.Concat(s.OrderBy(c => c));
            t = string.Concat(t.OrderBy(c => c));
            return s == t ? true : false;
        }
    }
}
