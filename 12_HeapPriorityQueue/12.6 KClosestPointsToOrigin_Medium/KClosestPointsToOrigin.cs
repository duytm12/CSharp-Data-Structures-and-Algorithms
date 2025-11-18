using System;
using System.Collections.Generic;

namespace DSA._12_6_KClosestPointsToOrigin_Medium;

/// <summary>
/// Problem 12.6 (Medium): K Closest Points to Origin
/// Given an array of points where points[i] = [xi, yi] represents a point on the X-Y plane and
/// an integer k, return the k closest points to the origin (0, 0).
/// 
/// The distance between two points on the X-Y plane is the Euclidean distance.
/// 
/// Example:
/// Input: points = [[1,3],[-2,2]], k = 1
/// Output: [[-2,2]]
/// Explanation: The distance between (1, 3) and the origin is sqrt(10).
/// The distance between (-2, 2) and the origin is sqrt(8).
/// Since sqrt(8) < sqrt(10), (-2, 2) is closer to the origin.
/// 
/// Constraints:
/// - 1 <= k <= points.length <= 10^4
/// - -10^4 < xi, yi < 10^4
/// </summary>
public class KClosestPointsToOrigin
{
    public static int[][] Solution(int[][] points, int k)
    {
        // TODO: Implement solution
        // Hint: Use PriorityQueue with distance as priority, keep k closest
        // Time Complexity: O(n log k)
        // Space Complexity: O(k)
        
        return Array.Empty<int[]>();
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 12.6: K Closest Points to Origin ===");
        
        int[][] test1 = new int[][] { new int[] { 1, 3 }, new int[] { -2, 2 } };
        var result1 = Solution(test1, 1);
        Console.WriteLine($"Test 1 - Input: [[1,3],[-2,2]], k = 1");
        Console.WriteLine($"         Output: [{result1[0][0]},{result1[0][1]}], Expected: [-2,2]");
        bool passed1 = result1.Length == 1 && result1[0][0] == -2 && result1[0][1] == 2;
        Console.WriteLine($"         {(passed1 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[][] test2 = new int[][] { new int[] { 3, 3 }, new int[] { 5, -1 }, new int[] { -2, 4 } };
        var result2 = Solution(test2, 2);
        Console.WriteLine($"Test 2 - Input: [[3,3],[5,-1],[-2,4]], k = 2");
        Console.WriteLine($"         Output: {result2.Length} points");
        bool passed2 = result2.Length == 2;
        Console.WriteLine($"         {(passed2 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

