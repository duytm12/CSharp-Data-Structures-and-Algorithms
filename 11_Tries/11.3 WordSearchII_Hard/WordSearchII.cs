using System;
using System.Collections.Generic;

namespace DSA._11_3_WordSearchII_Hard;

/// <summary>
/// Problem 11.3 (Hard): Word Search II
/// Given an m x n board of characters and a list of strings words, return all words
/// on the board that can be constructed using the trie.
/// 
/// Example:
/// Input: board = [["o","a","a","n"],["e","t","a","e"],["i","h","k","r"],["i","f","l","v"]]
/// words = ["oath","pea","eat","rain"]
/// Output: ["eat","oath"]
/// </summary>
public class WordSearchII
{
    public static IList<string> Solution(char[][] board, string[] words)
    {
        // TODO: Implement solution
        // Hint: Build trie from words, then DFS on board
        // Time Complexity: O(m * n * 4^L) where L is max word length
        // Space Complexity: O(ALPHABET_SIZE * N * M) for trie
        
        return new List<string>();
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 11.3: Word Search II ===");
        
        char[][] board1 = new char[][]
        {
            new char[] { 'o', 'a', 'a', 'n' },
            new char[] { 'e', 't', 'a', 'e' },
            new char[] { 'i', 'h', 'k', 'r' },
            new char[] { 'i', 'f', 'l', 'v' }
        };
        string[] words1 = { "oath", "pea", "eat", "rain" };
        var result1 = Solution(board1, words1);
        Console.WriteLine($"Test 1 - Input: board with words [\"oath\",\"pea\",\"eat\",\"rain\"]");
        Console.WriteLine($"         Output: [{string.Join(",", result1)}], Expected: [\"eat\",\"oath\"]");
        bool passed1 = result1.Count == 2 && result1.Contains("eat") && result1.Contains("oath");
        Console.WriteLine($"         {(passed1 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        char[][] board2 = new char[][] { new char[] { 'a', 'b' }, new char[] { 'c', 'd' } };
        string[] words2 = { "abcb" };
        var result2 = Solution(board2, words2);
        Console.WriteLine($"Test 2 - Input: board with word [\"abcb\"]");
        Console.WriteLine($"         Output: [{string.Join(",", result2)}], Expected: []");
        Console.WriteLine($"         {(result2.Count == 0 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

