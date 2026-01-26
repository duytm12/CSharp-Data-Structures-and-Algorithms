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

        int n = nums.Length;
        bool swapped;

        // ============================================
        // BUBBLE SORT EXPLAINED SIMPLY:
        // ============================================
        // Think of it like bubbles rising in water - the LARGEST numbers
        // "bubble up" to the end of the array, one at a time.
        //
        // HOW IT WORKS:
        // 1. Walk through the array from left to right
        // 2. Compare each pair of neighbors: [j] and [j+1]
        // 3. If left > right, swap them (wrong order!)
        // 4. After one full pass, the largest number is at the end
        // 5. Repeat until sorted
        //
        // ANALOGY: Like organizing books on a shelf
        // - You walk along the shelf
        // - If you see two books in wrong order, swap them
        // - After one pass, the biggest book is at the end
        // - Keep doing passes until everything is sorted
        // ============================================

        // Outer loop: How many passes we need (n-1 passes)
        // Each pass moves the next largest number to its final position
        for (int i = 0; i < n - 1; i++)
        {
            swapped = false; // Track if we made any swaps this pass

            // Inner loop: Compare adjacent pairs
            // We go from 0 to (n-i-1) because:
            // - After pass 1: last element is sorted, so check up to n-2
            // - After pass 2: last 2 are sorted, so check up to n-3
            // - etc.
            for (int j = 0; j < n - i - 1; j++)
            {
                // Compare neighbors: is the left one bigger?
                if (nums[j] > nums[j + 1])
                {
                    // Yes! Swap them (wrong order)
                    int temp = nums[j];        // Save left value
                    nums[j] = nums[j + 1];    // Put right value in left
                    nums[j + 1] = temp;       // Put saved value in right
                    swapped = true;            // Remember we swapped
                }
            }

            // If we didn't swap anything, array is already sorted!
            if (!swapped)
                break; // Early exit - we're done!
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
