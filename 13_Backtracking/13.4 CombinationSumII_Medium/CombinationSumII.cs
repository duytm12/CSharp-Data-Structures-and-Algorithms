using System;
using System.Collections.Generic;
using System.Linq;

namespace DSA._13_4_CombinationSumII_Medium;

/// <summary>
/// Problem 13.4 (Medium): Combination Sum II
/// Given a collection of candidate numbers (candidates) and a target number (target), find all
/// unique combinations in candidates where the candidate numbers sum to target.
/// 
/// Each number in candidates may only be used once in the combination.
/// 
/// Note: The solution set must not contain duplicate combinations.
/// 
/// Example:
/// Input: candidates = [10,1,2,7,6,1,5], target = 8
/// Output: [[1,1,6],[1,2,5],[1,7],[2,6]]
/// 
/// Constraints:
/// - 1 <= candidates.length <= 100
/// - 1 <= candidates[i] <= 50
/// - 1 <= target <= 30
/// </summary>
public class CombinationSumII
{
    public static IList<IList<int>> Solution(int[] candidates, int target)
    {
        // TODO: Implement solution
        // Hint: Similar to Combination Sum but each number can only be used once
        // Sort first, skip duplicates at same level
        // Time Complexity: O(2^n)
        // Space Complexity: O(target)
        
        return new List<IList<int>>();
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 13.4: Combination Sum II ===");
        
        int[] test1 = { 10, 1, 2, 7, 6, 1, 5 };
        var result1 = Solution(test1, 8);
        Console.WriteLine($"Test 1 - Input: candidates = [10,1,2,7,6,1,5], target = 8");
        Console.WriteLine($"         Output: {result1.Count} combinations, Expected: 4");
        Console.WriteLine($"         {(result1.Count == 4 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[] test2 = { 2, 5, 2, 1, 2 };
        var result2 = Solution(test2, 5);
        Console.WriteLine($"Test 2 - Input: candidates = [2,5,2,1,2], target = 5");
        Console.WriteLine($"         Output: {result2.Count} combinations, Expected: 2");
        Console.WriteLine($"         {(result2.Count == 2 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

