using System;

namespace DSA._18_10_MaximumProductSubarray_Medium;

/// <summary>
/// Problem 18.10 (Medium): Maximum Product Subarray
/// Given an integer array nums, find a contiguous non-empty subarray within the array that has
/// the largest product, and return the product.
/// 
/// The test cases are generated so that the answer will fit in a 32-bit integer.
/// 
/// Example:
/// Input: nums = [2,3,-2,4]
/// Output: 6
/// Explanation: [2,3] has the largest product 6.
/// 
/// Constraints:
/// - 1 <= nums.length <= 2 * 10^4
/// - -10 <= nums[i] <= 10
/// - nums[i] is any integer.
/// </summary>
public class MaximumProductSubarray
{
    public static int MaxProduct(int[] nums)
    {
        // TODO: Implement solution
        // Hint: Track both max and min product (negative * negative = positive)
        // DP_max[i] = max(nums[i], nums[i] * DP_max[i-1], nums[i] * DP_min[i-1])
        // Time Complexity: O(n)
        // Space Complexity: O(1)
        
        return 0;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 18.10: Maximum Product Subarray ===");
        
        int[] test1 = { 2, 3, -2, 4 };
        int result1 = MaxProduct(test1);
        Console.WriteLine($"Test 1 - Input: [2,3,-2,4]");
        Console.WriteLine($"         Output: {result1}, Expected: 6");
        Console.WriteLine($"         {(result1 == 6 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[] test2 = { -2, 0, -1 };
        int result2 = MaxProduct(test2);
        Console.WriteLine($"Test 2 - Input: [-2,0,-1]");
        Console.WriteLine($"         Output: {result2}, Expected: 0");
        Console.WriteLine($"         {(result2 == 0 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

