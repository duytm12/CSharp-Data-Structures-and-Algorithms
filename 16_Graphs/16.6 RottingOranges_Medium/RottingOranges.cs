using System;
using System.Collections.Generic;

namespace DSA._16_6_RottingOranges_Medium;

/// <summary>
/// Problem 16.6 (Medium): Rotting Oranges
/// You are given an m x n grid where each cell can have one of three values:
/// - 0 representing an empty cell,
/// - 1 representing a fresh orange, or
/// - 2 representing a rotten orange.
/// 
/// Every minute, any fresh orange that is 4-directionally adjacent to a rotten orange becomes rotten.
/// 
/// Return the minimum number of minutes that must elapse until no cell has a fresh orange. If this
/// is impossible, return -1.
/// 
/// Example:
/// Input: grid = [[2,1,1],[1,1,0],[0,1,1]]
/// Output: 4
/// 
/// Constraints:
/// - m == grid.length
/// - n == grid[i].length
/// - 1 <= m, n <= 10
/// - grid[i][j] is 0, 1, or 2.
/// </summary>
public class RottingOranges
{
    public static int OrangesRotting(int[][] grid)
    {
        // TODO: Implement solution
        // Hint: Multi-source BFS from all rotten oranges, track minutes
        // Time Complexity: O(m * n)
        // Space Complexity: O(m * n)
        
        return -1;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 16.6: Rotting Oranges ===");
        
        int[][] test1 = new int[][]
        {
            new int[] { 2, 1, 1 },
            new int[] { 1, 1, 0 },
            new int[] { 0, 1, 1 }
        };
        int result1 = OrangesRotting(test1);
        Console.WriteLine($"Test 1 - Input: 3x3 grid");
        Console.WriteLine($"         Output: {result1}, Expected: 4");
        Console.WriteLine($"         {(result1 == 4 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[][] test2 = new int[][] { new int[] { 2, 1, 1 }, new int[] { 0, 1, 1 }, new int[] { 1, 0, 1 } };
        int result2 = OrangesRotting(test2);
        Console.WriteLine($"Test 2 - Input: 3x3 grid");
        Console.WriteLine($"         Output: {result2}, Expected: -1");
        Console.WriteLine($"         {(result2 == -1 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

