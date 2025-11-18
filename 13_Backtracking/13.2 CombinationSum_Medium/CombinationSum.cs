using System;
using System.Collections.Generic;

namespace DSA._13_2_CombinationSum_Medium;

/// <summary>
/// Problem 13.2 (Medium): Combination Sum
/// Given an array of distinct integers candidates and a target integer target, return a list
/// of all unique combinations of candidates where the chosen numbers sum to target.
/// 
/// Example:
/// Input: candidates = [2,3,6,7], target = 7
/// Output: [[2,2,3],[7]]
/// </summary>
public class CombinationSum
{
    public static IList<IList<int>> Solution(int[] candidates, int target)
    {
        // TODO: Implement solution
        // Hint: Backtrack with remaining target, can reuse same element
        // Time Complexity: O(2^target)
        // Space Complexity: O(target)
        
        return new List<IList<int>>();
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 13.2: Combination Sum ===");
        
        int[] test1 = { 2, 3, 6, 7 };
        var result1 = Solution(test1, 7);
        Console.WriteLine($"Test 1 - Input: candidates = [2,3,6,7], target = 7");
        Console.WriteLine($"         Output: {result1.Count} combinations, Expected: 2");
        Console.WriteLine($"         {(result1.Count == 2 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[] test2 = { 2, 3, 5 };
        var result2 = Solution(test2, 8);
        Console.WriteLine($"Test 2 - Input: candidates = [2,3,5], target = 8");
        Console.WriteLine($"         Output: {result2.Count} combinations");
        bool passed2 = result2.Count >= 1;
        Console.WriteLine($"         {(passed2 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

