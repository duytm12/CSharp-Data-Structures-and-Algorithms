using System;

namespace DSA._15_1_BestTimeToBuySellStock_Easy;

/// <summary>
/// Problem 15.1 (Easy): Best Time to Buy and Sell Stock
/// You are given an array prices where prices[i] is the price of a given stock on the ith day.
/// Find the maximum profit you can achieve by buying on one day and selling on a later day.
/// 
/// Example:
/// Input: prices = [7,1,5,3,6,4]
/// Output: 5 (buy at 1, sell at 6)
/// </summary>
public class BestTimeToBuySellStock
{
    public static int Solution(int[] prices)
    {
        if (prices.Length == 1) return 0;
        int maxProfit = 0;

        //Solution 1: Calculate maxProfit based on minBuy
        int minBuyPrice = 10000;

        for (int i = 0; i < prices.Length; i++)
        {
            if (prices[i] < minBuyPrice)
            {
                minBuyPrice = prices[i];
            }
            else
            {
                int profit = prices[i] - minBuyPrice;
                if (profit > maxProfit)
                {
                    maxProfit = profit;
                }
            }
        }

        // Solution 2: Calculate maxProfit based on maxSell
        int maxSellPrice = 0;

        for (int i = prices.Length - 1; i >= 0; i--)
        {
            if (prices[i] > maxSellPrice)
            {
                maxSellPrice = prices[i];
            }
            else
            {
                int profit = maxSellPrice - prices[i]; // 4,5,1,2,3,4
                if (profit > maxProfit)
                {
                    maxProfit = profit;
                }
            }

        }

        return maxProfit;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 15.1: Best Time to Buy and Sell Stock ===");
        
        int[] test1 = { 7, 1, 5, 3, 6, 4 };
        int result1 = Solution(test1);
        Console.WriteLine($"Test 1 - Input: [7,1,5,3,6,4]");
        Console.WriteLine($"         Output: {result1}, Expected: 5");
        Console.WriteLine($"         {(result1 == 5 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[] test2 = { 7, 6, 4, 3, 1 };
        int result2 = Solution(test2);
        Console.WriteLine($"Test 2 - Input: [7,6,4,3,1]");
        Console.WriteLine($"         Output: {result2}, Expected: 0");
        Console.WriteLine($"         {(result2 == 0 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

