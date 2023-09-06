using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    internal class Test
    {
        public int Tests(string[] s)
        {
            return s.Skip(1).Where((next, c) => next != s[c+1]).Max().Count();
        }
    }
}