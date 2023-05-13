using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodes
{
    /*
    class TwoSums
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            int[] s = new int[3] { 3,2,4};
            Console.WriteLine(sol.TwoSum(s,44));
        }
    }
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            if(nums==null||nums.Length<2)
            {
                return new int[2];
            }
            
            Dictionary<int, int> dic = new Dictionary<int, int>();
           
            for(int i = 0; i<nums.Length;i++)
            {
                if (dic.ContainsKey(target - nums[i]))
                {
                    return new int[] { i, dic[target - nums[i]] };
                }
                else if (!dic.ContainsKey(nums[i]))
                {
                    dic.Add(nums[i], i);
                }               
            }
            return new int[2];
        }
    }
    */
}
