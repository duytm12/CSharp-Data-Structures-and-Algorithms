using System;
using System.Collections.Generic;
using System.Linq;
using DSA._10_14_BuildTreeFromPreorderInorder_Medium;

namespace DSA._2_6_IntersectionOfTwoArrays_Easy;

/// <summary>
/// Problem 2.6 (Easy): Intersection of Two Arrays
/// Given two integer arrays nums1 and nums2, return an array of their intersection.
/// Each element in the result must be unique and you may return the result in any order.
/// 
/// Example:
/// Input: nums1 = [1,2,2,1], nums2 = [2,2]
/// Output: [2]
/// 
/// Constraints:
/// - 1 <= nums1.length, nums2.length <= 1000
/// - 0 <= nums1[i], nums2[i] <= 1000
/// </summary>
public class IntersectionOfTwoArrays
{
    public static int[] Solution(int[] nums1, int[] nums2)
    {
        // TODO: Implement solution
        // Hint: Use HashSet<T> to find common elements
        // Time Complexity: O(n + m)
        // Space Complexity: O(min(n, m))

        // 1. Brute force
        // var result = new HashSet<int>();

        // for (int i = 0; i < nums1.Length; i++)
        // {
        //     for (int j = 0; j < nums2.Length; j++)
        //     {
        //         if (nums1[i] == nums2[j])
        //         {
        //             result.Add(nums1[i]);

        //         }
        //     }
        // }
        // if (result.Count != 0) return result.ToArray();

        // 2. HashSet contains
        var hs1 = nums1.ToHashSet();
        var result = new HashSet<int>();

        for (int i = 0; i < nums2.Length; i++)
        {
            if (hs1.Contains(nums2[i]))
            {
                result.Add(nums2[i]);
            }
        }
        
        return [..result];
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 2.6: Intersection of Two Arrays ===");
        
        int[] test1_nums1 = { 1, 2, 2, 1 };
        int[] test1_nums2 = { 2, 2 };
        int[] result1 = Solution(test1_nums1, test1_nums2);
        Console.WriteLine($"Test 1 - Input: nums1 = [1, 2, 2, 1], nums2 = [2, 2]");
        Console.WriteLine($"         Output: [{string.Join(", ", result1)}], Expected: [2]");
        bool passed1 = result1.Length == 1 && result1[0] == 2;
        Console.WriteLine($"         {(passed1 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[] test2_nums1 = { 1, 2, 3 };
        int[] test2_nums2 = { 4, 5, 6 };
        int[] result2 = Solution(test2_nums1, test2_nums2);
        Console.WriteLine($"Test 2 - Input: nums1 = [1, 2, 3], nums2 = [4, 5, 6]");
        Console.WriteLine($"         Output: [{string.Join(", ", result2)}], Expected: []");
        bool passed2 = result2.Length == 0;
        Console.WriteLine($"         {(passed2 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[] test3_nums1 = { 4, 9, 5 };
        int[] test3_nums2 = { 9, 4, 9, 8, 4 };
        int[] result3 = Solution(test3_nums1, test3_nums2);
        Console.WriteLine($"Test 3 - Input: nums1 = [4, 9, 5], nums2 = [9, 4, 9, 8, 4]");
        Console.WriteLine($"         Output: [{string.Join(", ", result3)}], Expected: [4, 9] or [9, 4]");
        bool passed3 = result3.Length == 2 && 
                       ((result3[0] == 4 && result3[1] == 9) || (result3[0] == 9 && result3[1] == 4));
        Console.WriteLine($"         {(passed3 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[] test4_nums1 = { 1, 2, 3, 4, 5 };
        int[] test4_nums2 = { 2, 4 };
        int[] result4 = Solution(test4_nums1, test4_nums2);
        Console.WriteLine($"Test 4 - Input: nums1 = [1, 2, 3, 4, 5], nums2 = [2, 4]");
        Console.WriteLine($"         Output: [{string.Join(", ", result4)}], Expected: [2, 4] or [4, 2]");
        bool passed4 = result4.Length == 2 && 
                       ((result4[0] == 2 && result4[1] == 4) || (result4[0] == 4 && result4[1] == 2));
        Console.WriteLine($"         {(passed4 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

