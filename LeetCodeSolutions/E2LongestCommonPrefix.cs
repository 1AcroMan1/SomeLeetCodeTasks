using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    internal class LongestCommonPrefix
    {
        public string LongestCommonPrefixs(string[] strs)
        {
            string smallest = strs.OrderBy(s => s.Length).First();
            for (int i =0; i<= smallest.Length;i++)
            {
                if (strs.Select(s => s[i]).Distinct().Count() > 1) return smallest;
            }
            return smallest;
        }
    }
}

