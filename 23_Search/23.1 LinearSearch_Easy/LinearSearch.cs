using System;

namespace DSA._23_1_LinearSearch_Easy;

/// <summary>
/// Problem 23.1 (Easy): Linear Search
/// 
/// Linear Search sequentially checks each element of the array until the target
/// is found or the end of the array is reached.
/// 
/// Time Complexity: O(n)
/// Space Complexity: O(1)
/// </summary>
public class LinearSearch
{
    public static int Solution(int[] nums, int target)
    {
        // TODO: Implement Linear Search
        // Hint: Iterate through array and return index when target is found
        // Return -1 if target not found
        return -1;
    }

    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 23.1: Linear Search ===");

        // Test Case 1: Target found in middle
        int[] test1 = { 10, 20, 30, 40, 50 };
        int result1 = Solution(test1, 30);
        int expected1 = 2;
        Console.WriteLine($"Test 1 - Input: nums = [10, 20, 30, 40, 50], target = 30");
        Console.WriteLine($"         Output: {result1}, Expected: {expected1}");
        Console.WriteLine($"         {(result1 == expected1 ? "✓ PASSED" : "✗ FAILED")}\n");

        // Test Case 2: Target not found
        int[] test2 = { 5, 15, 25, 35 };
        int result2 = Solution(test2, 20);
        int expected2 = -1;
        Console.WriteLine($"Test 2 - Input: nums = [5, 15, 25, 35], target = 20");
        Console.WriteLine($"         Output: {result2}, Expected: {expected2}");
        Console.WriteLine($"         {(result2 == expected2 ? "✓ PASSED" : "✗ FAILED")}\n");

        // Test Case 3: Target at first position
        int[] test3 = { 7, 14, 21, 28 };
        int result3 = Solution(test3, 7);
        int expected3 = 0;
        Console.WriteLine($"Test 3 - Input: nums = [7, 14, 21, 28], target = 7");
        Console.WriteLine($"         Output: {result3}, Expected: {expected3}");
        Console.WriteLine($"         {(result3 == expected3 ? "✓ PASSED" : "✗ FAILED")}\n");

        // Test Case 4: Target at last position with duplicates
        int[] test4 = { 3, 6, 3, 9, 6, 12 };
        int result4 = Solution(test4, 12);
        int expected4 = 5;
        Console.WriteLine($"Test 4 - Input: nums = [3, 6, 3, 9, 6, 12], target = 12");
        Console.WriteLine($"         Output: {result4}, Expected: {expected4}");
        Console.WriteLine($"         {(result4 == expected4 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}
