using System;

namespace DSA._22_2_SelectionSort_Easy;

/// <summary>
/// Problem 22.2 (Easy): Selection Sort
/// 
/// Selection Sort finds the minimum element from the unsorted portion and places it
/// at the beginning. The algorithm maintains two subarrays: sorted and unsorted.
/// 
/// Time Complexity: O(n²) in all cases
/// Space Complexity: O(1)
/// </summary>
public class SelectionSort
{
    public static int[] Solution(int[] nums)
    {
        // TODO: Implement Selection Sort
        // Hint: Find minimum element in unsorted portion and swap with first unsorted element
        return [];
    }

    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 22.2: Selection Sort ===");

        // Test Case 1: Basic unsorted array
        int[] test1 = { 64, 25, 12, 22, 11 };
        int[] result1 = Solution(test1);
        int[] expected1 = { 11, 12, 22, 25, 64 };
        Console.WriteLine($"Test 1 - Input: [64, 25, 12, 22, 11]");
        Console.WriteLine($"         Output: [{string.Join(", ", result1)}]");
        Console.WriteLine($"         Expected: [{string.Join(", ", expected1)}]");
        bool passed1 = ArraysEqual(result1, expected1);
        Console.WriteLine($"         {(passed1 ? "✓ PASSED" : "✗ FAILED")}\n");

        // Test Case 2: Single element
        int[] test2 = { 42 };
        int[] result2 = Solution(test2);
        int[] expected2 = { 42 };
        Console.WriteLine($"Test 2 - Input: [42]");
        Console.WriteLine($"         Output: [{string.Join(", ", result2)}]");
        Console.WriteLine($"         Expected: [{string.Join(", ", expected2)}]");
        bool passed2 = ArraysEqual(result2, expected2);
        Console.WriteLine($"         {(passed2 ? "✓ PASSED" : "✗ FAILED")}\n");

        // Test Case 3: Array with negative numbers
        int[] test3 = { -5, 3, -2, 8, -1, 4 };
        int[] result3 = Solution(test3);
        int[] expected3 = { -5, -2, -1, 3, 4, 8 };
        Console.WriteLine($"Test 3 - Input: [-5, 3, -2, 8, -1, 4]");
        Console.WriteLine($"         Output: [{string.Join(", ", result3)}]");
        Console.WriteLine($"         Expected: [{string.Join(", ", expected3)}]");
        bool passed3 = ArraysEqual(result3, expected3);
        Console.WriteLine($"         {(passed3 ? "✓ PASSED" : "✗ FAILED")}\n");

        // Test Case 4: Array with duplicates
        int[] test4 = { 5, 2, 8, 2, 9, 1, 5 };
        int[] result4 = Solution(test4);
        int[] expected4 = { 1, 2, 2, 5, 5, 8, 9 };
        Console.WriteLine($"Test 4 - Input: [5, 2, 8, 2, 9, 1, 5]");
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
