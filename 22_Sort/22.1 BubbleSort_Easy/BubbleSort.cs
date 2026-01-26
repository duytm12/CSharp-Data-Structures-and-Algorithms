using System;

namespace DSA._22_1_BubbleSort_Easy;

/// <summary>
/// Problem 22.1 (Easy): Bubble Sort
/// 
/// Bubble Sort is a simple sorting algorithm that repeatedly steps through the list,
/// compares adjacent elements and swaps them if they are in the wrong order.
/// The pass through the list is repeated until the list is sorted.
/// 
/// Time Complexity: O(n²) worst case, O(n) best case (already sorted)
/// Space Complexity: O(1)
/// </summary>
public class BubbleSort
{
    public static int[] Solution(int[] nums)
    {
        if (nums.Length <= 1) return nums;

        for (int i = 0; i < nums.Length; i++)
        {
            int maxIndex = i;
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[j] > nums[maxIndex])
                {
                    maxIndex = j;
                }
                
            }
        }

        

        return nums;
    }

    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 22.1: Bubble Sort ===");

        // Test Case 1: Basic unsorted array
        int[] test1 = { 64, 34, 25, 12, 22, 11, 90 };
        int[] result1 = Solution(test1);
        int[] expected1 = { 11, 12, 22, 25, 34, 64, 90 };
        Console.WriteLine($"Test 1 - Input: [64, 34, 25, 12, 22, 11, 90]");
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
        int[] test4 = { 3, 7, 3, 1, 7, 2, 1 };
        int[] result4 = Solution(test4);
        int[] expected4 = { 1, 1, 2, 3, 3, 7, 7 };
        Console.WriteLine($"Test 4 - Input: [3, 7, 3, 1, 7, 2, 1]");
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
