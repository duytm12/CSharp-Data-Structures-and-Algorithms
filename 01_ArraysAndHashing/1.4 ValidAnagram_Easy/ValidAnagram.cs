using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
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
        // Solution: Count character frequencies in both strings and compare
        // Time Complexity: O(n) where n is the length of the strings
        // Space Complexity: O(1) - at most 26 characters (lowercase English letters)

        if (s.Length != t.Length) return false;

        var dict = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {
            dict[s[i]] = dict.GetValueOrDefault(s[i], 0) +1;
        }

        for (int i = 0; i < t.Length; i++)
        {
            if (!dict.ContainsKey(t[i])) return false;

            dict[t[i]]--;

            if (dict[t[i]] < 0) return false;
        }

        return dict.Values.All(count => count == 0);
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
        
        // Test Case 3: Same characters rearranged (actual anagram)
        string test3_s = "aacc";
        string test3_t = "ccaa";
        bool result3 = Solution(test3_s, test3_t);
        Console.WriteLine($"Test 3 - Input: s = \"{test3_s}\", t = \"{test3_t}\"");
        Console.WriteLine($"         Output: {result3}, Expected: True (both have 2 a's and 2 c's)");
        Console.WriteLine($"         {(result3 == true ? "✓ PASSED" : "✗ FAILED")}\n");
        
        // Test Case 4: Not anagrams - different character counts
        string test4_s = "aacc";
        string test4_t = "ccac";
        bool result4 = Solution(test4_s, test4_t);
        Console.WriteLine($"Test 4 - Input: s = \"{test4_s}\", t = \"{test4_t}\"");
        Console.WriteLine($"         Output: {result4}, Expected: False (s has 2a+2c, t has 1a+3c)");
        Console.WriteLine($"         {(result4 == false ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

