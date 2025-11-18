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
    public static int[][] Solution(int[][] intervals)
    {
        // TODO: Implement solution
        // Hint: Sort by start time, merge overlapping intervals
        // Time Complexity: O(n log n)
        // Space Complexity: O(n)
        
        return Array.Empty<int[]>();
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 14.1: Merge Intervals ===");
        
        int[][] test1 = new int[][] { new int[] { 1, 3 }, new int[] { 2, 6 }, new int[] { 8, 10 }, new int[] { 15, 18 } };
        var result1 = Solution(test1);
        Console.WriteLine($"Test 1 - Input: [[1,3],[2,6],[8,10],[15,18]]");
        Console.WriteLine($"         Output: {result1.Length} intervals, Expected: 3");
        Console.WriteLine($"         {(result1.Length == 3 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[][] test2 = new int[][] { new int[] { 1, 4 }, new int[] { 4, 5 } };
        var result2 = Solution(test2);
        Console.WriteLine($"Test 2 - Input: [[1,4],[4,5]]");
        Console.WriteLine($"         Output: {result2.Length} intervals, Expected: 1");
        Console.WriteLine($"         {(result2.Length == 1 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

