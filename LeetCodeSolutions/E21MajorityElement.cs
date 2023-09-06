using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    internal class MajorityElement
    {
        public int MajorityElements(int[] nums)
        {
            return nums.GroupBy(x => x).Where(g => g.Count() > nums.Length / 2).Select(g => g.Key).First();
        }
    }
}
