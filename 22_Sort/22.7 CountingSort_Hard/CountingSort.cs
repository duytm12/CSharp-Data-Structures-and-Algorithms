using System;

namespace DSA._22_7_CountingSort_Hard;

/// <summary>
/// Problem 22.7 (Hard): Counting Sort
/// 
/// Counting Sort is a non-comparison-based sorting algorithm that works by counting
/// the number of occurrences of each distinct element. It's efficient when the range
/// of input values is small.
/// 
/// Time Complexity: O(n + k) where k is the range of input
/// Space Complexity: O(k)
/// </summary>
public class CountingSort
{
    public static int[] Solution(int[] nums)
    {
        // TODO: Implement Counting Sort
        // Hint: Count frequency of each value, then reconstruct sorted array
        // Assumes non-negative integers with a known range
        return [];
    }

    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 22.7: Counting Sort ===");

        // Test Case 1: Basic array with small range
        int[] test1 = { 4, 2, 2, 8, 3, 3, 1 };
        int[] result1 = Solution(test1);
        int[] expected1 = { 1, 2, 2, 3, 3, 4, 8 };
        Console.WriteLine($"Test 1 - Input: [4, 2, 2, 8, 3, 3, 1]");
        Console.WriteLine($"         Output: [{string.Join(", ", result1)}]");
        Console.WriteLine($"         Expected: [{string.Join(", ", expected1)}]");
        bool passed1 = ArraysEqual(result1, expected1);
        Console.WriteLine($"         {(passed1 ? "✓ PASSED" : "✗ FAILED")}\n");

        // Test Case 2: Array with zeros
        int[] test2 = { 0, 1, 0, 2, 1, 0 };
        int[] result2 = Solution(test2);
        int[] expected2 = { 0, 0, 0, 1, 1, 2 };
        Console.WriteLine($"Test 2 - Input: [0, 1, 0, 2, 1, 0]");
        Console.WriteLine($"         Output: [{string.Join(", ", result2)}]");
        Console.WriteLine($"         Expected: [{string.Join(", ", expected2)}]");
        bool passed2 = ArraysEqual(result2, expected2);
        Console.WriteLine($"         {(passed2 ? "✓ PASSED" : "✗ FAILED")}\n");

        // Test Case 3: Single repeated value
        int[] test3 = { 5, 5, 5, 5, 5 };
        int[] result3 = Solution(test3);
        int[] expected3 = { 5, 5, 5, 5, 5 };
        Console.WriteLine($"Test 3 - Input: [5, 5, 5, 5, 5]");
        Console.WriteLine($"         Output: [{string.Join(", ", result3)}]");
        Console.WriteLine($"         Expected: [{string.Join(", ", expected3)}]");
        bool passed3 = ArraysEqual(result3, expected3);
        Console.WriteLine($"         {(passed3 ? "✓ PASSED" : "✗ FAILED")}\n");

        // Test Case 4: Already sorted
        int[] test4 = { 1, 2, 3, 4, 5 };
        int[] result4 = Solution(test4);
        int[] expected4 = { 1, 2, 3, 4, 5 };
        Console.WriteLine($"Test 4 - Input: [1, 2, 3, 4, 5]");
        Console.WriteLine($"         Output: [{string.Join(", ", result4)}]");
        Console.WriteLine($"         Expected: [{string.Join(", ", expected4)}]");
        bool passed4 = ArraysEqual(result4, expected4);
        Console.WriteLine($"         {(passed4 ? "✓ PASSED" : "✗ FAILED")}\n");
    }

    private static bool ArraysEqual(int[] arr1, int[] arr2)
    {
        if (arr1.Length != arr2.Length) return false;
        for (int i = 0; i < arr1.Length; i++)
        {
            if (arr1[i] != arr2[i]) return false;
        }
        return true;
    }
}
