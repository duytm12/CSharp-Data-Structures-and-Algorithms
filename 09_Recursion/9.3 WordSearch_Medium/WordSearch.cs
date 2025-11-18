using System;

namespace DSA._9_3_WordSearch_Medium;

/// <summary>
/// Problem 9.3 (Medium): Word Search
/// Given an m x n grid of characters board and a string word, return true if word exists
/// in the grid. The word can be constructed from letters of sequentially adjacent cells.
/// 
/// Example:
/// Input: board = [["A","B","C","E"],["S","F","C","S"],["A","D","E","E"]], word = "ABCCED"
/// Output: true
/// </summary>
public class WordSearch
{
    public static bool Solution(char[][] board, string word)
    {
        // TODO: Implement solution
        // Hint: DFS with backtracking, mark visited cells
        // Time Complexity: O(m * n * 4^L) where L is word length
        // Space Complexity: O(L) for recursion stack
        
        return false;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 9.3: Word Search ===");
        
        char[][] test1 = new char[][]
        {
            new char[] { 'A', 'B', 'C', 'E' },
            new char[] { 'S', 'F', 'C', 'S' },
            new char[] { 'A', 'D', 'E', 'E' }
        };
        string word1 = "ABCCED";
        bool result1 = Solution(test1, word1);
        Console.WriteLine($"Test 1 - Input: board with word \"{word1}\"");
        Console.WriteLine($"         Output: {result1}, Expected: True");
        Console.WriteLine($"         {(result1 == true ? "✓ PASSED" : "✗ FAILED")}\n");
        
        char[][] test2 = new char[][]
        {
            new char[] { 'A', 'B', 'C', 'E' },
            new char[] { 'S', 'F', 'C', 'S' },
            new char[] { 'A', 'D', 'E', 'E' }
        };
        string word2 = "ABCB";
        bool result2 = Solution(test2, word2);
        Console.WriteLine($"Test 2 - Input: board with word \"{word2}\"");
        Console.WriteLine($"         Output: {result2}, Expected: False");
        Console.WriteLine($"         {(result2 == false ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

