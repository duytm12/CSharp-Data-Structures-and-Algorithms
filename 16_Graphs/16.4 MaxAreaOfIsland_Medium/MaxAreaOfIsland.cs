using System;

namespace DSA._16_4_MaxAreaOfIsland_Medium;

/// <summary>
/// Problem 16.4 (Medium): Max Area of Island
/// You are given an m x n binary matrix grid. An island is a group of 1's (representing land)
/// connected 4-directionally (horizontal or vertical). You may assume all four edges of the grid
/// are all surrounded by water.
/// 
/// The area of an island is the number of cells with a value 1 in the island.
/// 
/// Return the maximum area of an island in grid. If there is no island, return 0.
/// 
/// Example:
/// Input: grid = [[0,0,1,0,0,0,0,1,0,0,0,0,0],[0,0,0,0,0,0,0,1,1,1,0,0,0],[0,1,1,0,1,0,0,0,0,0,0,0,0],[0,1,0,0,1,1,0,0,1,0,1,0,0],[0,1,0,0,1,1,0,0,1,1,1,0,0],[0,0,0,0,0,0,0,0,0,0,1,0,0],[0,0,0,0,0,0,0,1,1,1,0,0,0],[0,0,0,0,0,0,0,1,1,0,0,0,0]]
/// Output: 6
/// 
/// Constraints:
/// - m == grid.length
/// - n == grid[i].length
/// - 1 <= m, n <= 50
/// - grid[i][j] is either 0 or 1.
/// </summary>
public class MaxAreaOfIsland
{
    public static int Solution(int[][] grid)
    {
        // TODO: Implement solution
        // Hint: DFS or BFS to find all connected 1's, track maximum area
        // Time Complexity: O(m * n)
        // Space Complexity: O(m * n) worst case for recursion
        
        return 0;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 16.4: Max Area of Island ===");
        
        int[][] test1 = new int[][]
        {
            new int[] { 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
            new int[] { 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0 },
            new int[] { 0, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
            new int[] { 0, 1, 0, 0, 1, 1, 0, 0, 1, 0, 1, 0, 0 },
            new int[] { 0, 1, 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 0 },
            new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0 },
            new int[] { 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0 },
            new int[] { 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0 }
        };
        int result1 = Solution(test1);
        Console.WriteLine($"Test 1 - Input: 8x13 grid");
        Console.WriteLine($"         Output: {result1}, Expected: 6");
        Console.WriteLine($"         {(result1 == 6 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[][] test2 = new int[][] { new int[] { 0, 0, 0, 0, 0, 0, 0, 0 } };
        int result2 = Solution(test2);
        Console.WriteLine($"Test 2 - Input: grid with no islands");
        Console.WriteLine($"         Output: {result2}, Expected: 0");
        Console.WriteLine($"         {(result2 == 0 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

