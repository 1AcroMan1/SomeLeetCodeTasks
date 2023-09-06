using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    internal class SearchInsertPosition
    {
        public int SearchInsert(int[] nums, int target)
        {
            int k = 0;
            for (int i =0;i<nums.Length;i++)
            {
                if (nums[i] >= target)
                {
                    k = i;
                    break;
                }
                if(i==nums.Length-1 && nums[i]<target)
                {
                    k = i + 1;
                    break;
                }
            }
            return k;
        }
    }
}
