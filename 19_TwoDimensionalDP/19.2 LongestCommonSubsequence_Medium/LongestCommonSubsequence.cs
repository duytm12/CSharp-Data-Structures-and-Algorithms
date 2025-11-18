using System;

namespace DSA._19_2_LongestCommonSubsequence_Medium;

/// <summary>
/// Problem 19.2 (Medium): Longest Common Subsequence
/// Given two strings text1 and text2, return the length of their longest common subsequence.
/// If there is no common subsequence, return 0.
/// 
/// A subsequence of a string is a new string generated from the original string with some
/// characters (can be none) deleted without changing the relative order of the remaining characters.
/// 
/// Example:
/// Input: text1 = "abcde", text2 = "ace"
/// Output: 3
/// Explanation: The longest common subsequence is "ace" and its length is 3.
/// 
/// Constraints:
/// - 1 <= text1.length, text2.length <= 1000
/// - text1 and text2 consist of only lowercase English characters.
/// </summary>
public class LongestCommonSubsequence
{
    public static int Solution(string text1, string text2)
    {
        // TODO: Implement solution
        // Hint: DP[i][j] = LCS of text1[0..i] and text2[0..j]
        // If text1[i] == text2[j]: DP[i][j] = DP[i-1][j-1] + 1
        // Else: DP[i][j] = max(DP[i-1][j], DP[i][j-1])
        // Time Complexity: O(m * n)
        // Space Complexity: O(m * n) or O(min(m,n)) optimized
        
        return 0;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 19.2: Longest Common Subsequence ===");
        
        int result1 = Solution("abcde", "ace");
        Console.WriteLine($"Test 1 - Input: text1 = \"abcde\", text2 = \"ace\"");
        Console.WriteLine($"         Output: {result1}, Expected: 3");
        Console.WriteLine($"         {(result1 == 3 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int result2 = Solution("abc", "abc");
        Console.WriteLine($"Test 2 - Input: text1 = \"abc\", text2 = \"abc\"");
        Console.WriteLine($"         Output: {result2}, Expected: 3");
        Console.WriteLine($"         {(result2 == 3 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}
