using System;

namespace DSA._18_6_LongestPalindromicSubstring_Medium;

/// <summary>
/// Problem 18.6 (Medium): Longest Palindromic Substring
/// Given a string s, return the longest palindromic substring in s.
/// 
/// Example:
/// Input: s = "babad"
/// Output: "bab"
/// Explanation: "aba" is also a valid answer.
/// 
/// Constraints:
/// - 1 <= s.length <= 1000
/// - s consist of only digits and English letters.
/// </summary>
public class LongestPalindromicSubstring
{
    public static string LongestPalindrome(string s)
    {
        // TODO: Implement solution
        // Hint: Expand around centers or use DP table
        // DP[i][j] = true if s[i..j] is palindrome
        // Time Complexity: O(n^2)
        // Space Complexity: O(n^2) or O(1) with expand around centers
        
        return string.Empty;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 18.6: Longest Palindromic Substring ===");
        
        string result1 = LongestPalindrome("babad");
        Console.WriteLine($"Test 1 - Input: \"babad\"");
        Console.WriteLine($"         Output: \"{result1}\", Expected: \"bab\" or \"aba\"");
        bool passed1 = result1 == "bab" || result1 == "aba";
        Console.WriteLine($"         {(passed1 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        string result2 = LongestPalindrome("cbbd");
        Console.WriteLine($"Test 2 - Input: \"cbbd\"");
        Console.WriteLine($"         Output: \"{result2}\", Expected: \"bb\"");
        Console.WriteLine($"         {(result2 == "bb" ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

