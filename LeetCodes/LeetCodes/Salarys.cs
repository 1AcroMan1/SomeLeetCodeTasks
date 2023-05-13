using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodes
{
    /* P.S можно в разы быстрее, но на этой версии .NET не работали методы .Sum() .Max() .Min() для массивов
    class Salarys
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            int[] salarys = new int[]{48000, 59000, 99000, 13000, 78000, 45000, 31000, 17000, 39000, 37000, 93000, 77000, 33000, 28000, 4000, 54000, 67000, 6000, 1000, 11000};
            Console.WriteLine(sol.Average(salarys)); 
        }
    }
    public class Solution
    {
        public double Average(int[] salary)
        {
            int max = Int32.MinValue;
            int min = Int32.MaxValue;
            double averages = 0;
            for(int i = 0;i<salary.Length;i++)
            {
                if(salary[i]>max)
                {
                    max = salary[i];
                }
                if (salary[i] < min)
                {
                    min = salary[i];
                }
                averages += salary[i];
            }
            return (averages - min - max)/(salary.Length-2);
        }
    }
    */
}
