using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    internal class PascalsTriangle
    {
        public IList<IList<int>> Generate(int numRows)
        {

            List<List<int>> ints = new List<List<int>>()
            {
                new List<int>{1},
                new List<int>{1,1}
            };
            if (numRows == 1 || numRows == 2)
            {

            }
            for (int i = 2; i <= numRows; i++)
            {
                List<int> aded = new List<int>();
                for (int b = 0; b < i; b++)
                {
                    if (b == 0 || b == i - 1)
                    {
                        aded.Add(1);
                    }
                    else
                    {
                        aded.Add(ints[i - 1][b - 1] + ints[i - 1][b]);
                    }
                }
                ints.Add(aded);
            }
            ints.RemoveAt(1);
            return ints.ToArray();
        }
        public IList<int> GetRow(int rowIndex)
        {
            List<List<int>> ints = new List<List<int>>()
            {
                new List<int>{1},
                new List<int>{1,1}
            };
            for (int i = 2; i <= rowIndex+1; i++)
            {
                List<int> aded = new List<int>();
                for (int b = 0; b < i; b++)
                {
                    if (b == 0 || b == i - 1)
                    {
                        aded.Add(1);
                    }
                    else
                    {
                        aded.Add(ints[i - 1][b - 1] + ints[i - 1][b]);
                    }
                }
                ints.Add(aded);
            }
            ints.RemoveAt(1);
            return ints[rowIndex];
        }
    }
}
