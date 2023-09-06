using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    internal class MoveZeroes
    {
        public void MoveZeroess(int[] nums)
        {
            var zeroes = nums.Where(x => x == 0).ToArray();
            nums = nums.Where(x => x != 0).Concat(zeroes).ToArray();
            foreach (int i in nums)
            {
                Console.WriteLine(i);
            }
        }
    }
}
