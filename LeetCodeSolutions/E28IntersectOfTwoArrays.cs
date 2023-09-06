using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    internal class IntersectOfTwoArrays
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            return nums1.Intersect(nums2).ToArray();
        }
        //public int[] Intersection2(int[] nums1, int[] nums2)
        //{
        //    var n = from n1 in nums1
        //            from n2 in nums2
        //            where n1 == n2
        //            select n1;
        //    foreach (var i in n)
        //    {
        //        Console.WriteLine(i);
        //    }
        //    return null;
        //}
    }
}
