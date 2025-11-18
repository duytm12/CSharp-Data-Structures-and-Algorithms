using System;
using System.Collections.Generic;

namespace DSA._13_5_Permutations_Medium;

/// <summary>
/// Problem 13.5 (Medium): Permutations
/// Given an array nums of distinct integers, return all the possible permutations.
/// You can return the answer in any order.
/// 
/// Example:
/// Input: nums = [1,2,3]
/// Output: [[1,2,3],[1,3,2],[2,1,3],[2,3,1],[3,1,2],[3,2,1]]
/// 
/// Constraints:
/// - 1 <= nums.length <= 6
/// - -10 <= nums[i] <= 10
/// - All the integers of nums are unique.
/// </summary>
public class Permutations
{
    public static IList<IList<int>> Solution(int[] nums)
    {
        // TODO: Implement solution
        // Hint: Backtrack, swap elements, generate all permutations
        // Time Complexity: O(n! * n)
        // Space Complexity: O(n!)
        
        return new List<IList<int>>();
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 13.5: Permutations ===");
        
        int[] test1 = { 1, 2, 3 };
        var result1 = Solution(test1);
        Console.WriteLine($"Test 1 - Input: [1,2,3]");
        Console.WriteLine($"         Output: {result1.Count} permutations, Expected: 6");
        Console.WriteLine($"         {(result1.Count == 6 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[] test2 = { 0, 1 };
        var result2 = Solution(test2);
        Console.WriteLine($"Test 2 - Input: [0,1]");
        Console.WriteLine($"         Output: {result2.Count} permutations, Expected: 2");
        Console.WriteLine($"         {(result2.Count == 2 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

