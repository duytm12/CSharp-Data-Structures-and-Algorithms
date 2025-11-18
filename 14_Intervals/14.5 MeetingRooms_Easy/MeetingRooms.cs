using System;
using System.Collections.Generic;

namespace DSA._14_5_MeetingRooms_Easy;

/// <summary>
/// Problem 14.5 (Easy): Meeting Rooms
/// Given an array of meeting time intervals where intervals[i] = [starti, endi], determine if
/// a person could attend all meetings.
/// 
/// Example:
/// Input: intervals = [[0,30],[5,10],[15,20]]
/// Output: false
/// 
/// Constraints:
/// - 0 <= intervals.length <= 10^4
/// - intervals[i].length == 2
/// - 0 <= starti < endi <= 10^6
/// </summary>
public class MeetingRooms
{
    public static bool CanAttendMeetings(int[][] intervals)
    {
        // TODO: Implement solution
        // Hint: Sort by start time, check if any interval overlaps with next
        // Time Complexity: O(n log n)
        // Space Complexity: O(1)
        
        return false;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 14.5: Meeting Rooms ===");
        
        int[][] test1 = new int[][] { new int[] { 0, 30 }, new int[] { 5, 10 }, new int[] { 15, 20 } };
        bool result1 = CanAttendMeetings(test1);
        Console.WriteLine($"Test 1 - Input: [[0,30],[5,10],[15,20]]");
        Console.WriteLine($"         Output: {result1}, Expected: False");
        Console.WriteLine($"         {(result1 == false ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[][] test2 = new int[][] { new int[] { 7, 10 }, new int[] { 2, 4 } };
        bool result2 = CanAttendMeetings(test2);
        Console.WriteLine($"Test 2 - Input: [[7,10],[2,4]]");
        Console.WriteLine($"         Output: {result2}, Expected: True");
        Console.WriteLine($"         {(result2 == true ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

