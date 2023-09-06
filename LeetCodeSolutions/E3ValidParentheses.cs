using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    internal class ValidParentheses
    {
        public bool IsValid(string s)
        {
            List<char> arr = s.ToList();
            if (arr.Count == 1 || arr.Count == 0)
            {
                return false;
            }
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i].Equals('}'))
                {
                    if (i != 0 && arr[i - 1].Equals('{'))
                    {
                        arr.RemoveAt(i - 1);
                        arr.RemoveAt(i - 1);
                        i -= 2;
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (arr[i].Equals(')'))
                {
                    if (i != 0 && arr[i - 1].Equals('('))
                    {
                        arr.RemoveAt(i - 1);
                        arr.RemoveAt(i - 1);
                        i -= 2;
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (arr[i].Equals(']'))
                {
                    if (i != 0 && arr[i - 1].Equals('['))
                    {
                        arr.RemoveAt(i - 1);
                        arr.RemoveAt(i - 1);
                        i -= 2;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            if (arr.Count == 0)
            {
                return true;
            }
            return false;

        }
    }
}

