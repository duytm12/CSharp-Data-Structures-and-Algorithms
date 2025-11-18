using System;

namespace DSA._19_11_RegularExpressionMatching_Hard;

/// <summary>
/// Problem 19.11 (Hard): Regular Expression Matching
/// Given an input string s and a pattern p, implement regular expression matching with support
/// for '.' and '*' where:
/// - '.' Matches any single character.
/// - '*' Matches zero or more of the preceding element.
/// 
/// The matching should cover the entire input string (not partial).
/// 
/// Example:
/// Input: s = "aa", p = "a"
/// Output: false
/// Explanation: "a" does not match the entire string "aa".
/// 
/// Example 2:
/// Input: s = "aa", p = "a*"
/// Output: true
/// Explanation: '*' means zero or more of the preceding element, 'a'. Therefore, by repeating 'a' once, it becomes "aa".
/// 
/// Constraints:
/// - 1 <= s.length <= 20
/// - 1 <= p.length <= 20
/// - s contains only lowercase English letters.
/// - p contains only lowercase English letters, '.', and '*'.
/// - It is guaranteed for each appearance of the character '*', there will be a previous valid character to match.
/// </summary>
public class RegularExpressionMatching
{
    public static bool IsMatch(string s, string p)
    {
        // TODO: Implement solution
        // Hint: DP[i][j] = does s[0..i-1] match p[0..j-1]
        // Handle '*' case: match zero or more of preceding character
        // Handle '.' case: matches any character
        // Time Complexity: O(m * n)
        // Space Complexity: O(m * n) or O(n) optimized
        
        return false;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 19.11: Regular Expression Matching ===");
        
        bool result1 = IsMatch("aa", "a");
        Console.WriteLine($"Test 1 - Input: s = \"aa\", p = \"a\"");
        Console.WriteLine($"         Output: {result1}, Expected: False");
        Console.WriteLine($"         {(result1 == false ? "✓ PASSED" : "✗ FAILED")}\n");
        
        bool result2 = IsMatch("aa", "a*");
        Console.WriteLine($"Test 2 - Input: s = \"aa\", p = \"a*\"");
        Console.WriteLine($"         Output: {result2}, Expected: True");
        Console.WriteLine($"         {(result2 == true ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

