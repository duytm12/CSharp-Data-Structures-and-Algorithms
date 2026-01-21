using System;

namespace DSA._22_8_RadixSort_Hard;

/// <summary>
/// Problem 22.8 (Hard): Radix Sort
/// 
/// Radix Sort is a non-comparison-based sorting algorithm that sorts numbers by processing
/// individual digits. It processes digits from least significant to most significant.
/// 
/// Time Complexity: O(d * (n + k)) where d is number of digits, k is base (usually 10)
/// Space Complexity: O(n + k)
/// </summary>
public class RadixSort
{
    public static int[] Solution(int[] nums)
    {
        // TODO: Implement Radix Sort
        // Hint: Sort by each digit position from least to most significant
        // Use counting sort as a subroutine for each digit
        return [];
    }

    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 22.8: Radix Sort ===");

        // Test Case 1: Basic array with varying digit lengths
        int[] test1 = { 170, 45, 75, 90, 802, 24, 2, 66 };
        int[] result1 = Solution(test1);
        int[] expected1 = { 2, 24, 45, 66, 75, 90, 170, 802 };
        Console.WriteLine($"Test 1 - Input: [170, 45, 75, 90, 802, 24, 2, 66]");
        Console.WriteLine($"         Output: [{string.Join(", ", result1)}]");
        Console.WriteLine($"         Expected: [{string.Join(", ", expected1)}]");
        bool passed1 = ArraysEqual(result1, expected1);
        Console.WriteLine($"         {(passed1 ? "✓ PASSED" : "✗ FAILED")}\n");

        // Test Case 2: Single digit numbers
        int[] test2 = { 5, 2, 8, 1, 9, 3 };
        int[] result2 = Solution(test2);
        int[] expected2 = { 1, 2, 3, 5, 8, 9 };
        Console.WriteLine($"Test 2 - Input: [5, 2, 8, 1, 9, 3]");
        Console.WriteLine($"         Output: [{string.Join(", ", result2)}]");
        Console.WriteLine($"         Expected: [{string.Join(", ", expected2)}]");
        bool passed2 = ArraysEqual(result2, expected2);
        Console.WriteLine($"         {(passed2 ? "✓ PASSED" : "✗ FAILED")}\n");

        // Test Case 3: Numbers with same number of digits
        int[] test3 = { 432, 123, 567, 234, 345 };
        int[] result3 = Solution(test3);
        int[] expected3 = { 123, 234, 345, 432, 567 };
        Console.WriteLine($"Test 3 - Input: [432, 123, 567, 234, 345]");
        Console.WriteLine($"         Output: [{string.Join(", ", result3)}]");
        Console.WriteLine($"         Expected: [{string.Join(", ", expected3)}]");
        bool passed3 = ArraysEqual(result3, expected3);
        Console.WriteLine($"         {(passed3 ? "✓ PASSED" : "✗ FAILED")}\n");

        // Test Case 4: Array with duplicates
        int[] test4 = { 121, 432, 121, 564, 432, 23 };
        int[] result4 = Solution(test4);
        int[] expected4 = { 23, 121, 121, 432, 432, 564 };
        Console.WriteLine($"Test 4 - Input: [121, 432, 121, 564, 432, 23]");
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
