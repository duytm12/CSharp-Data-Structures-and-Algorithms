using System;

namespace DSA._6_4_BestTimeToBuySellStock_Easy;

/// <summary>
/// Problem 6.4 (Easy): Best Time to Buy and Sell Stock
/// You are given an array prices where prices[i] is the price of a given stock on the ith day.
/// You want to maximize your profit by choosing a single day to buy one stock and choosing a
/// different day in the future to sell that stock.
/// 
/// Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.
/// 
/// Example:
/// Input: prices = [7,1,5,3,6,4]
/// Output: 5
/// Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
/// Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.
/// 
/// Constraints:
/// - 1 <= prices.length <= 10^5
/// - 0 <= prices[i] <= 10^4
/// </summary>
public class BestTimeToBuySellStock
{
    public static int MaxProfit(int[] prices)
    {
        // TODO: Implement solution
        // Hint: Sliding window - track minimum price seen so far, calculate max profit
        // Time Complexity: O(n)
        // Space Complexity: O(1)

        // Buy min, sell max
        if (prices.Length < 2) return 0;

        // int maxProfit = 0;

        // int minBuy = int.MaxValue;

        // for (int i = 0; i < prices.Length; i++)
        // {

        //     if (prices[i] < minBuy) minBuy = prices[i];

        //     int profit = prices[i] - minBuy;

        //     if (profit > maxProfit) maxProfit = profit;
        // }

        // return maxProfit;

        int maxProfit = 0;
        int left = 0;
        int right = 1;

        while (right < prices.Length)
        {
            if (prices[right] > prices[left])
            {
                int profit = prices[right] - prices[left];
                if (profit > maxProfit) maxProfit = profit;
            }

            else
            {
                left = right;
            }
            right++;
        }

        return maxProfit;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 6.4: Best Time to Buy and Sell Stock ===");
        
        int[] test1 = { 7, 1, 5, 3, 6, 4 };
        int result1 = MaxProfit(test1);
        Console.WriteLine($"Test 1 - Input: [7,1,5,3,6,4]");
        Console.WriteLine($"         Output: {result1}, Expected: 5");
        Console.WriteLine($"         {(result1 == 5 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[] test2 = { 7, 6, 4, 3, 1 };
        int result2 = MaxProfit(test2);
        Console.WriteLine($"Test 2 - Input: [7,6,4,3,1]");
        Console.WriteLine($"         Output: {result2}, Expected: 0");
        Console.WriteLine($"         {(result2 == 0 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

