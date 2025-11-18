using System;

namespace DSA._19_7_LongestIncreasingPathInMatrix_Hard;

/// <summary>
/// Problem 19.7 (Hard): Longest Increasing Path in a Matrix
/// Given an m x n integers matrix, return the length of the longest increasing path in matrix.
/// 
/// From each cell, you can either move in four directions: left, right, up, or down. You may
/// not move diagonally or move outside the boundary (i.e., wrap-around is not allowed).
/// 
/// Example:
/// Input: matrix = [[9,9,4],[6,6,8],[2,1,1]]
/// Output: 4
/// Explanation: The longest increasing path is [1, 2, 6, 9].
/// 
/// Constraints:
/// - m == matrix.length
/// - n == matrix[i].length
/// - 1 <= m, n <= 200
/// - 0 <= matrix[i][j] <= 2^31 - 1
/// </summary>
public class LongestIncreasingPathInMatrix
{
    public static int LongestIncreasingPath(int[][] matrix)
    {
        // TODO: Implement solution
        // Hint: DFS + Memoization (DP)
        // DP[i][j] = longest path starting from (i,j)
        // For each cell, DFS to neighbors with greater values
        // Time Complexity: O(m * n)
        // Space Complexity: O(m * n)
        
        return 0;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 19.7: Longest Increasing Path in Matrix ===");
        
        int[][] test1 = new int[][]
        {
            new int[] { 9, 9, 4 },
            new int[] { 6, 6, 8 },
            new int[] { 2, 1, 1 }
        };
        int result1 = LongestIncreasingPath(test1);
        Console.WriteLine($"Test 1 - Input: [[9,9,4],[6,6,8],[2,1,1]]");
        Console.WriteLine($"         Output: {result1}, Expected: 4");
        Console.WriteLine($"         {(result1 == 4 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[][] test2 = new int[][] { new int[] { 3, 4, 5 }, new int[] { 3, 2, 6 }, new int[] { 2, 2, 1 } };
        int result2 = LongestIncreasingPath(test2);
        Console.WriteLine($"Test 2 - Input: [[3,4,5],[3,2,6],[2,2,1]]");
        Console.WriteLine($"         Output: {result2}, Expected: 4");
        Console.WriteLine($"         {(result2 == 4 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

