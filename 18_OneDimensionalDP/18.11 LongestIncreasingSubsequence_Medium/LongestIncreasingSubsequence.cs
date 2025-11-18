using System;
using System.Collections.Generic;

namespace DSA._18_11_LongestIncreasingSubsequence_Medium;

/// <summary>
/// Problem 18.11 (Medium): Longest Increasing Subsequence
/// Given an integer array nums, return the length of the longest strictly increasing subsequence.
/// 
/// Example:
/// Input: nums = [10,9,2,5,3,7,101,18]
/// Output: 4
/// Explanation: The longest increasing subsequence is [2,3,7,18], therefore the length is 4.
/// 
/// Constraints:
/// - 1 <= nums.length <= 2500
/// - -10^4 <= nums[i] <= 10^4
/// </summary>
public class LongestIncreasingSubsequence
{
    public static int LengthOfLIS(int[] nums)
    {
        // TODO: Implement solution
        // Hint: DP[i] = length of LIS ending at index i
        // For each i, check all j < i where nums[j] < nums[i]
        // Optimize with binary search for O(n log n) solution
        // Time Complexity: O(n^2) or O(n log n) with binary search
        // Space Complexity: O(n)
        
        return 0;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 18.11: Longest Increasing Subsequence ===");
        
        int[] test1 = { 10, 9, 2, 5, 3, 7, 101, 18 };
        int result1 = LengthOfLIS(test1);
        Console.WriteLine($"Test 1 - Input: [10,9,2,5,3,7,101,18]");
        Console.WriteLine($"         Output: {result1}, Expected: 4");
        Console.WriteLine($"         {(result1 == 4 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[] test2 = { 0, 1, 0, 3, 2, 3 };
        int result2 = LengthOfLIS(test2);
        Console.WriteLine($"Test 2 - Input: [0,1,0,3,2,3]");
        Console.WriteLine($"         Output: {result2}, Expected: 4");
        Console.WriteLine($"         {(result2 == 4 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

