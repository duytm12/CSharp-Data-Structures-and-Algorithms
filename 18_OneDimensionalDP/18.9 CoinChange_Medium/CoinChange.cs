using System;

namespace DSA._18_9_CoinChange_Medium;

/// <summary>
/// Problem 18.9 (Medium): Coin Change
/// You are given an integer array coins representing coins of different denominations and an integer
/// amount representing a total amount of money.
/// 
/// Return the fewest number of coins that you need to make up that amount. If that amount of money
/// cannot be made up by any combination of the coins, return -1.
/// 
/// You may assume that you have an infinite number of each kind of coin.
/// 
/// Example:
/// Input: coins = [1,2,5], amount = 11
/// Output: 3
/// Explanation: 11 = 5 + 5 + 1
/// 
/// Constraints:
/// - 1 <= coins.length <= 12
/// - 1 <= coins[i] <= 2^31 - 1
/// - 0 <= amount <= 10^4
/// </summary>
public class CoinChange
{
    public static int Solution(int[] coins, int amount)
    {
        // TODO: Implement solution
        // Hint: DP[i] = minimum coins to make amount i
        // DP[i] = min(DP[i], DP[i - coin] + 1) for each coin
        // Time Complexity: O(amount * coins.length)
        // Space Complexity: O(amount)
        
        return -1;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 18.9: Coin Change ===");
        
        int[] coins1 = { 1, 2, 5 };
        int result1 = Solution(coins1, 11);
        Console.WriteLine($"Test 1 - Input: coins = [1,2,5], amount = 11");
        Console.WriteLine($"         Output: {result1}, Expected: 3");
        Console.WriteLine($"         {(result1 == 3 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[] coins2 = { 2 };
        int result2 = Solution(coins2, 3);
        Console.WriteLine($"Test 2 - Input: coins = [2], amount = 3");
        Console.WriteLine($"         Output: {result2}, Expected: -1");
        Console.WriteLine($"         {(result2 == -1 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

