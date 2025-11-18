using System;

namespace DSA._18_1_ClimbingStairs_Easy;

/// <summary>
/// Problem 18.1 (Easy): Climbing Stairs
/// You are climbing a staircase. It takes n steps to reach the top. Each time you can either
/// climb 1 or 2 steps. In how many distinct ways can you climb to the top?
/// 
/// Example:
/// Input: n = 3
/// Output: 3 (ways: 1+1+1, 1+2, 2+1)
/// </summary>
public class ClimbingStairs
{
    public static int Solution(int n)
    {
        // TODO: Implement solution
        // Hint: DP[i] = DP[i-1] + DP[i-2], similar to Fibonacci
        // Time Complexity: O(n)
        // Space Complexity: O(1)
        
        return 0;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 18.1: Climbing Stairs ===");
        
        int result1 = Solution(3);
        Console.WriteLine($"Test 1 - Input: n = 3");
        Console.WriteLine($"         Output: {result1}, Expected: 3");
        Console.WriteLine($"         {(result1 == 3 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int result2 = Solution(2);
        Console.WriteLine($"Test 2 - Input: n = 2");
        Console.WriteLine($"         Output: {result2}, Expected: 2");
        Console.WriteLine($"         {(result2 == 2 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

