using System;

namespace DSA._22_3_InsertionSort_Easy;

/// <summary>
/// Problem 22.3 (Easy): Insertion Sort
/// 
/// Insertion Sort builds the sorted array one item at a time. It takes each element
/// and inserts it into its correct position in the already sorted portion.
/// 
/// Time Complexity: O(n²) worst case, O(n) best case (already sorted)
/// Space Complexity: O(1)
/// </summary>
public class InsertionSort
{
    public static int[] Solution(int[] nums)
    {
        // TODO: Implement Insertion Sort
        // Hint: For each element, shift larger elements to the right and insert current element
        if (nums.Length == 1) return nums;

        for (int i = 1; i < nums.Length; i++)
        {
            int j = i;

            while (j > 0 && nums[j] < nums[j - 1])
            {
                (nums[j], nums[j - 1]) = (nums[j - 1], nums[j]);
                j--;
            }
        }
    
        return nums;
    }

    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 22.3: Insertion Sort ===");

        // Test Case 1: Basic unsorted array
        int[] test1 = { 12, 11, 13, 5, 6 };
        int[] result1 = Solution(test1);
        int[] expected1 = { 5, 6, 11, 12, 13 };
        Console.WriteLine($"Test 1 - Input: [12, 11, 13, 5, 6]");
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

        // Test Case 3: Array with zeros
        int[] test3 = { 0, 3, 0, 1, 2 };
        int[] result3 = Solution(test3);
        int[] expected3 = { 0, 0, 1, 2, 3 };
        Console.WriteLine($"Test 3 - Input: [0, 3, 0, 1, 2]");
        Console.WriteLine($"         Output: [{string.Join(", ", result3)}]");
        Console.WriteLine($"         Expected: [{string.Join(", ", expected3)}]");
        bool passed3 = ArraysEqual(result3, expected3);
        Console.WriteLine($"         {(passed3 ? "✓ PASSED" : "✗ FAILED")}\n");

        // Test Case 4: Large values
        int[] test4 = { 1000, 100, 10, 1, 10000 };
        int[] result4 = Solution(test4);
        int[] expected4 = { 1, 10, 100, 1000, 10000 };
        Console.WriteLine($"Test 4 - Input: [1000, 100, 10, 1, 10000]");
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
