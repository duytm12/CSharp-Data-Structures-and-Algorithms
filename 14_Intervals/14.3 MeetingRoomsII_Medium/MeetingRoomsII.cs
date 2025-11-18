using System;
using System.Collections.Generic;

namespace DSA._14_3_MeetingRoomsII_Medium;

/// <summary>
/// Problem 14.3 (Medium): Meeting Rooms II
/// Given an array of meeting time intervals where intervals[i] = [starti, endi], return the
/// minimum number of conference rooms required.
/// 
/// Example:
/// Input: intervals = [[0,30],[5,10],[15,20]]
/// Output: 2
/// </summary>
public class MeetingRoomsII
{
    public static int Solution(int[][] intervals)
    {
        // TODO: Implement solution
        // Hint: Use priority queue to track room end times
        // Time Complexity: O(n log n)
        // Space Complexity: O(n)
        
        return 0;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 14.3: Meeting Rooms II ===");
        
        int[][] test1 = new int[][] { new int[] { 0, 30 }, new int[] { 5, 10 }, new int[] { 15, 20 } };
        int result1 = Solution(test1);
        Console.WriteLine($"Test 1 - Input: [[0,30],[5,10],[15,20]]");
        Console.WriteLine($"         Output: {result1}, Expected: 2");
        Console.WriteLine($"         {(result1 == 2 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[][] test2 = new int[][] { new int[] { 7, 10 }, new int[] { 2, 4 } };
        int result2 = Solution(test2);
        Console.WriteLine($"Test 2 - Input: [[7,10],[2,4]]");
        Console.WriteLine($"         Output: {result2}, Expected: 1");
        Console.WriteLine($"         {(result2 == 1 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

