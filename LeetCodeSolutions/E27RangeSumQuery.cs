using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public class NumArray
    {
        private int[] arr;
        public NumArray(int[] nums)
        {
            arr = new int[nums.Length + 1];
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                arr[i]=arr[i + 1] + nums[i];
            }
        }

        public int SumRange(int left, int right)
        {
            return arr[left] - arr[right+1];
        }
    }
}
