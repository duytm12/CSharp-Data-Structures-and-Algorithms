using System;
using System.Collections.Generic;
using System.Linq;

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
        
        return Array.Empty<int>();
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
    }
}

