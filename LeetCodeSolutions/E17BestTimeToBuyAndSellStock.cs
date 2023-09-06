using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    internal class BestTimeToBuyAndSellStock
    {
        public int MaxProfit(int[] prices)
        {
            int minPrice = int.MaxValue;
            int maxProfit = int.MinValue;
            for (int i = 0; i<prices.Length;i++)
            {
                if (prices[i]<minPrice)
                {
                    minPrice = prices[i];
                }
                int profit = prices[i] - minPrice;
                if(profit>maxProfit)
                {
                    maxProfit = profit;
                }
            }
            return maxProfit;
        }
    }
}
