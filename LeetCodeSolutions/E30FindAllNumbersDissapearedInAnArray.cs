using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    internal class FindAllNumbersDissapearedInAnArray
    {
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            return Enumerable.Range(1, nums.Count()).Except(nums.Distinct()).ToList();
        }
    }
}
