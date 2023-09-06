using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    internal class TeemoAtacking
    {
        public int FindPoisonedDuration(int[] timeSeries, int duration)
        {
            int count = duration;
            for (int i = 1; i < timeSeries.Length; i++)
            {
                int dif = timeSeries[i] - timeSeries[i - 1];
                count += duration > dif ? dif : duration;
            }
            return count;
        }
    }
}
