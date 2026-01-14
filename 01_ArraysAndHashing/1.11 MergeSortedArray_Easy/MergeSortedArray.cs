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
    /// Time Complexity: O(m + n)
    /// Space Complexity: O(1)
    /// </summary>
    public static void Solution(int[] nums1, int m, int[] nums2, int n)
    {
        for (int i = m - 1; i < nums1.Length - 1; i++)
        {
            for (int j = n - 1; j < nums2.Length; j++)
            {
                nums1[i] = nums2[j];
                continue;
            }
        }
        Array.Sort(nums1);
    }

    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 1.11: Merge Sorted Array ===");

        // Example 1:
        int[] nums1_ex1 = { 1, 2, 3, 0, 0, 0 };
        int[] nums2_ex1 = { 2, 5, 6 };
        Solution(nums1_ex1, 3, nums2_ex1, 3);
        Console.WriteLine("Example 1:");
        Console.WriteLine("Input:  nums1 = [1,2,3,0,0,0], m = 3; nums2 = [2,5,6], n = 3");
        Console.WriteLine($"Output: [{string.Join(",", nums1_ex1)}], Expected: [1,2,2,3,5,6]\n");

        // Example 2:
        int[] nums1_ex2 = { 1 };
        int[] nums2_ex2 = { };
        Solution(nums1_ex2, 1, nums2_ex2, 0);
        Console.WriteLine("Example 2:");
        Console.WriteLine("Input:  nums1 = [1], m = 1; nums2 = [], n = 0");
        Console.WriteLine($"Output: [{string.Join(",", nums1_ex2)}], Expected: [1]\n");

        // Example 3:
        int[] nums1_ex3 = { 0 };
        int[] nums2_ex3 = { 1 };
        Solution(nums1_ex3, 0, nums2_ex3, 1);
        Console.WriteLine("Example 3:");
        Console.WriteLine("Input:  nums1 = [0], m = 0; nums2 = [1], n = 1");
        Console.WriteLine($"Output: [{string.Join(",", nums1_ex3)}], Expected: [1]\n");
    }
}


