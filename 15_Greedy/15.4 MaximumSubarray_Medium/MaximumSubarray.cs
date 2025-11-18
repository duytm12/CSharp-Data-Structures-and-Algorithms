using System;

namespace DSA._15_4_MaximumSubarray_Medium;

/// <summary>
/// Problem 15.4 (Medium): Maximum Subarray
/// Given an integer array nums, find the contiguous subarray (containing at least one number)
/// which has the largest sum and return its sum.
/// 
/// Example:
/// Input: nums = [-2,1,-3,4,-1,2,1,-5,4]
/// Output: 6
/// Explanation: [4,-1,2,1] has the largest sum = 6.
/// 
/// Constraints:
/// - 1 <= nums.length <= 10^5
/// - -10^4 <= nums[i] <= 10^4
/// </summary>
public class MaximumSubarray
{
    public static int MaxSubArray(int[] nums)
    {
        // TODO: Implement solution
        // Hint: Kadane's algorithm - track maximum sum ending at current position
        // Time Complexity: O(n)
        // Space Complexity: O(1)
        
        return 0;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 15.4: Maximum Subarray ===");
        
        int[] test1 = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
        int result1 = MaxSubArray(test1);
        Console.WriteLine($"Test 1 - Input: [-2,1,-3,4,-1,2,1,-5,4]");
        Console.WriteLine($"         Output: {result1}, Expected: 6");
        Console.WriteLine($"         {(result1 == 6 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[] test2 = { 1 };
        int result2 = MaxSubArray(test2);
        Console.WriteLine($"Test 2 - Input: [1]");
        Console.WriteLine($"         Output: {result2}, Expected: 1");
        Console.WriteLine($"         {(result2 == 1 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

