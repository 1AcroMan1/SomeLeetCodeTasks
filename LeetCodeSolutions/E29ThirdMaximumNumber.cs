using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    internal class ThirdMaximumNumber
    {
        public int ThirdMax(int[] nums)
            => nums.Distinct().OrderByDescending(x => x).Cast<int?>().ElementAtOrDefault(2) ?? nums.Max();
    }
}
