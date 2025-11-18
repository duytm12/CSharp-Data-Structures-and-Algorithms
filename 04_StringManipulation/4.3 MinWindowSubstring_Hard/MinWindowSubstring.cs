using System;
using System.Collections.Generic;

namespace DSA._4_3_MinWindowSubstring_Hard;

/// <summary>
/// Problem 4.3 (Hard): Minimum Window Substring
/// Given two strings s and t of lengths m and n respectively, return the minimum window substring
/// of s such that every character in t (including duplicates) is included in the window.
/// If there is no such substring, return the empty string "".
/// 
/// Example:
/// Input: s = "ADOBECODEBANC", t = "ABC"
/// Output: "BANC"
/// Explanation: The minimum window substring "BANC" includes 'A', 'B', and 'C' from string t.
/// 
/// Constraints:
/// - m == s.length
/// - n == t.length
/// - 1 <= m, n <= 10^5
/// - s and t consist of uppercase and lowercase English letters.
/// </summary>
public class MinWindowSubstring
{
    public static string Solution(string s, string t)
    {
        // TODO: Implement solution
        // Hint: Sliding window with character frequency tracking
        // Time Complexity: O(m + n)
        // Space Complexity: O(m + n)
        
        return string.Empty;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 4.3: Minimum Window Substring ===");
        
        string test1_s = "ADOBECODEBANC";
        string test1_t = "ABC";
        string result1 = Solution(test1_s, test1_t);
        Console.WriteLine($"Test 1 - Input: s = \"{test1_s}\", t = \"{test1_t}\"");
        Console.WriteLine($"         Output: \"{result1}\", Expected: \"BANC\"");
        Console.WriteLine($"         {(result1 == "BANC" ? "✓ PASSED" : "✗ FAILED")}\n");
        
        string test2_s = "a";
        string test2_t = "a";
        string result2 = Solution(test2_s, test2_t);
        Console.WriteLine($"Test 2 - Input: s = \"{test2_s}\", t = \"{test2_t}\"");
        Console.WriteLine($"         Output: \"{result2}\", Expected: \"a\"");
        Console.WriteLine($"         {(result2 == "a" ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

