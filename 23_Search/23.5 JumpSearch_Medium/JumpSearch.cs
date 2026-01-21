using System;

namespace DSA._23_5_JumpSearch_Medium;

/// <summary>
/// Problem 23.5 (Medium): Jump Search
/// 
/// Jump Search finds the target in a sorted array by jumping ahead by fixed steps,
/// then performing a linear search in the block where the target might be.
/// Optimal block size is √n.
/// 
/// Time Complexity: O(√n)
/// Space Complexity: O(1)
/// </summary>
public class JumpSearch
{
    public static int Solution(int[] nums, int target)
    {
        // TODO: Implement Jump Search
        // Hint: Jump ahead by √n steps, then linear search in the block
        // Calculate optimal jump size as √n
        // Return -1 if target not found
        return -1;
    }

    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 23.5: Jump Search ===");

        // Test Case 1: Target found
        int[] test1 = { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610 };
        int result1 = Solution(test1, 55);
        int expected1 = 10;
        Console.WriteLine($"Test 1 - Input: nums = [0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610], target = 55");
        Console.WriteLine($"         Output: {result1}, Expected: {expected1}");
        Console.WriteLine($"         {(result1 == expected1 ? "✓ PASSED" : "✗ FAILED")}\n");

        // Test Case 2: Target not found
        int[] test2 = { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
        int result2 = Solution(test2, 35);
        int expected2 = -1;
        Console.WriteLine($"Test 2 - Input: nums = [10, 20, 30, 40, 50, 60, 70, 80, 90], target = 35");
        Console.WriteLine($"         Output: {result2}, Expected: {expected2}");
        Console.WriteLine($"         {(result2 == expected2 ? "✓ PASSED" : "✗ FAILED")}\n");

        // Test Case 3: Target at beginning
        int[] test3 = { 5, 10, 15, 20, 25, 30 };
        int result3 = Solution(test3, 5);
        int expected3 = 0;
        Console.WriteLine($"Test 3 - Input: nums = [5, 10, 15, 20, 25, 30], target = 5");
        Console.WriteLine($"         Output: {result3}, Expected: {expected3}");
        Console.WriteLine($"         {(result3 == expected3 ? "✓ PASSED" : "✗ FAILED")}\n");

        // Test Case 4: Target at end
        int[] test4 = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
        int result4 = Solution(test4, 19);
        int expected4 = 9;
        Console.WriteLine($"Test 4 - Input: nums = [1, 3, 5, 7, 9, 11, 13, 15, 17, 19], target = 19");
        Console.WriteLine($"         Output: {result4}, Expected: {expected4}");
        Console.WriteLine($"         {(result4 == expected4 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}
