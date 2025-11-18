using System;

namespace DSA._16_8_SurroundedRegions_Medium;

/// <summary>
/// Problem 16.8 (Medium): Surrounded Regions
/// Given an m x n matrix board containing 'X' and 'O', capture all regions that are 4-directionally
/// surrounded by 'X'.
/// 
/// A region is captured by flipping all 'O's into 'X's in that surrounded region.
/// 
/// Example:
/// Input: board = [["X","X","X","X"],["X","O","O","X"],["X","X","O","X"],["X","O","X","X"]]
/// Output: [["X","X","X","X"],["X","X","X","X"],["X","X","X","X"],["X","O","X","X"]]
/// Explanation: Notice that an 'O' should not be flipped if:
/// - It is on the border, or
/// - It is adjacent to an 'O' on the border that will not be flipped.
/// 
/// Constraints:
/// - m == board.length
/// - n == board[i].length
/// - 1 <= m, n <= 200
/// - board[i][j] is 'X' or 'O'.
/// </summary>
public class SurroundedRegions
{
    public static void Solve(char[][] board)
    {
        // TODO: Implement solution
        // Hint: DFS from border 'O's, mark connected 'O's as safe
        // Flip remaining 'O's to 'X'
        // Time Complexity: O(m * n)
        // Space Complexity: O(m * n)
        
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 16.8: Surrounded Regions ===");
        
        char[][] test1 = new char[][]
        {
            new char[] { 'X', 'X', 'X', 'X' },
            new char[] { 'X', 'O', 'O', 'X' },
            new char[] { 'X', 'X', 'O', 'X' },
            new char[] { 'X', 'O', 'X', 'X' }
        };
        Solve(test1);
        Console.WriteLine($"Test 1 - Input: 4x4 board");
        Console.WriteLine($"         Output: Board modified");
        bool passed1 = test1[1][1] == 'X' && test1[3][1] == 'O';
        Console.WriteLine($"         {(passed1 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        char[][] test2 = new char[][] { new char[] { 'X' } };
        Solve(test2);
        Console.WriteLine($"Test 2 - Input: 1x1 board");
        Console.WriteLine($"         Output: Board modified");
        bool passed2 = test2[0][0] == 'X';
        Console.WriteLine($"         {(passed2 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

