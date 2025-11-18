using System;

namespace DSA._18_5_HouseRobberII_Medium;

/// <summary>
/// Problem 18.5 (Medium): House Robber II
/// You are a professional robber planning to rob houses along a street. Each house has a certain
/// amount of money stashed. All houses at this place are arranged in a circle. That means the first
/// house is the neighbor of the last one. Meanwhile, adjacent houses have a security system connected,
/// and it will automatically contact the police if two adjacent houses were broken into on the same night.
/// 
/// Given an integer array nums representing the amount of money of each house, return the maximum
/// amount of money you can rob tonight without alerting the police.
/// 
/// Example:
/// Input: nums = [2,3,2]
/// Output: 3
/// Explanation: You cannot rob house 1 (money = 2) and then rob house 3 (money = 2), because they are adjacent.
/// 
/// Constraints:
/// - 1 <= nums.length <= 100
/// - 0 <= nums[i] <= 1000
/// </summary>
public class HouseRobberII
{
    public static int Rob(int[] nums)
    {
        // TODO: Implement solution
        // Hint: Circular constraint - solve for [0..n-2] and [1..n-1] separately
        // Take maximum of two cases (rob first house or skip first house)
        // Time Complexity: O(n)
        // Space Complexity: O(1)
        
        return 0;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 18.5: House Robber II ===");
        
        int[] test1 = { 2, 3, 2 };
        int result1 = Rob(test1);
        Console.WriteLine($"Test 1 - Input: [2,3,2]");
        Console.WriteLine($"         Output: {result1}, Expected: 3");
        Console.WriteLine($"         {(result1 == 3 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[] test2 = { 1, 2, 3, 1 };
        int result2 = Rob(test2);
        Console.WriteLine($"Test 2 - Input: [1,2,3,1]");
        Console.WriteLine($"         Output: {result2}, Expected: 4");
        Console.WriteLine($"         {(result2 == 4 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

