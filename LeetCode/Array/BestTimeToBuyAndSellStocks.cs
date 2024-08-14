using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class BestTimeToBuyAndSellStocks
    {
        // takes the method and returns the max profit
        public int MaxProfit(int[] prices)
        {
            //ensures that any stock price will be less than it initially
            //will track the minimum price given so far
            int minPrice = int.MaxValue;
            int maxProfit = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                //finds the minimum price so far
                minPrice = Math.Min(minPrice, prices[i]);
                //gathers the expected profit 
                maxProfit = Math.Max(maxProfit, prices[i] - minPrice);
            }
            return maxProfit;
        }
    }
}
