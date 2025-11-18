using System;

namespace DSA._5_7_MedianOfTwoSortedArrays_Hard;

/// <summary>
/// Problem 5.7 (Hard): Median of Two Sorted Arrays
/// Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median
/// of the two sorted arrays.
/// 
/// The overall run time complexity should be O(log (m+n)).
/// 
/// Example:
/// Input: nums1 = [1,3], nums2 = [2]
/// Output: 2.00000
/// Explanation: merged array = [1,2,3] and median is 2.
/// 
/// Example 2:
/// Input: nums1 = [1,2], nums2 = [3,4]
/// Output: 2.50000
/// Explanation: merged array = [1,2,3,4] and median is (2 + 3) / 2 = 2.5.
/// 
/// Constraints:
/// - nums1.length == m
/// - nums2.length == n
/// - 0 <= m <= 1000
/// - 0 <= n <= 1000
/// - 1 <= m + n <= 2000
/// - -10^6 <= nums1[i], nums2[i] <= 10^6
/// </summary>
public class MedianOfTwoSortedArrays
{
    public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        // TODO: Implement solution
        // Hint: Binary search on the partition point, ensure left partition <= right partition
        // Partition both arrays such that left side has (m+n+1)/2 elements
        // Time Complexity: O(log(min(m, n)))
        // Space Complexity: O(1)
        
        return 0.0;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 5.7: Median of Two Sorted Arrays ===");
        
        int[] test1_nums1 = { 1, 3 };
        int[] test1_nums2 = { 2 };
        double result1 = FindMedianSortedArrays(test1_nums1, test1_nums2);
        Console.WriteLine($"Test 1 - Input: nums1 = [1,3], nums2 = [2]");
        Console.WriteLine($"         Output: {result1:F5}, Expected: 2.00000");
        Console.WriteLine($"         {(Math.Abs(result1 - 2.0) < 0.00001 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[] test2_nums1 = { 1, 2 };
        int[] test2_nums2 = { 3, 4 };
        double result2 = FindMedianSortedArrays(test2_nums1, test2_nums2);
        Console.WriteLine($"Test 2 - Input: nums1 = [1,2], nums2 = [3,4]");
        Console.WriteLine($"         Output: {result2:F5}, Expected: 2.50000");
        Console.WriteLine($"         {(Math.Abs(result2 - 2.5) < 0.00001 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

