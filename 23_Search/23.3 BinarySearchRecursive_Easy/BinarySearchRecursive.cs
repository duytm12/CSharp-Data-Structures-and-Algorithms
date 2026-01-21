using System;

namespace DSA._23_3_BinarySearchRecursive_Easy;

/// <summary>
/// Problem 23.3 (Easy): Binary Search (Recursive)
/// 
/// Binary Search finds the target in a sorted array by repeatedly dividing
/// the search interval in half. This is the recursive implementation.
/// 
/// Time Complexity: O(log n)
/// Space Complexity: O(log n) due to recursion stack
/// </summary>
public class BinarySearchRecursive
{
    public static int Solution(int[] nums, int target)
    {
        // TODO: Implement Binary Search (Recursive)
        // Hint: Use helper method with left and right parameters
        // Base case: if left > right, return -1
        // Recursive case: check middle and recurse on appropriate half
        return BinarySearchHelper(nums, target, 0, nums.Length - 1);
    }

    private static int BinarySearchHelper(int[] nums, int target, int left, int right)
    {
        // TODO: Implement recursive helper method
        if (left > right) return -1;
        var mid = left + (right - left) / 2;
        if (nums[mid] == target) return mid;
        if (nums[mid] < target)
            return BinarySearchHelper(nums, target, mid + 1, right);
        else
            return BinarySearchHelper(nums, target, left, mid - 1);

    }

    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 23.3: Binary Search (Recursive) ===");

        // Test Case 1: Target found in middle
        int[] test1 = { 1, 3, 5, 7, 9, 11, 13 };
        int result1 = Solution(test1, 7);
        int expected1 = 3;
        Console.WriteLine($"Test 1 - Input: nums = [1, 3, 5, 7, 9, 11, 13], target = 7");
        Console.WriteLine($"         Output: {result1}, Expected: {expected1}");
        Console.WriteLine($"         {(result1 == expected1 ? "✓ PASSED" : "✗ FAILED")}\n");

        // Test Case 2: Target not found
        int[] test2 = { 2, 4, 6, 8, 10 };
        int result2 = Solution(test2, 5);
        int expected2 = -1;
        Console.WriteLine($"Test 2 - Input: nums = [2, 4, 6, 8, 10], target = 5");
        Console.WriteLine($"         Output: {result2}, Expected: {expected2}");
        Console.WriteLine($"         {(result2 == expected2 ? "✓ PASSED" : "✗ FAILED")}\n");

        // Test Case 3: Single element array
        int[] test3 = { 42 };
        int result3 = Solution(test3, 42);
        int expected3 = 0;
        Console.WriteLine($"Test 3 - Input: nums = [42], target = 42");
        Console.WriteLine($"         Output: {result3}, Expected: {expected3}");
        Console.WriteLine($"         {(result3 == expected3 ? "✓ PASSED" : "✗ FAILED")}\n");

        // Test Case 4: Target less than all elements
        int[] test4 = { 10, 20, 30, 40, 50 };
        int result4 = Solution(test4, 5);
        int expected4 = -1;
        Console.WriteLine($"Test 4 - Input: nums = [10, 20, 30, 40, 50], target = 5");
        Console.WriteLine($"         Output: {result4}, Expected: {expected4}");
        Console.WriteLine($"         {(result4 == expected4 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}
