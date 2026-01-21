using System;

namespace DSA._23_4_TernarySearch_Medium;

/// <summary>
/// Problem 23.4 (Medium): Ternary Search
/// 
/// Ternary Search divides the search space into three parts instead of two.
/// It's similar to binary search but uses two mid points to divide the array.
/// 
/// Time Complexity: O(log₃ n)
/// Space Complexity: O(1) iterative, O(log₃ n) recursive
/// </summary>
public class TernarySearch
{
    public static int Solution(int[] nums, int target)
    {
        // TODO: Implement Ternary Search
        // Hint: Divide array into three parts using mid1 and mid2
        // Compare target with both mid points and narrow search range
        // Return -1 if target not found
        return -1;
    }

    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 23.4: Ternary Search ===");

        // Test Case 1: Target found in first third
        int[] test1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int result1 = Solution(test1, 3);
        int expected1 = 2;
        Console.WriteLine($"Test 1 - Input: nums = [1, 2, 3, 4, 5, 6, 7, 8, 9], target = 3");
        Console.WriteLine($"         Output: {result1}, Expected: {expected1}");
        Console.WriteLine($"         {(result1 == expected1 ? "✓ PASSED" : "✗ FAILED")}\n");

        // Test Case 2: Target found in middle third
        int[] test2 = { 10, 20, 30, 40, 50, 60, 70 };
        int result2 = Solution(test2, 50);
        int expected2 = 4;
        Console.WriteLine($"Test 2 - Input: nums = [10, 20, 30, 40, 50, 60, 70], target = 50");
        Console.WriteLine($"         Output: {result2}, Expected: {expected2}");
        Console.WriteLine($"         {(result2 == expected2 ? "✓ PASSED" : "✗ FAILED")}\n");

        // Test Case 3: Target found in last third
        int[] test3 = { 5, 10, 15, 20, 25, 30, 35 };
        int result3 = Solution(test3, 35);
        int expected3 = 6;
        Console.WriteLine($"Test 3 - Input: nums = [5, 10, 15, 20, 25, 30, 35], target = 35");
        Console.WriteLine($"         Output: {result3}, Expected: {expected3}");
        Console.WriteLine($"         {(result3 == expected3 ? "✓ PASSED" : "✗ FAILED")}\n");

        // Test Case 4: Target not found
        int[] test4 = { 2, 4, 6, 8, 10, 12, 14 };
        int result4 = Solution(test4, 9);
        int expected4 = -1;
        Console.WriteLine($"Test 4 - Input: nums = [2, 4, 6, 8, 10, 12, 14], target = 9");
        Console.WriteLine($"         Output: {result4}, Expected: {expected4}");
        Console.WriteLine($"         {(result4 == expected4 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}
