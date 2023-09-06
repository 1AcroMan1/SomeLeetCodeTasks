using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    internal class TopKFrequientElements
    {
        public int[] TopKFrequent(int[] nums, int k)       
            =>nums
             .GroupBy(x => x)
             .OrderByDescending(x => x.Count())
             .Take(k)
             .Select(c=>c.Key)
             .ToArray();
            //for (int i =0;i<k;i++)
            //{
            //    result.Add(nums.ElementAtOrDefault(i));
            //}
            //foreach (int i in result)
            //    Console.WriteLine(i);
            //return result.ToArray();
        
    }
}
