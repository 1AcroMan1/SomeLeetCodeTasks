using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    internal class SingleNumber
    {
        public int SingleNumbers(int[] nums)
        {
            return nums.GroupBy(x => x).Where(g => g.Count() == 1).Select(x => x.Key).First();
        }
    }
}
