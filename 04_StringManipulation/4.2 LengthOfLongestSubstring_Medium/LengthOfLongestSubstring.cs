using System;
using System.Collections.Generic;

namespace DSA._4_2_LengthOfLongestSubstring_Medium;

/// <summary>
/// Problem 4.2 (Medium): Longest Substring Without Repeating Characters
/// Given a string s, find the length of the longest substring without repeating characters.
/// 
/// Example:
/// Input: s = "abcabcbb"
/// Output: 3
/// Explanation: The answer is "abc", with the length of 3.
/// 
/// Constraints:
/// - 0 <= s.length <= 5 * 10^4
/// - s consists of English letters, digits, symbols and spaces.
/// </summary>
public class LengthOfLongestSubstring
{
    public static int Solution(string s)
    {
        // TODO: Implement solution
        // Hint: Use sliding window with HashSet or Dictionary
        // Time Complexity: O(n)
        // Space Complexity: O(min(n, m)) where m is charset size
        
        return 0;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 4.2: Length of Longest Substring ===");
        
        string test1 = "abcabcbb";
        int result1 = Solution(test1);
        Console.WriteLine($"Test 1 - Input: \"abcabcbb\"");
        Console.WriteLine($"         Output: {result1}, Expected: 3");
        Console.WriteLine($"         {(result1 == 3 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        string test2 = "bbbbb";
        int result2 = Solution(test2);
        Console.WriteLine($"Test 2 - Input: \"bbbbb\"");
        Console.WriteLine($"         Output: {result2}, Expected: 1");
        Console.WriteLine($"         {(result2 == 1 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

