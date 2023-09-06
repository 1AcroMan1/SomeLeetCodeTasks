using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    internal class SummaryRanges
    {
        public IList<string> SummaryRangess(int[] nums)
        {
            List<string> ranges = new List<string>();
            int indexCheck = -1;
            bool isChecked = false;
            for (int i = 0; i < nums.Length; i++)
            {
                try
                {
                    if (nums[i] + 1 == nums[i+1])
                    {
                        if (isChecked == false)
                        {
                            indexCheck = i;
                        }
                        isChecked = true;
                    }
                    else
                    {
                        Check(indexCheck, ranges, i, nums);
                        indexCheck = -1;
                        isChecked = false;
                    }
                }
                catch
                {
                    Check(indexCheck, ranges, i, nums);
                    return ranges;
                }
            }
            return ranges;
        }
        private List<string> Check(int indexCheck, List<string> ranges, int i, int[] nums)
        {
            if (indexCheck == -1)
            {
                ranges.Add($"{nums[i]}");
            }
            else
            {
                ranges.Add($"{nums[indexCheck]}->{nums[i]}");
            }
            return ranges;
        }
    }
}
