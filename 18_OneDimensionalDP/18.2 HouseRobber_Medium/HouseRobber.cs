using System;

namespace DSA._18_2_HouseRobber_Medium;

/// <summary>
/// Problem 18.2 (Medium): House Robber
/// You are a robber planning to rob houses along a street. Each house has a certain amount of
/// money. You cannot rob two adjacent houses. Return the maximum amount of money you can rob.
/// 
/// Example:
/// Input: nums = [2,7,9,3,1]
/// Output: 12 (rob houses 0, 2, 4)
/// </summary>
public class HouseRobber
{
    public static int Solution(int[] nums)
    {
        // TODO: Implement solution
        // Hint: DP[i] = max(DP[i-1], DP[i-2] + nums[i])
        // Time Complexity: O(n)
        // Space Complexity: O(1)
        
        return 0;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 18.2: House Robber ===");
        
        int[] test1 = { 2, 7, 9, 3, 1 };
        int result1 = Solution(test1);
        Console.WriteLine($"Test 1 - Input: [2,7,9,3,1]");
        Console.WriteLine($"         Output: {result1}, Expected: 12");
        Console.WriteLine($"         {(result1 == 12 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[] test2 = { 1, 2, 3, 1 };
        int result2 = Solution(test2);
        Console.WriteLine($"Test 2 - Input: [1,2,3,1]");
        Console.WriteLine($"         Output: {result2}, Expected: 4");
        Console.WriteLine($"         {(result2 == 4 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

