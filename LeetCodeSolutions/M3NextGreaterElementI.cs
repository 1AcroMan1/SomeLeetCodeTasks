using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    internal class NextGreaterElementI
    {
        public int[] NextGreaterElement(int[] nums1, int[] nums2)
        { 
            List<int> results = new List<int>();
            List<int> indexes = new List<int>();
            var numsToCheck = nums1.Intersect(nums2).ToArray();
            for (int i = 0; i < numsToCheck.Count(); i++)
            {
                List<int> dirtyNums2 = nums2.ToList();
                int index = Array.FindIndex(nums2, x => x == nums1[i]);
                //Console.WriteLine(nums2[index]);
                //Console.WriteLine(index + " index " + nums1[i] + " number");
                try
                {
                    if (index != 0)
                    {
                        dirtyNums2.RemoveRange(0, index);
                        //foreach (int x in dirtyNums2)
                            //Console.WriteLine(x+" test");
                    }
                    var k = dirtyNums2.Where(x => numsToCheck[i] < x).FirstOrDefault();
                    results.Add(k != 0 ? k : -1);
                }
                catch
                {
                    results.Add(-1);
                }
            }
            return results.ToArray();
        }
    }
}
