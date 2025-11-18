using System;
using System.Collections.Generic;

namespace DSA._17_6_SwimInRisingWater_Hard;

/// <summary>
/// Problem 17.6 (Hard): Swim in Rising Water
/// You are given an n x n integer matrix grid where each value grid[i][j] represents the elevation
/// at that point (i, j).
/// 
/// The rain starts to fall. At time t, the depth of the water everywhere is t. You can swim from
/// a square to another 4-directionally adjacent square if and only if the elevation of both squares
/// individually are at most t. You can swim infinite distance in zero time. Of course, you must
/// stay within the boundaries of the grid during your swim.
/// 
/// Return the least time until you can reach the bottom right square (n - 1, n - 1) if you start
/// at the top left square (0, 0).
/// 
/// Example:
/// Input: grid = [[0,2],[1,3]]
/// Output: 3
/// Explanation:
/// At time t = 0, you are in the location (0, 0).
/// You cannot go anywhere else because 4-directionally adjacent neighbors have a higher elevation than t = 0.
/// You cannot reach point (1, 1) until time t = 3.
/// When the depth of water is 3, we can swim anywhere inside the grid.
/// 
/// Constraints:
/// - n == grid.length
/// - n == grid[i].length
/// - 1 <= n <= 50
/// - 0 <= grid[i][j] < n^2
/// - Each value grid[i][j] is unique.
/// </summary>
public class SwimInRisingWater
{
    public static int SwimInWater(int[][] grid)
    {
        // TODO: Implement solution
        // Hint: Binary search on answer or Dijkstra's algorithm
        // Find minimum time to reach destination
        // Time Complexity: O(n^2 log n) with Dijkstra's
        // Space Complexity: O(n^2)
        
        return 0;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 17.6: Swim in Rising Water ===");
        
        int[][] test1 = new int[][] { new int[] { 0, 2 }, new int[] { 1, 3 } };
        int result1 = SwimInWater(test1);
        Console.WriteLine($"Test 1 - Input: grid = [[0,2],[1,3]]");
        Console.WriteLine($"         Output: {result1}, Expected: 3");
        Console.WriteLine($"         {(result1 == 3 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[][] test2 = new int[][]
        {
            new int[] { 0, 1, 2, 3, 4 },
            new int[] { 24, 23, 22, 21, 5 },
            new int[] { 12, 13, 14, 15, 16 },
            new int[] { 11, 17, 18, 19, 20 },
            new int[] { 10, 9, 8, 7, 6 }
        };
        int result2 = SwimInWater(test2);
        Console.WriteLine($"Test 2 - Input: 5x5 grid");
        Console.WriteLine($"         Output: {result2}, Expected: 16");
        Console.WriteLine($"         {(result2 == 16 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

