using System;

namespace DSA._22_4_MergeSort_Medium;

/// <summary>
/// Problem 22.4 (Medium): Merge Sort
/// 
/// Merge Sort is a divide-and-conquer algorithm that divides the array into two halves,
/// sorts them recursively, and then merges the sorted halves.
/// 
/// Time Complexity: O(n log n) in all cases
/// Space Complexity: O(n)
/// </summary>
public class MergeSort
{
    public static int[] Solution(int[] nums)
    {
        // TODO: Implement Merge Sort
        // Hint: Divide array into halves, recursively sort, then merge sorted halves
        return [];
    }

    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 22.4: Merge Sort ===");

        // Test Case 1: Basic unsorted array
        int[] test1 = { 38, 27, 43, 3, 9, 82, 10 };
        int[] result1 = Solution(test1);
        int[] expected1 = { 3, 9, 10, 27, 38, 43, 82 };
        Console.WriteLine($"Test 1 - Input: [38, 27, 43, 3, 9, 82, 10]");
        Console.WriteLine($"         Output: [{string.Join(", ", result1)}]");
        Console.WriteLine($"         Expected: [{string.Join(", ", expected1)}]");
        bool passed1 = ArraysEqual(result1, expected1);
        Console.WriteLine($"         {(passed1 ? "✓ PASSED" : "✗ FAILED")}\n");

        // Test Case 2: Odd number of elements
        int[] test2 = { 5, 2, 8, 1, 9 };
        int[] result2 = Solution(test2);
        int[] expected2 = { 1, 2, 5, 8, 9 };
        Console.WriteLine($"Test 2 - Input: [5, 2, 8, 1, 9]");
        Console.WriteLine($"         Output: [{string.Join(", ", result2)}]");
        Console.WriteLine($"         Expected: [{string.Join(", ", expected2)}]");
        bool passed2 = ArraysEqual(result2, expected2);
        Console.WriteLine($"         {(passed2 ? "✓ PASSED" : "✗ FAILED")}\n");

        // Test Case 3: Array with negative numbers
        int[] test3 = { -10, 5, -3, 0, -7, 2 };
        int[] result3 = Solution(test3);
        int[] expected3 = { -10, -7, -3, 0, 2, 5 };
        Console.WriteLine($"Test 3 - Input: [-10, 5, -3, 0, -7, 2]");
        Console.WriteLine($"         Output: [{string.Join(", ", result3)}]");
        Console.WriteLine($"         Expected: [{string.Join(", ", expected3)}]");
        bool passed3 = ArraysEqual(result3, expected3);
        Console.WriteLine($"         {(passed3 ? "✓ PASSED" : "✗ FAILED")}\n");

        // Test Case 4: Array with duplicates
        int[] test4 = { 4, 2, 4, 1, 2, 3, 4 };
        int[] result4 = Solution(test4);
        int[] expected4 = { 1, 2, 2, 3, 4, 4, 4 };
        Console.WriteLine($"Test 4 - Input: [4, 2, 4, 1, 2, 3, 4]");
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
