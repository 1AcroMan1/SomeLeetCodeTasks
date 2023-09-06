using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    internal class ContainsDuplicate
    {
        public bool ContainsDuplicates(int[] nums)
        {
            return nums.GroupBy(x => x).Any(x => x.Count() > 1);
        }
    }
}


