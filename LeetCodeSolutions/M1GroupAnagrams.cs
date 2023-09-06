using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    internal class GroupAnagrams
    {
        public IList<IList<string>> GroupAnagramss(string[] strs)
            => strs
                .GroupBy(s => string.Concat(s.OrderBy(c => c)))
                .Select(g => g.ToArray() as IList<string>)
                .ToList();
    }
}
