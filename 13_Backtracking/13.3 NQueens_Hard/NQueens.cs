using System;
using System.Collections.Generic;

namespace DSA._13_3_NQueens_Hard;

/// <summary>
/// Problem 13.3 (Hard): N-Queens
/// The n-queens puzzle is the problem of placing n queens on an n x n chessboard such that
/// no two queens attack each other. Return all distinct solutions.
/// 
/// Example:
/// Input: n = 4
/// Output: [[".Q..","...Q","Q...","..Q."],["..Q.","Q...","...Q",".Q.."]]
/// </summary>
public class NQueens
{
    public static IList<IList<string>> Solution(int n)
    {
        // TODO: Implement solution
        // Hint: Backtrack row by row, check column and diagonal conflicts
        // Time Complexity: O(n!)
        // Space Complexity: O(n^2)
        
        return new List<IList<string>>();
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 13.3: N-Queens ===");
        
        var result1 = Solution(4);
        Console.WriteLine($"Test 1 - Input: n = 4");
        Console.WriteLine($"         Output: {result1.Count} solutions, Expected: 2");
        Console.WriteLine($"         {(result1.Count == 2 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        var result2 = Solution(1);
        Console.WriteLine($"Test 2 - Input: n = 1");
        Console.WriteLine($"         Output: {result2.Count} solutions, Expected: 1");
        Console.WriteLine($"         {(result2.Count == 1 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

