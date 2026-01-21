using System;
using System.Collections.Generic;

namespace DSA._2_7_FirstUniqueCharacter_Medium;

/// <summary>
/// Problem 2.7 (Medium): First Unique Character in String
/// Given a string s, find the first non-repeating character in it and return its index.
/// If it does not exist, return -1. Use Dictionary&lt;TKey, TValue&gt; to track character frequencies.
/// 
/// Example:
/// Input: s = "leetcode"
/// Output: 0
/// Explanation: The character 'l' at index 0 is the first character that does not repeat.
/// 
/// Constraints:
/// - 1 <= s.length <= 10^5
/// - s consists of only lowercase English letters.
/// </summary>
public class FirstUniqueCharacter
{
    public static int Solution(string s)
    {
        // TODO: Implement solution
        // Hint: Use Dictionary to count frequencies, then find first character with count == 1
        // Time Complexity: O(n)
        // Space Complexity: O(1) - at most 26 characters
        var dict = new Dictionary<char, int>();
        var charArr = s.ToCharArray();
        foreach (var c in charArr)
        {
            dict[c] = dict.GetValueOrDefault(c, 0) + 1;
        }

        for (int i = 0; i < s.Length; i++)
        {
            if (dict[s[i]] == 1) return i;
        }

        return -1;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 2.7: First Unique Character ===");
        
        string test1 = "leetcode";
        int result1 = Solution(test1);
        Console.WriteLine($"Test 1 - Input: \"leetcode\"");
        Console.WriteLine($"         Output: {result1}, Expected: 0");
        Console.WriteLine($"         {(result1 == 0 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        string test2 = "aabb";
        int result2 = Solution(test2);
        Console.WriteLine($"Test 2 - Input: \"aabb\"");
        Console.WriteLine($"         Output: {result2}, Expected: -1");
        Console.WriteLine($"         {(result2 == -1 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

