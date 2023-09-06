using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    internal class FindTheIndexOfTheFirstOccurrenceInAString
    {
        public int StrStr(string haystack, string needle)
        {
            int k = haystack.IndexOf(needle);
            return k;
        }
    }
}
