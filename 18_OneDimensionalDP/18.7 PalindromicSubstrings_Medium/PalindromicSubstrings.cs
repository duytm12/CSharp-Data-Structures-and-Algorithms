using System;

namespace DSA._18_7_PalindromicSubstrings_Medium;

/// <summary>
/// Problem 18.7 (Medium): Palindromic Substrings
/// Given a string s, return the number of palindromic substrings in it.
/// 
/// A string is a palindrome when it reads the same backward as forward.
/// A substring is a contiguous sequence of characters within the string.
/// 
/// Example:
/// Input: s = "abc"
/// Output: 3
/// Explanation: Three palindromic strings: "a", "b", "c".
/// 
/// Example 2:
/// Input: s = "aaa"
/// Output: 6
/// Explanation: Six palindromic strings: "a", "a", "a", "aa", "aa", "aaa".
/// 
/// Constraints:
/// - 1 <= s.length <= 1000
/// - s consists of lowercase English letters.
/// </summary>
public class PalindromicSubstrings
{
    public static int CountSubstrings(string s)
    {
        // TODO: Implement solution
        // Hint: Expand around centers, count palindromes for each center
        // Time Complexity: O(n^2)
        // Space Complexity: O(1)
        
        return 0;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 18.7: Palindromic Substrings ===");
        
        int result1 = CountSubstrings("abc");
        Console.WriteLine($"Test 1 - Input: \"abc\"");
        Console.WriteLine($"         Output: {result1}, Expected: 3");
        Console.WriteLine($"         {(result1 == 3 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int result2 = CountSubstrings("aaa");
        Console.WriteLine($"Test 2 - Input: \"aaa\"");
        Console.WriteLine($"         Output: {result2}, Expected: 6");
        Console.WriteLine($"         {(result2 == 6 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

