using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    internal class RemoveDuplicatesFromSortedArray
    {
        public int RemoveDuplicates(int[] nums)
        {
            int k = 0;
            List<int> ListNums = nums.ToList();
            var result = ListNums.Distinct();
            foreach (int s in result)
            {
                nums[k] = s;
                k++;
            }
            return k;
        }
    }
}
