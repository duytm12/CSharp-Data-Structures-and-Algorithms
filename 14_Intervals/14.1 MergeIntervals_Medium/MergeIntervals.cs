using System;
using System.Collections.Generic;
using System.Linq;

namespace DSA._14_1_MergeIntervals_Medium;

/// <summary>
/// Problem 14.1 (Medium): Merge Intervals
/// Given an array of intervals where intervals[i] = [starti, endi], merge all overlapping intervals.
/// 
/// Example:
/// Input: intervals = [[1,3],[2,6],[8,10],[15,18]]
/// Output: [[1,6],[8,10],[15,18]]
/// </summary>
public class MergeIntervals
{
    public static List<List<int>> Solution(List<List<int>> intervals)
    {
        // TODO: Implement solution
        // Hint: Sort by start time, merge overlapping intervals
        // Time Complexity: O(n log n)
        // Space Complexity: O(n)

        if (intervals.Count < 2) return intervals;

        var sorted = intervals.OrderBy(i => i[0]).ToList();

        var merged = new List<List<int>>
        {
            new List<int> { sorted[0][0], sorted[0][1] }
        };

        for (int i = 1; i < sorted.Count; i++)
        {
            var curr = sorted[i];
            var lastMerge = merged[^1];

            if (curr[0] <= lastMerge[1])
                lastMerge[1] = Math.Max(curr[1], lastMerge[1]);
            else
                merged.Add(new List<int> { curr[0], curr[1] });
        }

        return merged;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 14.1: Merge Intervals ===");

        var test1 = new List<List<int>> { new List<int> { 1, 3 }, new List<int> { 2, 6 }, new List<int> { 8, 10 }, new List<int> { 15, 18 } };
        var result1 = Solution(test1);
        Console.WriteLine($"Test 1 - Input: [[1,3],[2,6],[8,10],[15,18]]");
        Console.WriteLine($"         Output: {result1.Count} intervals, Expected: 3");
        Console.WriteLine($"         {(result1.Count == 3 ? "✓ PASSED" : "✗ FAILED")}\n");

        var test2 = new List<List<int>> { new List<int> { 1, 4 }, new List<int> { 4, 5 } };
        var result2 = Solution(test2);
        Console.WriteLine($"Test 2 - Input: [[1,4],[4,5]]");
        Console.WriteLine($"         Output: {result2.Count} intervals, Expected: 1");
        Console.WriteLine($"         {(result2.Count == 1 ? "✓ PASSED" : "✗ FAILED")}\n");

        // Test 3: Single interval (no merge needed)
        var test3 = new List<List<int>> { new List<int> { 5, 10 } };
        var result3 = Solution(test3);
        Console.WriteLine($"Test 3 - Input: [[5,10]]");
        Console.WriteLine($"         Output: {result3.Count} intervals, Expected: 1");
        Console.WriteLine($"         {(result3.Count == 1 ? "✓ PASSED" : "✗ FAILED")}\n");

        // Test 4: Unsorted input, multiple overlaps -> merge to one interval
        var test4 = new List<List<int>> { new List<int> { 1, 4 }, new List<int> { 0, 2 }, new List<int> { 3, 5 } };
        var result4 = Solution(test4);
        Console.WriteLine($"Test 4 - Input: [[1,4],[0,2],[3,5]]");
        Console.WriteLine($"         Output: {result4.Count} intervals, Expected: 1 (merged to [0,5])");
        Console.WriteLine($"         {(result4.Count == 1 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

