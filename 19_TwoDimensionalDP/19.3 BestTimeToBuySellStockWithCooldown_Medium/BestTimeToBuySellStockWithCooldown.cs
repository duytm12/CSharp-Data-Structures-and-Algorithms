using System;

namespace DSA._19_3_BestTimeToBuySellStockWithCooldown_Medium;

/// <summary>
/// Problem 19.3 (Medium): Best Time to Buy and Sell Stock with Cooldown
/// You are given an array prices where prices[i] is the price of a given stock on the ith day.
/// 
/// Find the maximum profit you can achieve. You may complete as many transactions as you like
/// (i.e., buy one and sell one share of the stock multiple times) with the following restrictions:
/// - After you sell your stock, you cannot buy stock on the next day (i.e., cooldown one day).
/// 
/// Note: You may not engage in multiple transactions simultaneously (i.e., you must sell the stock before you buy again).
/// 
/// Example:
/// Input: prices = [1,2,3,0,2]
/// Output: 3
/// Explanation: transactions = [buy, sell, cooldown, buy, sell]
/// 
/// Constraints:
/// - 1 <= prices.length <= 5000
/// - 0 <= prices[i] <= 1000
/// </summary>
public class BestTimeToBuySellStockWithCooldown
{
    public static int MaxProfit(int[] prices)
    {
        // TODO: Implement solution
        // Hint: State machine DP with states: hold, sold, rest
        // hold[i] = max(hold[i-1], rest[i-1] - prices[i])
        // sold[i] = hold[i-1] + prices[i]
        // rest[i] = max(rest[i-1], sold[i-1])
        // Time Complexity: O(n)
        // Space Complexity: O(1)
        
        return 0;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 19.3: Best Time to Buy and Sell Stock with Cooldown ===");
        
        int[] test1 = { 1, 2, 3, 0, 2 };
        int result1 = MaxProfit(test1);
        Console.WriteLine($"Test 1 - Input: [1,2,3,0,2]");
        Console.WriteLine($"         Output: {result1}, Expected: 3");
        Console.WriteLine($"         {(result1 == 3 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[] test2 = { 1 };
        int result2 = MaxProfit(test2);
        Console.WriteLine($"Test 2 - Input: [1]");
        Console.WriteLine($"         Output: {result2}, Expected: 0");
        Console.WriteLine($"         {(result2 == 0 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

