using System;
using System.Collections.Generic;
using System.Linq;

namespace DSA._14_4_NonOverlappingIntervals_Medium;

/// <summary>
/// Problem 14.4 (Medium): Non-overlapping Intervals
/// Given an array of intervals intervals where intervals[i] = [starti, endi], return the minimum
/// number of intervals you need to remove to make the rest of the intervals non-overlapping.
/// 
/// Example:
/// Input: intervals = [[1,2],[2,3],[3,4],[1,3]]
/// Output: 1
/// Explanation: [1,3] can be removed and the rest of the intervals are non-overlapping.
/// 
/// Constraints:
/// - 1 <= intervals.length <= 10^5
/// - intervals[i].length == 2
/// - -5 * 10^4 <= starti < endi <= 5 * 10^4
/// </summary>
public class NonOverlappingIntervals
{
    public static int EraseOverlapIntervals(int[][] intervals)
    {
        // TODO: Implement solution
        // Hint: Sort by end time, greedy approach - keep intervals with earliest end times
        // Time Complexity: O(n log n)
        // Space Complexity: O(1)
        
        return 0;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 14.4: Non-overlapping Intervals ===");
        
        int[][] test1 = new int[][] { new int[] { 1, 2 }, new int[] { 2, 3 }, new int[] { 3, 4 }, new int[] { 1, 3 } };
        int result1 = EraseOverlapIntervals(test1);
        Console.WriteLine($"Test 1 - Input: [[1,2],[2,3],[3,4],[1,3]]");
        Console.WriteLine($"         Output: {result1}, Expected: 1");
        Console.WriteLine($"         {(result1 == 1 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[][] test2 = new int[][] { new int[] { 1, 2 }, new int[] { 1, 2 }, new int[] { 1, 2 } };
        int result2 = EraseOverlapIntervals(test2);
        Console.WriteLine($"Test 2 - Input: [[1,2],[1,2],[1,2]]");
        Console.WriteLine($"         Output: {result2}, Expected: 2");
        Console.WriteLine($"         {(result2 == 2 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

