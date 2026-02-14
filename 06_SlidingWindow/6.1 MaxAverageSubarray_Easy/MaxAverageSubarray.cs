using System;

namespace DSA._6_1_MaxAverageSubarray_Easy;

/// <summary>
/// Problem 6.1 (Easy): Maximum Average Subarray
/// You are given an integer array nums consisting of n elements, and an integer k.
/// Find a contiguous subarray whose length is equal to k that has the maximum average value.
/// 
/// Example:
/// Input: nums = [1,12,-5,-6,50,3], k = 4
/// Output: 12.75
/// Explanation: Maximum average is (12-5-6+50)/4 = 51/4 = 12.75
/// 
/// Constraints:
/// - n == nums.length
/// - 1 <= k <= n <= 10^5
/// - -10^4 <= nums[i] <= 10^4
/// </summary>
public class MaxAverageSubarray
{
    public static double Solution(int[] nums, int k) 
    {
        // TODO: Implement solution
        // Hint: Fixed-size sliding window, maintain window sum
        // Time Complexity: O(n)
        // Space Complexity: O(1)

        if (k == nums.Length && k== 1) return nums[0]; //nums = [1,12,-5,-6,50,3], k = 4

        long windowSum = 0;
        for (int i = 0; i < k; i++)
        {
            windowSum += nums[i];
        }

        double maxSum = windowSum;

        for (int i = k; i < nums.Length; i++)
        {
            windowSum += nums[i] - nums[i - k];
            if (windowSum > maxSum) maxSum = windowSum;
        }
        
        return maxSum / k;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 6.1: Maximum Average Subarray ===");
        
        int[] test1 = [1, 12, -5, -6, 50, 3];
        int k1 = 4;
        double result1 = Solution(test1, k1);
        Console.WriteLine($"Test 1 - Input: nums = [1,12,-5,-6,50,3], k = {k1}");
        Console.WriteLine($"         Output: {result1:F2}, Expected: 12.75");
        Console.WriteLine($"         {(Math.Abs(result1 - 12.75) < 0.01 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[] test2 = [5];
        int k2 = 1;
        double result2 = Solution(test2, k2);
        Console.WriteLine($"Test 2 - Input: nums = [5], k = {k2}");
        Console.WriteLine($"         Output: {result2:F2}, Expected: 5.00");
        Console.WriteLine($"         {(Math.Abs(result2 - 5.0) < 0.01 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

