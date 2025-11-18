using System;

namespace DSA._19_4_CoinChangeII_Medium;

/// <summary>
/// Problem 19.4 (Medium): Coin Change II
/// You are given an integer array coins representing coins of different denominations and an
/// integer amount representing a total amount of money.
/// 
/// Return the number of combinations that make up that amount. If that amount of money cannot
/// be made up by any combination of the coins, return 0.
/// 
/// You may assume that you have an infinite number of each kind of coin.
/// 
/// Example:
/// Input: amount = 5, coins = [1,2,5]
/// Output: 4
/// Explanation: there are four ways to make up the amount:
/// 5=5
/// 5=2+2+1
/// 5=2+1+1+1
/// 5=1+1+1+1+1
/// 
/// Constraints:
/// - 1 <= coins.length <= 300
/// - 1 <= coins[i] <= 5000
/// - All the values of coins are unique.
/// - 0 <= amount <= 5000
/// </summary>
public class CoinChangeII
{
    public static int Change(int amount, int[] coins)
    {
        // TODO: Implement solution
        // Hint: Unbounded knapsack - count combinations
        // DP[i][j] = ways to make amount j using first i coins
        // Optimize to 1D: DP[j] += DP[j - coin]
        // Time Complexity: O(amount * coins.length)
        // Space Complexity: O(amount)
        
        return 0;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 19.4: Coin Change II ===");
        
        int[] coins1 = { 1, 2, 5 };
        int result1 = Change(5, coins1);
        Console.WriteLine($"Test 1 - Input: amount = 5, coins = [1,2,5]");
        Console.WriteLine($"         Output: {result1}, Expected: 4");
        Console.WriteLine($"         {(result1 == 4 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[] coins2 = { 2 };
        int result2 = Change(3, coins2);
        Console.WriteLine($"Test 2 - Input: amount = 3, coins = [2]");
        Console.WriteLine($"         Output: {result2}, Expected: 0");
        Console.WriteLine($"         {(result2 == 0 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

