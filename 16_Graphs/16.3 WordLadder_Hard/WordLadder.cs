using System;
using System.Collections.Generic;

namespace DSA._16_3_WordLadder_Hard;

/// <summary>
/// Problem 16.3 (Hard): Word Ladder
/// A transformation sequence from word beginWord to word endWord using a dictionary wordList is
/// a sequence of words such that adjacent words differ by a single letter. Return the number
/// of words in the shortest transformation sequence.
/// 
/// Example:
/// Input: beginWord = "hit", endWord = "cog", wordList = ["hot","dot","dog","lot","log","cog"]
/// Output: 5
/// </summary>
public class WordLadder
{
    public static int Solution(string beginWord, string endWord, IList<string> wordList)
    {
        // TODO: Implement solution
        // Hint: BFS with word transformation graph
        // Time Complexity: O(M * N) where M is word length, N is wordList size
        // Space Complexity: O(M * N)
        
        return 0;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 16.3: Word Ladder ===");
        
        string beginWord1 = "hit";
        string endWord1 = "cog";
        var wordList1 = new List<string> { "hot", "dot", "dog", "lot", "log", "cog" };
        int result1 = Solution(beginWord1, endWord1, wordList1);
        Console.WriteLine($"Test 1 - Input: beginWord = \"hit\", endWord = \"cog\"");
        Console.WriteLine($"         Output: {result1}, Expected: 5");
        Console.WriteLine($"         {(result1 == 5 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        string beginWord2 = "hit";
        string endWord2 = "cog";
        var wordList2 = new List<string> { "hot", "dot", "dog", "lot", "log" };
        int result2 = Solution(beginWord2, endWord2, wordList2);
        Console.WriteLine($"Test 2 - Input: beginWord = \"hit\", endWord = \"cog\" (no path)");
        Console.WriteLine($"         Output: {result2}, Expected: 0");
        Console.WriteLine($"         {(result2 == 0 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

