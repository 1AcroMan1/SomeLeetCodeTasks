using System;

namespace LeetCodes
{
    /*
    class Program
    {
        static void Main(string[] args)
        {
            Realize rlz = new Realize();
            Console.WriteLine(rlz.RomanToInt("MCMXCIV"));
        }
    }
    class Realize
    {
            int[] numbers = new int[7] { 1, 5, 10, 50, 100, 500, 1000 };
            char[] symbols = new char[7] { 'I', 'V', 'X', 'L', 'C', 'D', 'M' };
            bool isSkip = false;
            private int CheckPlacedBefore(int i, string s, int result)
            {
                if (i - 1 < 0)
                {
                    return result;
                }
                if (result == numbers[1] || result == numbers[2])
                {
                    if (s[i - 1] == symbols[0])
                    {
                        result -= numbers[0];
                        isSkip = true;
                    }
                }
                if (result == numbers[3] || result == numbers[4])
                {
                    if (s[i - 1] == symbols[2])
                    {
                        result -= numbers[2];
                        isSkip = true;
                    }
                }
                if (result == numbers[5] || result == numbers[6])
                {
                    if (s[i - 1] == symbols[4])
                    {
                        result -= numbers[4];
                        isSkip = true;
                    }
                }
                return result;
            }
            public int RomanToInt(string s)
            {
                int totalSum = 0;
                for (int i = s.Length - 1; i >= 0; i--)
                {
                    if (isSkip == true)
                    {                  
                        isSkip = false;
                    }
                    else
                    {
                        for (int nums = 0; nums <= numbers.Length; nums++)
                        {
                            if (s[i] == symbols[nums] && nums == 0)
                            {
                                totalSum += numbers[nums];
                                break;
                            }
                            else if (s[i] == symbols[nums])
                            {
                                totalSum += CheckPlacedBefore(i, s, numbers[nums]);
                                break;
                            }
                        }
                    }
                }
                return totalSum;
            }
        }
    */
}
