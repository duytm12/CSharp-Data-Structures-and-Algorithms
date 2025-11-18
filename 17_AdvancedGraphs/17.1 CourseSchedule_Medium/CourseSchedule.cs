using System;
using System.Collections.Generic;

namespace DSA._17_1_CourseSchedule_Medium;

/// <summary>
/// Problem 17.1 (Medium): Course Schedule
/// There are a total of numCourses courses you have to take. Some courses may have prerequisites.
/// Return true if you can finish all courses, otherwise return false.
/// 
/// Example:
/// Input: numCourses = 2, prerequisites = [[1,0]]
/// Output: true
/// </summary>
public class CourseSchedule
{
    public static bool Solution(int numCourses, int[][] prerequisites)
    {
        // TODO: Implement solution
        // Hint: Detect cycle using DFS or topological sort
        // Time Complexity: O(V + E)
        // Space Complexity: O(V + E)
        
        return false;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 17.1: Course Schedule ===");
        
        int[][] test1 = new int[][] { new int[] { 1, 0 } };
        bool result1 = Solution(2, test1);
        Console.WriteLine($"Test 1 - Input: numCourses = 2, prerequisites = [[1,0]]");
        Console.WriteLine($"         Output: {result1}, Expected: True");
        Console.WriteLine($"         {(result1 == true ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[][] test2 = new int[][] { new int[] { 1, 0 }, new int[] { 0, 1 } };
        bool result2 = Solution(2, test2);
        Console.WriteLine($"Test 2 - Input: numCourses = 2, prerequisites = [[1,0],[0,1]] (cycle)");
        Console.WriteLine($"         Output: {result2}, Expected: False");
        Console.WriteLine($"         {(result2 == false ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

