using System;
using System.Collections.Generic;
using System.Linq;

namespace DSA._3_5_ThreeSum_Medium;

/// <summary>
/// Problem 3.5 (Medium): 3Sum
/// Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]] such that
/// i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.
/// 
/// Notice that the solution set must not contain duplicate triplets.
/// 
/// Example:
/// Input: nums = [-1,0,1,2,-1,-4]
/// Output: [[-1,-1,2],[-1,0,1]]
/// Explanation:
/// nums[0] + nums[1] + nums[2] = (-1) + 0 + 1 = 0.
/// nums[1] + nums[2] + nums[4] = 0 + 1 + (-1) = 0.
/// The distinct triplets are [-1,0,1] and [-1,-1,2].
/// Notice that the order of the output and the order of the triplets does not matter.
/// 
/// Constraints:
/// - 3 <= nums.length <= 3000
/// - -10^5 <= nums[i] <= 10^5
/// </summary>
public class ThreeSum
{
    public static IList<IList<int>> Solution(int[] nums)
    {
        // TODO: Implement solution
        // Hint: Sort array first, then for each element, use two pointers to find pairs that sum to -nums[i]
        // Skip duplicates to avoid duplicate triplets
        // Time Complexity: O(n^2)
        // Space Complexity: O(1) excluding output array
        
        return new List<IList<int>>();
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 3.5: Three Sum ===");
        
        int[] test1 = { -1, 0, 1, 2, -1, -4 };
        var result1 = Solution(test1);
        Console.WriteLine($"Test 1 - Input: [-1, 0, 1, 2, -1, -4]");
        Console.WriteLine($"         Output: {result1.Count} triplets, Expected: 2 triplets");
        bool passed1 = result1.Count == 2;
        Console.WriteLine($"         {(passed1 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[] test2 = { 0, 1, 1 };
        var result2 = Solution(test2);
        Console.WriteLine($"Test 2 - Input: [0, 1, 1]");
        Console.WriteLine($"         Output: {result2.Count} triplets, Expected: 0 triplets");
        bool passed2 = result2.Count == 0;
        Console.WriteLine($"         {(passed2 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

