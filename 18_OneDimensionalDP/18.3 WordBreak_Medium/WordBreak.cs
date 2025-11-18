using System;
using System.Collections.Generic;

namespace DSA._18_3_WordBreak_Medium;

/// <summary>
/// Problem 18.3 (Medium): Word Break
/// Given a string s and a dictionary of strings wordDict, return true if s can be segmented
/// into a space-separated sequence of one or more dictionary words.
/// 
/// Example:
/// Input: s = "leetcode", wordDict = ["leet","code"]
/// Output: true
/// </summary>
public class WordBreak
{
    public static bool Solution(string s, IList<string> wordDict)
    {
        // TODO: Implement solution
        // Hint: DP[i] = true if s[0..i] can be segmented, check all possible word endings
        // Time Complexity: O(n * m) where m is average word length
        // Space Complexity: O(n)
        
        return false;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 18.3: Word Break ===");
        
        string s1 = "leetcode";
        var wordDict1 = new List<string> { "leet", "code" };
        bool result1 = Solution(s1, wordDict1);
        Console.WriteLine($"Test 1 - Input: s = \"leetcode\", wordDict = [\"leet\",\"code\"]");
        Console.WriteLine($"         Output: {result1}, Expected: True");
        Console.WriteLine($"         {(result1 == true ? "✓ PASSED" : "✗ FAILED")}\n");
        
        string s2 = "applepenapple";
        var wordDict2 = new List<string> { "apple", "pen" };
        bool result2 = Solution(s2, wordDict2);
        Console.WriteLine($"Test 2 - Input: s = \"applepenapple\", wordDict = [\"apple\",\"pen\"]");
        Console.WriteLine($"         Output: {result2}, Expected: True");
        Console.WriteLine($"         {(result2 == true ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

