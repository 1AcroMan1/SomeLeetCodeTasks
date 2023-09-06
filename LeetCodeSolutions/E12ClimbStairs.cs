using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    internal class ClimbStairs
    {
        public int ClimbStairss(int n)
        {
            if(n==1)
            {
                return n;
            }
            int[] ints = new int[n+1];
            ints[1] = 1;
            ints[2] = 2;
            for (int i = 3;i<=n;i++)
            {
                ints[i] = ints[i - 1] + ints[i - 2];
            }
            return ints[n];
        }
    }
}
