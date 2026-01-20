using System;

namespace DSA._1_11_MergeSortedArray_Easy;

/// <summary>
/// Problem 1.11 (Easy): Merge Sorted Array (LeetCode 88)
/// 
/// You are given two integer arrays nums1 and nums2, sorted in non-decreasing order,
/// and two integers m and n, representing the number of elements in nums1 and nums2 respectively.
///
/// Merge nums1 and nums2 into a single array sorted in non-decreasing order.
/// The final sorted array should not be returned by the function, but instead
/// be stored inside the array nums1.
///
/// To accommodate this, nums1 has a length of m + n, where the first m elements
/// denote the elements that should be merged, and the last n elements are set to 0
/// and should be ignored. nums2 has a length of n.
/// 
/// Constraints:
/// - nums1.Length == m + n
/// - nums2.Length == n
/// - 0 <= m, n <= 200
/// - 1 <= m + n <= 200
/// - -10^9 <= nums1[i], nums2[j] <= 10^9
/// </summary>
public class MergeSortedArray
{
    /// <summary>
    /// Merges nums2 into nums1 in-place, assuming nums1 has enough trailing space.
    /// Uses two-pointer technique starting from the end (backwards merge).
    /// Time Complexity: O(m + n)
    /// Space Complexity: O(1)
    /// </summary>
    public static void Solution(int[] nums1, int m, int[] nums2, int n)
    {
        // Start from the end of both arrays
        int i = m - 1;  // Last element in nums1's valid range
        int j = n - 1;  // Last element in nums2
        int k = m + n - 1;  // Last position in nums1 (where we'll place merged elements)

        // Merge from right to left
        while (i >= 0 && j >= 0)
        {
            if (nums1[i] > nums2[j])
            {
                nums1[k] = nums1[i];
                i--;
            }
            else
            {
                nums1[k] = nums2[j];
                j--;
            }
            k--;
        }

        // Copy remaining elements from nums2 (if any)
        // Note: We don't need to copy remaining elements from nums1
        // because they're already in the correct position
        while (j >= 0)
        {
            nums1[k] = nums2[j];
            j--;
            k--;
        }
    }

    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 1.11: Merge Sorted Array ===");

        // Test Case 1: Basic example
        int[] nums1_ex1 = { 1, 2, 3, 0, 0, 0 };
        int[] nums2_ex1 = { 2, 5, 6 };
        int[] expected1 = { 1, 2, 2, 3, 5, 6 };
        Solution(nums1_ex1, 3, nums2_ex1, 3);
        Console.WriteLine($"Test 1 - Input: nums1 = [1,2,3,0,0,0], m = 3; nums2 = [2,5,6], n = 3");
        Console.WriteLine($"         Output: [{string.Join(",", nums1_ex1)}], Expected: [{string.Join(",", expected1)}]");
        bool passed1 = nums1_ex1.Length == expected1.Length && 
                       nums1_ex1[0] == 1 && nums1_ex1[1] == 2 && nums1_ex1[2] == 2 && 
                       nums1_ex1[3] == 3 && nums1_ex1[4] == 5 && nums1_ex1[5] == 6;
        Console.WriteLine($"         {(passed1 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        // Test Case 2: nums2 is empty
        int[] nums1_ex2 = { 1 };
        int[] nums2_ex2 = { };
        int[] expected2 = { 1 };
        Solution(nums1_ex2, 1, nums2_ex2, 0);
        Console.WriteLine($"Test 2 - Input: nums1 = [1], m = 1; nums2 = [], n = 0");
        Console.WriteLine($"         Output: [{string.Join(",", nums1_ex2)}], Expected: [{string.Join(",", expected2)}]");
        bool passed2 = nums1_ex2.Length == 1 && nums1_ex2[0] == 1;
        Console.WriteLine($"         {(passed2 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        // Test Case 3: nums1 is empty (all zeros)
        int[] nums1_ex3 = { 0 };
        int[] nums2_ex3 = { 1 };
        int[] expected3 = { 1 };
        Solution(nums1_ex3, 0, nums2_ex3, 1);
        Console.WriteLine($"Test 3 - Input: nums1 = [0], m = 0; nums2 = [1], n = 1");
        Console.WriteLine($"         Output: [{string.Join(",", nums1_ex3)}], Expected: [{string.Join(",", expected3)}]");
        bool passed3 = nums1_ex3.Length == 1 && nums1_ex3[0] == 1;
        Console.WriteLine($"         {(passed3 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        // Test Case 4: Mix of negatives and zeros
        int[] nums1_ex4 = { -1, 0, 0, 0, 0 };
        int[] nums2_ex4 = { -1, 0, 0, 3 };
        int[] expected4 = { -1, -1, 0, 0, 3 };
        Solution(nums1_ex4, 1, nums2_ex4, 4);
        Console.WriteLine($"Test 4 - Input: nums1 = [-1,0,0,0,0], m = 1; nums2 = [-1,0,0,3], n = 4");
        Console.WriteLine($"         Output: [{string.Join(",", nums1_ex4)}], Expected: [{string.Join(",", expected4)}]");
        bool passed4 = nums1_ex4.Length == 5 && 
                       nums1_ex4[0] == -1 && nums1_ex4[1] == -1 && nums1_ex4[2] == 0 && 
                       nums1_ex4[3] == 0 && nums1_ex4[4] == 3;
        Console.WriteLine($"         {(passed4 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}


