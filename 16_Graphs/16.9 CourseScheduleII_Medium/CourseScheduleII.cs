using System;
using System.Collections.Generic;

namespace DSA._16_9_CourseScheduleII_Medium;

/// <summary>
/// Problem 16.9 (Medium): Course Schedule II
/// There are a total of numCourses courses you have to take, labeled from 0 to numCourses - 1.
/// You are given an array prerequisites where prerequisites[i] = [ai, bi] indicates that you must
/// take course bi first if you want to take course ai.
/// 
/// Return the ordering of courses you should take to finish all courses. If there are many valid
/// answers, return any of them. If it is impossible to finish all courses, return an empty array.
/// 
/// Example:
/// Input: numCourses = 4, prerequisites = [[1,0],[2,0],[3,1],[3,2]]
/// Output: [0,2,1,3]
/// Explanation: There are a total of 4 courses to take. To take course 3 you should have finished
/// both courses 1 and 2. Both courses 1 and 2 should be taken after you finished course 0.
/// So one correct course order is [0,1,2,3]. Another correct ordering is [0,2,1,3].
/// 
/// Constraints:
/// - 1 <= numCourses <= 2000
/// - 0 <= prerequisites.length <= numCourses * (numCourses - 1)
/// - prerequisites[i].length == 2
/// - 0 <= ai, bi < numCourses
/// - ai != bi
/// - All the pairs [ai, bi] are distinct.
/// </summary>
public class CourseScheduleII
{
    public static int[] FindOrder(int numCourses, int[][] prerequisites)
    {
        // TODO: Implement solution
        // Hint: Topological sort using Kahn's algorithm or DFS
        // Return topological ordering
        // Time Complexity: O(V + E)
        // Space Complexity: O(V + E)
        
        return Array.Empty<int>();
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 16.9: Course Schedule II ===");
        
        int[][] test1 = new int[][] { new int[] { 1, 0 }, new int[] { 2, 0 }, new int[] { 3, 1 }, new int[] { 3, 2 } };
        var result1 = FindOrder(4, test1);
        Console.WriteLine($"Test 1 - Input: numCourses = 4, prerequisites = [[1,0],[2,0],[3,1],[3,2]]");
        Console.WriteLine($"         Output: [{string.Join(",", result1)}]");
        bool passed1 = result1.Length == 4;
        Console.WriteLine($"         {(passed1 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[][] test2 = new int[][] { new int[] { 1, 0 }, new int[] { 0, 1 } };
        var result2 = FindOrder(2, test2);
        Console.WriteLine($"Test 2 - Input: numCourses = 2, prerequisites = [[1,0],[0,1]] (cycle)");
        Console.WriteLine($"         Output: [{string.Join(",", result2)}], Expected: []");
        Console.WriteLine($"         {(result2.Length == 0 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

