using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    internal class SqrtX
    {
        public int MySqrt(int x)
        {
            if(x==1||x==0)
            {
                return x;
            }
            for (double i =0;i<=x;i++)
            {
                if(i*i>x)
                {
                    return Convert.ToInt32(i-1);
                }
            }
            return 0;
        }
    }
}
