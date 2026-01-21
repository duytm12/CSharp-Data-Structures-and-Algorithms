using System;

namespace DSA._23_2_BinarySearchIterative_Easy;

/// <summary>
/// Problem 23.2 (Easy): Binary Search (Iterative)
/// 
/// Binary Search finds the target in a sorted array by repeatedly dividing
/// the search interval in half. This is the iterative implementation.
/// 
/// Time Complexity: O(log n)
/// Space Complexity: O(1)
/// </summary>
public class BinarySearchIterative
{
    public static int Solution(int[] nums, int target)
    {
        // TODO: Implement Binary Search (Iterative)
        // Hint: Use while loop with left and right pointers
        // Compare target with middle element and adjust search range
        // Return -1 if target not found
        int left = 0;
        int right = nums.Length - 1;


        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (nums[mid] == target) return mid;
            else if (nums[mid] < target)
            {
                left = mid+1;
            }
            else right = mid-1;
        }

        return -1;
    }

    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 23.2: Binary Search (Iterative) ===");

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

        // Test Case 3: Target at first position
        int[] test3 = { 10, 20, 30, 40, 50 };
        int result3 = Solution(test3, 10);
        int expected3 = 0;
        Console.WriteLine($"Test 3 - Input: nums = [10, 20, 30, 40, 50], target = 10");
        Console.WriteLine($"         Output: {result3}, Expected: {expected3}");
        Console.WriteLine($"         {(result3 == expected3 ? "✓ PASSED" : "✗ FAILED")}\n");

        // Test Case 4: Target at last position
        int[] test4 = { 5, 10, 15, 20, 25, 30 };
        int result4 = Solution(test4, 30);
        int expected4 = 5;
        Console.WriteLine($"Test 4 - Input: nums = [5, 10, 15, 20, 25, 30], target = 30");
        Console.WriteLine($"         Output: {result4}, Expected: {expected4}");
        Console.WriteLine($"         {(result4 == expected4 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}
