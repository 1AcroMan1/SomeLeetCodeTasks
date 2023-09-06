using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    internal class LengthOfLastWord
    {
        public int LengthOfLastWords(string s)
        {
            int k = 0;
            char[] strChar = s.ToCharArray();            
            for (int i = strChar.Length-1;i>=0;i--)
            {
                if (strChar[i] !=' ')
                {
                    k++;
                }
                else
                {
                    if(k!=0)
                    {
                        return k;
                    }
                }
            }
            return k;
        }
    }
}
