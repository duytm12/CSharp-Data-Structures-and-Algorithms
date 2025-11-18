using System;
using System.Collections.Generic;
using System.Linq;

namespace DSA._13_6_SubsetsII_Medium;

/// <summary>
/// Problem 13.6 (Medium): Subsets II
/// Given an integer array nums that may contain duplicates, return all possible subsets (the power set).
/// The solution set must not contain duplicate subsets. Return the solution in any order.
/// 
/// Example:
/// Input: nums = [1,2,2]
/// Output: [[],[1],[1,2],[1,2,2],[2],[2,2]]
/// 
/// Constraints:
/// - 1 <= nums.length <= 10
/// - -10 <= nums[i] <= 10
/// </summary>
public class SubsetsII
{
    public static IList<IList<int>> Solution(int[] nums)
    {
        // TODO: Implement solution
        // Hint: Similar to Subsets but skip duplicates at same level
        // Sort first, then backtrack
        // Time Complexity: O(2^n * n)
        // Space Complexity: O(2^n * n)
        
        return new List<IList<int>>();
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 13.6: Subsets II ===");
        
        int[] test1 = { 1, 2, 2 };
        var result1 = Solution(test1);
        Console.WriteLine($"Test 1 - Input: [1,2,2]");
        Console.WriteLine($"         Output: {result1.Count} subsets, Expected: 6");
        Console.WriteLine($"         {(result1.Count == 6 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[] test2 = { 0 };
        var result2 = Solution(test2);
        Console.WriteLine($"Test 2 - Input: [0]");
        Console.WriteLine($"         Output: {result2.Count} subsets, Expected: 2");
        Console.WriteLine($"         {(result2.Count == 2 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

