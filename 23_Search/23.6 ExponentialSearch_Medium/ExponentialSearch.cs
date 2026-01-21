using System;

namespace DSA._23_6_ExponentialSearch_Medium;

/// <summary>
/// Problem 23.6 (Medium): Exponential Search
/// 
/// Exponential Search finds the range where the target might be by doubling
/// the index until finding a range, then uses binary search within that range.
/// Useful for unbounded or infinite arrays.
/// 
/// Time Complexity: O(log i) where i is the position of target
/// Space Complexity: O(1)
/// </summary>
public class ExponentialSearch
{
    public static int Solution(int[] nums, int target)
    {
        // TODO: Implement Exponential Search
        // Hint: Find range by doubling index, then binary search in that range
        // Start with index 1, double until nums[index] > target or out of bounds
        // Then binary search in range [index/2, min(index, nums.Length-1)]
        return -1;
    }

    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 23.6: Exponential Search ===");

        // Test Case 1: Target found
        int[] test1 = { 2, 3, 4, 10, 40, 45, 55, 60, 70, 80, 90 };
        int result1 = Solution(test1, 10);
        int expected1 = 3;
        Console.WriteLine($"Test 1 - Input: nums = [2, 3, 4, 10, 40, 45, 55, 60, 70, 80, 90], target = 10");
        Console.WriteLine($"         Output: {result1}, Expected: {expected1}");
        Console.WriteLine($"         {(result1 == expected1 ? "✓ PASSED" : "✗ FAILED")}\n");

        // Test Case 2: Target not found
        int[] test2 = { 1, 5, 10, 15, 20, 25, 30 };
        int result2 = Solution(test2, 12);
        int expected2 = -1;
        Console.WriteLine($"Test 2 - Input: nums = [1, 5, 10, 15, 20, 25, 30], target = 12");
        Console.WriteLine($"         Output: {result2}, Expected: {expected2}");
        Console.WriteLine($"         {(result2 == expected2 ? "✓ PASSED" : "✗ FAILED")}\n");

        // Test Case 3: Target at first position
        int[] test3 = { 5, 10, 15, 20, 25, 30, 35, 40 };
        int result3 = Solution(test3, 5);
        int expected3 = 0;
        Console.WriteLine($"Test 3 - Input: nums = [5, 10, 15, 20, 25, 30, 35, 40], target = 5");
        Console.WriteLine($"         Output: {result3}, Expected: {expected3}");
        Console.WriteLine($"         {(result3 == expected3 ? "✓ PASSED" : "✗ FAILED")}\n");

        // Test Case 4: Target at end
        int[] test4 = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
        int result4 = Solution(test4, 100);
        int expected4 = 9;
        Console.WriteLine($"Test 4 - Input: nums = [10, 20, 30, 40, 50, 60, 70, 80, 90, 100], target = 100");
        Console.WriteLine($"         Output: {result4}, Expected: {expected4}");
        Console.WriteLine($"         {(result4 == expected4 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}
