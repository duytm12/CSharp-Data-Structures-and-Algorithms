using System;

namespace DSA._22_6_HeapSort_Medium;

/// <summary>
/// Problem 22.6 (Medium): Heap Sort
/// 
/// Heap Sort uses a binary heap data structure. It builds a max heap from the array,
/// then repeatedly extracts the maximum element and places it at the end.
/// 
/// Time Complexity: O(n log n) in all cases
/// Space Complexity: O(1)
/// </summary>
public class HeapSort
{
    public static int[] Solution(int[] nums)
    {
        // TODO: Implement Heap Sort
        // Hint: Build max heap, then repeatedly extract max and heapify
        return [];
    }

    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 22.6: Heap Sort ===");

        // Test Case 1: Basic unsorted array
        int[] test1 = { 12, 11, 13, 5, 6, 7 };
        int[] result1 = Solution(test1);
        int[] expected1 = { 5, 6, 7, 11, 12, 13 };
        Console.WriteLine($"Test 1 - Input: [12, 11, 13, 5, 6, 7]");
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
        int[] test3 = { -3, 1, -5, 4, -2, 0 };
        int[] result3 = Solution(test3);
        int[] expected3 = { -5, -3, -2, 0, 1, 4 };
        Console.WriteLine($"Test 3 - Input: [-3, 1, -5, 4, -2, 0]");
        Console.WriteLine($"         Output: [{string.Join(", ", result3)}]");
        Console.WriteLine($"         Expected: [{string.Join(", ", expected3)}]");
        bool passed3 = ArraysEqual(result3, expected3);
        Console.WriteLine($"         {(passed3 ? "✓ PASSED" : "✗ FAILED")}\n");

        // Test Case 4: Array with duplicates
        int[] test4 = { 7, 3, 7, 1, 3, 5, 7 };
        int[] result4 = Solution(test4);
        int[] expected4 = { 1, 3, 3, 5, 7, 7, 7 };
        Console.WriteLine($"Test 4 - Input: [7, 3, 7, 1, 3, 5, 7]");
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
