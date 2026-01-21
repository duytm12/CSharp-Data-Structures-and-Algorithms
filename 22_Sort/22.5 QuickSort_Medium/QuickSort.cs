using System;

namespace DSA._22_5_QuickSort_Medium;

/// <summary>
/// Problem 22.5 (Medium): Quick Sort
/// 
/// Quick Sort is a divide-and-conquer algorithm that picks a pivot element and partitions
/// the array around the pivot, placing smaller elements before and larger elements after.
/// 
/// Time Complexity: O(n log n) average, O(n²) worst case
/// Space Complexity: O(log n) average (recursion stack)
/// </summary>
public class QuickSort
{
    public static int[] Solution(int[] nums)
    {
        // TODO: Implement Quick Sort
        // Hint: Choose pivot, partition array, recursively sort left and right partitions
        return [];
    }

    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 22.5: Quick Sort ===");

        // Test Case 1: Basic unsorted array
        int[] test1 = { 10, 7, 8, 9, 1, 5 };
        int[] result1 = Solution(test1);
        int[] expected1 = { 1, 5, 7, 8, 9, 10 };
        Console.WriteLine($"Test 1 - Input: [10, 7, 8, 9, 1, 5]");
        Console.WriteLine($"         Output: [{string.Join(", ", result1)}]");
        Console.WriteLine($"         Expected: [{string.Join(", ", expected1)}]");
        bool passed1 = ArraysEqual(result1, expected1);
        Console.WriteLine($"         {(passed1 ? "✓ PASSED" : "✗ FAILED")}\n");

        // Test Case 2: Already sorted array
        int[] test2 = { 1, 2, 3, 4, 5 };
        int[] result2 = Solution(test2);
        int[] expected2 = { 1, 2, 3, 4, 5 };
        Console.WriteLine($"Test 2 - Input: [1, 2, 3, 4, 5]");
        Console.WriteLine($"         Output: [{string.Join(", ", result2)}]");
        Console.WriteLine($"         Expected: [{string.Join(", ", expected2)}]");
        bool passed2 = ArraysEqual(result2, expected2);
        Console.WriteLine($"         {(passed2 ? "✓ PASSED" : "✗ FAILED")}\n");

        // Test Case 3: Reverse sorted array
        int[] test3 = { 5, 4, 3, 2, 1 };
        int[] result3 = Solution(test3);
        int[] expected3 = { 1, 2, 3, 4, 5 };
        Console.WriteLine($"Test 3 - Input: [5, 4, 3, 2, 1]");
        Console.WriteLine($"         Output: [{string.Join(", ", result3)}]");
        Console.WriteLine($"         Expected: [{string.Join(", ", expected3)}]");
        bool passed3 = ArraysEqual(result3, expected3);
        Console.WriteLine($"         {(passed3 ? "✓ PASSED" : "✗ FAILED")}\n");

        // Test Case 4: Array with duplicates
        int[] test4 = { 3, 1, 4, 1, 5, 9, 2, 6, 5 };
        int[] result4 = Solution(test4);
        int[] expected4 = { 1, 1, 2, 3, 4, 5, 5, 6, 9 };
        Console.WriteLine($"Test 4 - Input: [3, 1, 4, 1, 5, 9, 2, 6, 5]");
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
