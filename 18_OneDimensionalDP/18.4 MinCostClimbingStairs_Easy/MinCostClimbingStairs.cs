using System;

namespace DSA._18_4_MinCostClimbingStairs_Easy;

/// <summary>
/// Problem 18.4 (Easy): Min Cost Climbing Stairs
/// You are given an integer array cost where cost[i] is the cost of ith step on a staircase.
/// Once you pay the cost, you can either climb one or two steps.
/// 
/// You can either start from the step with index 0, or the step with index 1.
/// 
/// Return the minimum cost to reach the top of the floor.
/// 
/// Example:
/// Input: cost = [10,15,20]
/// Output: 15
/// Explanation: You will start at index 1. Pay 15 and climb two steps to reach the top. The total cost is 15.
/// 
/// Constraints:
/// - 2 <= cost.length <= 1000
/// - 0 <= cost[i] <= 999
/// </summary>
public class MinCostClimbingStairs
{
    public static int Solution(int[] cost)
    {
        // TODO: Implement solution
        // Hint: DP[i] = cost[i] + min(DP[i-1], DP[i-2])
        // Time Complexity: O(n)
        // Space Complexity: O(1)
        
        return 0;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 18.4: Min Cost Climbing Stairs ===");
        
        int[] test1 = { 10, 15, 20 };
        int result1 = Solution(test1);
        Console.WriteLine($"Test 1 - Input: [10,15,20]");
        Console.WriteLine($"         Output: {result1}, Expected: 15");
        Console.WriteLine($"         {(result1 == 15 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[] test2 = { 1, 100, 1, 1, 1, 100, 1, 1, 100, 1 };
        int result2 = Solution(test2);
        Console.WriteLine($"Test 2 - Input: [1,100,1,1,1,100,1,1,100,1]");
        Console.WriteLine($"         Output: {result2}, Expected: 6");
        Console.WriteLine($"         {(result2 == 6 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

