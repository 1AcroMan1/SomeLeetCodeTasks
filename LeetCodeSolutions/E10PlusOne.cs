using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    internal class PlusOne
    {
        public int[] PlusOnes(int[] digits)
        {
            List<int> listDigits = digits.ToList();
            for(int i=listDigits.Count-1;i>=0; i--)
            {
                if(listDigits.Count-1==i) listDigits[i] += 1;
                if (listDigits[i]==10)
                {
                    try
                    {
                        listDigits[i] = 0;
                        listDigits[i - 1] += 1;
                    }
                    catch
                    {
                        listDigits[i] = 0;
                        listDigits.Insert(0,1);
                    }
                }
            }
            return listDigits.ToArray();
        }
    }
}
