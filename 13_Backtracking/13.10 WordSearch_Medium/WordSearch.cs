using System;

namespace DSA._13_10_WordSearch_Medium;

/// <summary>
/// Problem 13.10 (Medium): Word Search
/// Given an m x n grid of characters board and a string word, return true if word exists
/// in the grid. The word can be constructed from letters of sequentially adjacent cells.
/// 
/// Example:
/// Input: board = [["A","B","C","E"],["S","F","C","S"],["A","D","E","E"]], word = "ABCCED"
/// Output: true
/// 
/// Constraints:
/// - m == board.length
/// - n = board[i].length
/// - 1 <= m, n <= 6
/// - 1 <= word.length <= 15
/// - board and word consists of only lowercase and uppercase English letters.
/// </summary>
public class WordSearch
{
    public static bool Exist(char[][] board, string word)
    {
        // TODO: Implement solution
        // Hint: DFS with backtracking, mark visited cells, unmark when backtracking
        // Time Complexity: O(m * n * 4^L) where L is word length
        // Space Complexity: O(L) for recursion stack
        
        return false;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 13.10: Word Search ===");
        
        char[][] test1 = new char[][]
        {
            new char[] { 'A', 'B', 'C', 'E' },
            new char[] { 'S', 'F', 'C', 'S' },
            new char[] { 'A', 'D', 'E', 'E' }
        };
        bool result1 = Exist(test1, "ABCCED");
        Console.WriteLine($"Test 1 - Input: board with word \"ABCCED\"");
        Console.WriteLine($"         Output: {result1}, Expected: True");
        Console.WriteLine($"         {(result1 == true ? "✓ PASSED" : "✗ FAILED")}\n");
        
        char[][] test2 = new char[][]
        {
            new char[] { 'A', 'B', 'C', 'E' },
            new char[] { 'S', 'F', 'C', 'S' },
            new char[] { 'A', 'D', 'E', 'E' }
        };
        bool result2 = Exist(test2, "ABCB");
        Console.WriteLine($"Test 2 - Input: board with word \"ABCB\"");
        Console.WriteLine($"         Output: {result2}, Expected: False");
        Console.WriteLine($"         {(result2 == false ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

