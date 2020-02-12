using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_CS
{
    class StockQuestion
    {
        // Best Time to Buy and Sell Stock : I      
        // Say you have an array for which the ith element is the price of a given stock on day i.
        //     If you were only permitted to complete at most one transaction(i.e., buy one and sell one share of the stock), design an algorithm to find the maximum profit.
        //    Note that you cannot sell a stock before you buy one.
        //    Example 1:
        //    Input: [7,1,5,3,6,4]
        //Output: 5
        //Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
        //             Not 7-1 = 6, as selling price needs to be larger than buying price.
        //Example 2:
        //Input: [7,6,4,3,1]
        //        Output: 0
        //Explanation: In this case, no transaction is done, i.e.max profit = 0.
        public int MaxProfit(int[] prices)
        {
            if (prices == null || prices.Length <= 0) return 0;
            int max = 0;
            int min = prices[0];
            for (int i = 1; i <= prices.Length; i++)
            {
                max = Math.Max(max, prices[i] - min);
                min = Math.Min(min, prices[i]);
            }
            return max;
        }
        //        Best Time to Buy and Sell Stock II

        //Say you have an array for which the ith element is the price of a given stock on day i.
        //Design an algorithm to find the maximum profit.You may complete as many transactions as you like (ie, buy one and sell one share of the stock multiple times). However, you may not engage in multiple transactions at the same time(ie, you must sell the stock before you buy again).
        public int MaxProfit2(int[] prices)
        {
            int ret = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                ret += prices[i] > prices[i - 1] ? prices[i] - prices[i - 1] : 0;
            }
            return ret;
        }
    }

    class StockSpanner
    {
        private Stack<int> prices;
        private Stack<int> spans;
        public StockSpanner()
        {
            prices = new Stack<int>();
            spans = new Stack<int>();
        }

        public int next(int price)
        {
            int span = 1;
            while (prices.Count > 0 && price >= prices.Peek())
            {
                span += spans.Pop();
                prices.Pop();
            }
            prices.Push(price);
            spans.Push(span);
            return span;
        }
    }
}
