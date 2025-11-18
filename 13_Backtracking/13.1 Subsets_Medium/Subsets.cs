using System;
using System.Collections.Generic;

namespace DSA._13_1_Subsets_Medium;

/// <summary>
/// Problem 13.1 (Medium): Subsets
/// Given an integer array nums of unique elements, return all possible subsets (the power set).
/// 
/// Example:
/// Input: nums = [1,2,3]
/// Output: [[],[1],[2],[1,2],[3],[1,3],[2,3],[1,2,3]]
/// </summary>
public class Subsets
{
    public static IList<IList<int>> Solution(int[] nums)
    {
        // TODO: Implement solution
        // Hint: Backtrack: include current element or skip it
        // Time Complexity: O(2^n * n)
        // Space Complexity: O(2^n * n)
        
        return new List<IList<int>>();
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 13.1: Subsets ===");
        
        int[] test1 = { 1, 2, 3 };
        var result1 = Solution(test1);
        Console.WriteLine($"Test 1 - Input: [1,2,3]");
        Console.WriteLine($"         Output: {result1.Count} subsets, Expected: 8");
        Console.WriteLine($"         {(result1.Count == 8 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[] test2 = { 0 };
        var result2 = Solution(test2);
        Console.WriteLine($"Test 2 - Input: [0]");
        Console.WriteLine($"         Output: {result2.Count} subsets, Expected: 2");
        Console.WriteLine($"         {(result2.Count == 2 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

