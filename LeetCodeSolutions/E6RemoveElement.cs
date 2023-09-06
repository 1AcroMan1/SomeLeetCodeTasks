using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    internal class RemoveElement
    {
        public int RemoveElements(int[] nums, int val)
        {
            var result = from n in nums
                         where n != val
                         select n;
            int k = 0;
            foreach (var n in result)
            {
                nums[k] = n;
                k++;
            }
            return k;
        }
    }
}
