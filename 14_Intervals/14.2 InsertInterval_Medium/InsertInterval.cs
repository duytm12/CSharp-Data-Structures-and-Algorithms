using System;
using System.Collections.Generic;

namespace DSA._14_2_InsertInterval_Medium;

/// <summary>
/// Problem 14.2 (Medium): Insert Interval
/// You are given an array of non-overlapping intervals and a new interval. Insert the new interval
/// into the intervals such that intervals is still sorted and non-overlapping.
/// 
/// Example:
/// Input: intervals = [[1,3],[6,9]], newInterval = [2,5]
/// Output: [[1,5],[6,9]]
/// </summary>
public class InsertInterval
{
    public static int[][] Solution(int[][] intervals, int[] newInterval)
    {
        // TODO: Implement solution
        // Hint: Find insertion point, merge overlapping intervals
        // Time Complexity: O(n)
        // Space Complexity: O(n)
        
        return Array.Empty<int[]>();
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 14.2: Insert Interval ===");
        
        int[][] test1 = new int[][] { new int[] { 1, 3 }, new int[] { 6, 9 } };
        int[] newInterval1 = { 2, 5 };
        var result1 = Solution(test1, newInterval1);
        Console.WriteLine($"Test 1 - Input: intervals = [[1,3],[6,9]], newInterval = [2,5]");
        Console.WriteLine($"         Output: {result1.Length} intervals, Expected: 2");
        Console.WriteLine($"         {(result1.Length == 2 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[][] test2 = new int[][] { new int[] { 1, 2 }, new int[] { 3, 5 }, new int[] { 6, 7 }, new int[] { 8, 10 }, new int[] { 12, 16 } };
        int[] newInterval2 = { 4, 8 };
        var result2 = Solution(test2, newInterval2);
        Console.WriteLine($"Test 2 - Input: intervals = [[1,2],[3,5],[6,7],[8,10],[12,16]], newInterval = [4,8]");
        Console.WriteLine($"         Output: {result2.Length} intervals, Expected: 3");
        Console.WriteLine($"         {(result2.Length == 3 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

