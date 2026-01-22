using System;

namespace DSA._22_10_ShellSort_Medium;

/// <summary>
/// Problem 22.10 (Medium): Shell Sort
/// 
/// Shell Sort is an optimization of Insertion Sort that allows exchange of items
/// that are far apart. It works by sorting elements at specific intervals (gaps),
/// gradually reducing the gap until it becomes 1, at which point the array is sorted.
/// 
/// The algorithm starts with a large gap and reduces it until the gap is 1,
/// performing insertion sort on each gap sequence.
/// 
/// Time Complexity: O(n²) worst case, O(n log n) best case (depends on gap sequence)
/// Space Complexity: O(1)
/// </summary>
public class ShellSort
{
    public static int[] Solution(int[] nums)
    {

        
        return nums;
    }

    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 22.10: Shell Sort ===");

        // Test Case 1: Basic unsorted array
        int[] test1 = { 64, 34, 25, 12, 22, 11, 90 };
        int[] result1 = Solution((int[])test1.Clone());
        int[] expected1 = { 11, 12, 22, 25, 34, 64, 90 };
        Console.WriteLine($"Test 1 - Input: [64, 34, 25, 12, 22, 11, 90]");
        Console.WriteLine($"         Output: [{string.Join(", ", result1)}]");
        Console.WriteLine($"         Expected: [{string.Join(", ", expected1)}]");
        bool passed1 = ArraysEqual(result1, expected1);
        Console.WriteLine($"         {(passed1 ? "✓ PASSED" : "✗ FAILED")}\n");

        // Test Case 2: Already sorted array
        int[] test2 = { 1, 2, 3, 4, 5 };
        int[] result2 = Solution((int[])test2.Clone());
        int[] expected2 = { 1, 2, 3, 4, 5 };
        Console.WriteLine($"Test 2 - Input: [1, 2, 3, 4, 5]");
        Console.WriteLine($"         Output: [{string.Join(", ", result2)}]");
        Console.WriteLine($"         Expected: [{string.Join(", ", expected2)}]");
        bool passed2 = ArraysEqual(result2, expected2);
        Console.WriteLine($"         {(passed2 ? "✓ PASSED" : "✗ FAILED")}\n");

        // Test Case 3: Reverse sorted array
        int[] test3 = { 5, 4, 3, 2, 1 };
        int[] result3 = Solution((int[])test3.Clone());
        int[] expected3 = { 1, 2, 3, 4, 5 };
        Console.WriteLine($"Test 3 - Input: [5, 4, 3, 2, 1]");
        Console.WriteLine($"         Output: [{string.Join(", ", result3)}]");
        Console.WriteLine($"         Expected: [{string.Join(", ", expected3)}]");
        bool passed3 = ArraysEqual(result3, expected3);
        Console.WriteLine($"         {(passed3 ? "✓ PASSED" : "✗ FAILED")}\n");

        // Test Case 4: Array with duplicates
        int[] test4 = { 3, 7, 3, 1, 7, 2, 1 };
        int[] result4 = Solution((int[])test4.Clone());
        int[] expected4 = { 1, 1, 2, 3, 3, 7, 7 };
        Console.WriteLine($"Test 4 - Input: [3, 7, 3, 1, 7, 2, 1]");
        Console.WriteLine($"         Output: [{string.Join(", ", result4)}]");
        Console.WriteLine($"         Expected: [{string.Join(", ", expected4)}]");
        bool passed4 = ArraysEqual(result4, expected4);
        Console.WriteLine($"         {(passed4 ? "✓ PASSED" : "✗ FAILED")}\n");

        // Test Case 5: Single element
        int[] test5 = { 42 };
        int[] result5 = Solution((int[])test5.Clone());
        int[] expected5 = { 42 };
        Console.WriteLine($"Test 5 - Input: [42]");
        Console.WriteLine($"         Output: [{string.Join(", ", result5)}]");
        Console.WriteLine($"         Expected: [{string.Join(", ", expected5)}]");
        bool passed5 = ArraysEqual(result5, expected5);
        Console.WriteLine($"         {(passed5 ? "✓ PASSED" : "✗ FAILED")}\n");

        // Test Case 6: Large array
        int[] test6 = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
        int[] result6 = Solution((int[])test6.Clone());
        int[] expected6 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        Console.WriteLine($"Test 6 - Input: [9, 8, 7, 6, 5, 4, 3, 2, 1, 0]");
        Console.WriteLine($"         Output: [{string.Join(", ", result6)}]");
        Console.WriteLine($"         Expected: [{string.Join(", ", expected6)}]");
        bool passed6 = ArraysEqual(result6, expected6);
        Console.WriteLine($"         {(passed6 ? "✓ PASSED" : "✗ FAILED")}\n");
    }

    private static bool ArraysEqual(int[] arr1, int[] arr2)
    {
        if (arr1 == null && arr2 == null) return true;
        if (arr1 == null || arr2 == null) return false;
        if (arr1.Length != arr2.Length) return false;
        for (int i = 0; i < arr1.Length; i++)
        {
            if (arr1[i] != arr2[i]) return false;
        }
        return true;
    }
}
