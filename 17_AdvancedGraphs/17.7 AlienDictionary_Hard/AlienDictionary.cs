using System;
using System.Collections.Generic;
using System.Linq;

namespace DSA._17_7_AlienDictionary_Hard;

/// <summary>
/// Problem 17.7 (Hard): Alien Dictionary
/// There is a new alien language that uses the English alphabet. However, the order among the
/// letters is unknown to you.
/// 
/// You are given a list of strings words from the alien language's dictionary, where the strings
/// in words are sorted lexicographically by the rules of this new language.
/// 
/// Return a string of the unique letters in the new alien language sorted in lexicographically
/// increasing order by the new language's rules. If there is no solution, return "". If there are
/// multiple solutions, return any of them.
/// 
/// Example:
/// Input: words = ["wrt","wrf","er","ett","rftt"]
/// Output: "wertf"
/// 
/// Constraints:
/// - 1 <= words.length <= 100
/// - 1 <= words[i].length <= 100
/// - words[i] consists of only lowercase English letters.
/// </summary>
public class AlienDictionary
{
    public static string AlienOrder(string[] words)
    {
        // TODO: Implement solution
        // Hint: Build graph from word comparisons, topological sort
        // Compare adjacent words to find character ordering
        // Time Complexity: O(C) where C is total characters
        // Space Complexity: O(1) - at most 26 characters
        
        return string.Empty;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 17.7: Alien Dictionary ===");
        
        string[] test1 = { "wrt", "wrf", "er", "ett", "rftt" };
        string result1 = AlienOrder(test1);
        Console.WriteLine($"Test 1 - Input: words = [\"wrt\",\"wrf\",\"er\",\"ett\",\"rftt\"]");
        Console.WriteLine($"         Output: \"{result1}\", Expected: \"wertf\"");
        bool passed1 = result1.Length == 5 && result1.Contains('w') && result1.Contains('e');
        Console.WriteLine($"         {(passed1 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        string[] test2 = { "z", "x" };
        string result2 = AlienOrder(test2);
        Console.WriteLine($"Test 2 - Input: words = [\"z\",\"x\"]");
        Console.WriteLine($"         Output: \"{result2}\", Expected: \"zx\"");
        Console.WriteLine($"         {(result2 == "zx" ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

