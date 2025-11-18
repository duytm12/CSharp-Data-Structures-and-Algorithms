using System;
using System.Collections.Generic;

namespace DSA._19_5_TargetSum_Medium;

/// <summary>
/// Problem 19.5 (Medium): Target Sum
/// You are given an integer array nums and an integer target.
/// 
/// You want to build an expression out of nums by adding one of the symbols '+' and '-' before
/// each integer in nums and then concatenate all the integers.
/// 
/// Return the number of different expressions that you can build, which evaluates to target.
/// 
/// Example:
/// Input: nums = [1,1,1,1,1], target = 3
/// Output: 5
/// Explanation: There are 5 ways to assign symbols to make the sum of nums be target 3.
/// -1 + 1 + 1 + 1 + 1 = 3
/// +1 - 1 + 1 + 1 + 1 = 3
/// +1 + 1 - 1 + 1 + 1 = 3
/// +1 + 1 + 1 - 1 + 1 = 3
/// +1 + 1 + 1 + 1 - 1 = 3
/// 
/// Constraints:
/// - 1 <= nums.length <= 20
/// - 0 <= nums[i] <= 1000
/// - 0 <= sum(nums[i]) <= 1000
/// - -1000 <= target <= 1000
/// </summary>
public class TargetSum
{
    public static int FindTargetSumWays(int[] nums, int target)
    {
        // TODO: Implement solution
        // Hint: Convert to subset sum problem
        // Find subsets with sum = (sum(nums) + target) / 2
        // Or use DP with memoization: DP[i][sum] = ways to reach sum using first i elements
        // Time Complexity: O(n * sum)
        // Space Complexity: O(n * sum) or O(sum) optimized
        
        return 0;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 19.5: Target Sum ===");
        
        int[] test1 = { 1, 1, 1, 1, 1 };
        int result1 = FindTargetSumWays(test1, 3);
        Console.WriteLine($"Test 1 - Input: nums = [1,1,1,1,1], target = 3");
        Console.WriteLine($"         Output: {result1}, Expected: 5");
        Console.WriteLine($"         {(result1 == 5 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[] test2 = { 1 };
        int result2 = FindTargetSumWays(test2, 1);
        Console.WriteLine($"Test 2 - Input: nums = [1], target = 1");
        Console.WriteLine($"         Output: {result2}, Expected: 1");
        Console.WriteLine($"         {(result2 == 1 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

