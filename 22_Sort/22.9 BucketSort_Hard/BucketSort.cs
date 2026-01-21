using System;

namespace DSA._22_9_BucketSort_Hard;

/// <summary>
/// Problem 22.9 (Hard): Bucket Sort
/// 
/// Bucket Sort distributes elements into a number of buckets, sorts each bucket
/// individually (using another algorithm), and then concatenates the buckets.
/// Works best when input is uniformly distributed over a range.
/// 
/// Time Complexity: O(n + k) average case, O(n²) worst case
/// Space Complexity: O(n + k)
/// </summary>
public class BucketSort
{
    public static int[] Solution(int[] nums)
    {
        // TODO: Implement Bucket Sort
        // Hint: Distribute elements into buckets, sort each bucket, then concatenate
        // Assumes values are in a known range (e.g., 0 to max)
        return [];
    }

    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 22.9: Bucket Sort ===");

        // Test Case 1: Basic array with uniform distribution
        // Note: Using integer values for bucket sort
        int[] test1 = { 78, 17, 39, 26, 72, 94, 21, 12, 23, 68 };
        int[] result1 = Solution(test1);
        int[] expected1 = { 12, 17, 21, 23, 26, 39, 68, 72, 78, 94 };
        Console.WriteLine($"Test 1 - Input: [78, 17, 39, 26, 72, 94, 21, 12, 23, 68]");
        Console.WriteLine($"         Output: [{string.Join(", ", result1)}]");
        Console.WriteLine($"         Expected: [{string.Join(", ", expected1)}]");
        bool passed1 = ArraysEqual(result1, expected1);
        Console.WriteLine($"         {(passed1 ? "✓ PASSED" : "✗ FAILED")}\n");

        // Test Case 2: Array with small range
        int[] test2 = { 5, 3, 8, 2, 1, 9, 4, 7, 6 };
        int[] result2 = Solution(test2);
        int[] expected2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        Console.WriteLine($"Test 2 - Input: [5, 3, 8, 2, 1, 9, 4, 7, 6]");
        Console.WriteLine($"         Output: [{string.Join(", ", result2)}]");
        Console.WriteLine($"         Expected: [{string.Join(", ", expected2)}]");
        bool passed2 = ArraysEqual(result2, expected2);
        Console.WriteLine($"         {(passed2 ? "✓ PASSED" : "✗ FAILED")}\n");

        // Test Case 3: Array with duplicates
        int[] test3 = { 10, 20, 10, 30, 20, 40, 30 };
        int[] result3 = Solution(test3);
        int[] expected3 = { 10, 10, 20, 20, 30, 30, 40 };
        Console.WriteLine($"Test 3 - Input: [10, 20, 10, 30, 20, 40, 30]");
        Console.WriteLine($"         Output: [{string.Join(", ", result3)}]");
        Console.WriteLine($"         Expected: [{string.Join(", ", expected3)}]");
        bool passed3 = ArraysEqual(result3, expected3);
        Console.WriteLine($"         {(passed3 ? "✓ PASSED" : "✗ FAILED")}\n");

        // Test Case 4: Already sorted
        int[] test4 = { 1, 2, 3, 4, 5, 6, 7 };
        int[] result4 = Solution(test4);
        int[] expected4 = { 1, 2, 3, 4, 5, 6, 7 };
        Console.WriteLine($"Test 4 - Input: [1, 2, 3, 4, 5, 6, 7]");
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
