using System;
using System.Collections.Generic;

namespace DSA._17_5_MinCostToConnectAllPoints_Medium;

/// <summary>
/// Problem 17.5 (Medium): Min Cost to Connect All Points
/// You are given an array points representing integer coordinates of some points on a 2D-plane,
/// where points[i] = [xi, yi].
/// 
/// The cost of connecting two points [xi, yi] and [xj, yj] is the manhattan distance between them:
/// |xi - xj| + |yi - yj|, where |val| denotes the absolute value of val.
/// 
/// Return the minimum cost to make all points connected. All points are connected if there is
/// exactly one simple path between any two points.
/// 
/// Example:
/// Input: points = [[0,0],[2,2],[3,10],[5,2],[7,0]]
/// Output: 20
/// Explanation: We can connect the points as shown above to get the minimum cost of 20.
/// Notice that there is a unique path between every pair of points.
/// 
/// Constraints:
/// - 1 <= points.length <= 1000
/// - -10^6 <= xi, yi <= 10^6
/// - All pairs (xi, yi) are distinct.
/// </summary>
public class MinCostToConnectAllPoints
{
    public static int MinCostConnectPoints(int[][] points)
    {
        // TODO: Implement solution
        // Hint: Minimum Spanning Tree (MST) - use Prim's or Kruskal's algorithm
        // Time Complexity: O(n^2 log n) with Prim's, O(n^2 * α(n)) with Kruskal's
        // Space Complexity: O(n^2) for edges
        
        return 0;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 17.5: Min Cost to Connect All Points ===");
        
        int[][] test1 = new int[][] { new int[] { 0, 0 }, new int[] { 2, 2 }, new int[] { 3, 10 }, new int[] { 5, 2 }, new int[] { 7, 0 } };
        int result1 = MinCostConnectPoints(test1);
        Console.WriteLine($"Test 1 - Input: points = [[0,0],[2,2],[3,10],[5,2],[7,0]]");
        Console.WriteLine($"         Output: {result1}, Expected: 20");
        Console.WriteLine($"         {(result1 == 20 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[][] test2 = new int[][] { new int[] { 3, 12 }, new int[] { -2, 5 }, new int[] { -4, 1 } };
        int result2 = MinCostConnectPoints(test2);
        Console.WriteLine($"Test 2 - Input: points = [[3,12],[-2,5],[-4,1]]");
        Console.WriteLine($"         Output: {result2}, Expected: 18");
        Console.WriteLine($"         {(result2 == 18 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

