using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    internal class MergeSortedArray
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            List<int> nums1New = new List<int>();
            List<int> nums2New = new List<int>();
            for (int a = 0;a<=m-1;a++)
            {
                nums1New.Add(nums1[a]);
            }
            for (int b = 0; b <= n - 1; b++)
            {
                nums2New.Add(nums2[b]);
            }
            var result = nums1New.Concat(nums2New).OrderBy(x=>x);
            int k = 0;
            foreach (var a in result)
            {
                nums1[k] = a;
                k++;
            }                       
        }
    }
}
