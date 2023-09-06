using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    internal class MissingNumber
    {
        public int MissingNumbers(int[] nums)
            => Enumerable.Range(0, nums.Length+1).Sum() - nums.Sum();
        
        public int MissingNumberss(int[] nums)
            => Enumerable.Range(0, nums.Length).Aggregate(nums.Length, (x, i) => x ^ i ^ nums[i]);
           
        
    }
}
