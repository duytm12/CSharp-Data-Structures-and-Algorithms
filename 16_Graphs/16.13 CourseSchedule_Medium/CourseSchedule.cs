using System;
using System.Collections.Generic;

namespace DSA._16_13_CourseSchedule_Medium;

/// <summary>
/// Problem 16.13 (Medium): Course Schedule
/// There are a total of numCourses courses you have to take, labeled from 0 to numCourses - 1.
/// You are given an array prerequisites where prerequisites[i] = [ai, bi] indicates that you
/// must take course bi first if you want to take course ai.
/// 
/// Return true if you can finish all courses, otherwise return false.
/// 
/// Example:
/// Input: numCourses = 2, prerequisites = [[1,0]]
/// Output: true
/// Explanation: There are a total of 2 courses to take. To take course 1 you should have finished course 0. So it is possible.
/// 
/// Constraints:
/// - 1 <= numCourses <= 2000
/// - 0 <= prerequisites.length <= 5000
/// - prerequisites[i].length == 2
/// - 0 <= ai, bi < numCourses
/// - All the pairs prerequisites[i] are unique.
/// </summary>
public class CourseSchedule
{
    public static bool CanFinish(int numCourses, int[][] prerequisites)
    {
        // TODO: Implement solution
        // Hint: Detect cycle using DFS or topological sort
        // Time Complexity: O(V + E)
        // Space Complexity: O(V + E)
        
        return false;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 16.13: Course Schedule ===");
        
        int[][] test1 = new int[][] { new int[] { 1, 0 } };
        bool result1 = CanFinish(2, test1);
        Console.WriteLine($"Test 1 - Input: numCourses = 2, prerequisites = [[1,0]]");
        Console.WriteLine($"         Output: {result1}, Expected: True");
        Console.WriteLine($"         {(result1 == true ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[][] test2 = new int[][] { new int[] { 1, 0 }, new int[] { 0, 1 } };
        bool result2 = CanFinish(2, test2);
        Console.WriteLine($"Test 2 - Input: numCourses = 2, prerequisites = [[1,0],[0,1]] (cycle)");
        Console.WriteLine($"         Output: {result2}, Expected: False");
        Console.WriteLine($"         {(result2 == false ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

