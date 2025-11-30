using System;
using System.Collections.Generic;
namespace DSA._1_4_ValidAnagram_Easy;

/// <summary>
/// Problem 1.4 (Easy): Valid Anagram
/// Given two strings s and t, return true if t is an anagram of s, and false otherwise.
/// An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase,
/// typically using all the original letters exactly once.
/// 
/// Example:
/// Input: s = "anagram", t = "nagaram"
/// Output: true
/// 
/// Constraints:
/// - 1 <= s.length, t.length <= 5 * 10^4
/// - s and t consist of lowercase English letters.
/// </summary>
public class ValidAnagram
{
    public static bool Solution(string s, string t)
    {
        // TODO: Implement solution
        // Hint: Count character frequencies in both strings and compare
        // Time Complexity: O(n)
        // Space Complexity: O(1) - at most 26 characters
        if (s.Length != t.Length) return false;

        var charCount = new Dictionary<char, int>();

        foreach (char c in s)
        {
            charCount.TryGetValue(c, out int count);
            charCount[c] = count + 1;
        }

        foreach (char c in t)
        {
            if (!charCount.ContainsKey(c) || charCount[c] == 0)
            {
                return false;
            }

            charCount[c]--;
        }

        foreach (var count in charCount.Values)
        {
            if (count != 0) return false;
        }


        return false;
    }

    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 1.4: Valid Anagram ===");

        // Test Case 1: Valid anagram
        string test1_s = "anagram";
        string test1_t = "nagaram";
        bool result1 = Solution(test1_s, test1_t);
        Console.WriteLine($"Test 1 - Input: s = \"{test1_s}\", t = \"{test1_t}\"");
        Console.WriteLine($"         Output: {result1}, Expected: True");
        Console.WriteLine($"         {(result1 == true ? "✓ PASSED" : "✗ FAILED")}\n");

        // Test Case 2: Not an anagram
        string test2_s = "rat";
        string test2_t = "car";
        bool result2 = Solution(test2_s, test2_t);
        Console.WriteLine($"Test 2 - Input: s = \"{test2_s}\", t = \"{test2_t}\"");
        Console.WriteLine($"         Output: {result2}, Expected: False");
        Console.WriteLine($"         {(result2 == false ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

