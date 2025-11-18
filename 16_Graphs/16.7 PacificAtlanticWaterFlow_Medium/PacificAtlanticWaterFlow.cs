using System;
using System.Collections.Generic;

namespace DSA._16_7_PacificAtlanticWaterFlow_Medium;

/// <summary>
/// Problem 16.7 (Medium): Pacific Atlantic Water Flow
/// There is an m x n rectangular island that borders both the Pacific Ocean and Atlantic Ocean.
/// The Pacific Ocean touches the island's left and top edges, and the Atlantic Ocean touches the
/// island's right and bottom edges.
/// 
/// The island is partitioned into a grid of square cells. You are given an m x n integer matrix
/// heights where heights[i][j] represents the height above sea level of the cell at coordinate (i, j).
/// 
/// The island receives a lot of rain, and the rain water can flow to neighboring cells directly
/// north, south, east, and west if the neighboring cell's height is less than or equal to the
/// current cell's height. Water can flow from any cell adjacent to an ocean into the ocean.
/// 
/// Return a 2D list of grid coordinates result where result[i] = [ri, ci] denotes that rain water
/// can flow from cell (ri, ci) to both the Pacific and Atlantic oceans.
/// 
/// Example:
/// Input: heights = [[1,2,2,3,5],[3,2,3,4,4],[2,4,5,3,1],[6,7,1,4,5],[5,1,1,2,4]]
/// Output: [[0,4],[1,3],[1,4],[2,2],[3,0],[3,1],[4,0]]
/// 
/// Constraints:
/// - m == heights.length
/// - n == heights[i].length
/// - 1 <= m, n <= 200
/// - 0 <= heights[i][j] <= 10^5
/// </summary>
public class PacificAtlanticWaterFlow
{
    public static IList<IList<int>> PacificAtlantic(int[][] heights)
    {
        // TODO: Implement solution
        // Hint: DFS from Pacific edges and Atlantic edges separately
        // Find cells reachable from both oceans
        // Time Complexity: O(m * n)
        // Space Complexity: O(m * n)
        
        return new List<IList<int>>();
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 16.7: Pacific Atlantic Water Flow ===");
        
        int[][] test1 = new int[][]
        {
            new int[] { 1, 2, 2, 3, 5 },
            new int[] { 3, 2, 3, 4, 4 },
            new int[] { 2, 4, 5, 3, 1 },
            new int[] { 6, 7, 1, 4, 5 },
            new int[] { 5, 1, 1, 2, 4 }
        };
        var result1 = PacificAtlantic(test1);
        Console.WriteLine($"Test 1 - Input: 5x5 grid");
        Console.WriteLine($"         Output: {result1.Count} cells, Expected: 7");
        Console.WriteLine($"         {(result1.Count == 7 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[][] test2 = new int[][] { new int[] { 1 } };
        var result2 = PacificAtlantic(test2);
        Console.WriteLine($"Test 2 - Input: 1x1 grid");
        Console.WriteLine($"         Output: {result2.Count} cells, Expected: 1");
        Console.WriteLine($"         {(result2.Count == 1 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

