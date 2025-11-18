using System;

namespace DSA._19_8_DistinctSubsequences_Hard;

/// <summary>
/// Problem 19.8 (Hard): Distinct Subsequences
/// Given two strings s and t, return the number of distinct subsequences of s which equals t.
/// 
/// A subsequence of a string is a new string which is formed from the original string by deleting
/// some (can be none) of the characters without disturbing the relative positions of the remaining
/// characters. (i.e., "ACE" is a subsequence of "ABCDE" while "AEC" is not).
/// 
/// Example:
/// Input: s = "rabbbit", t = "rabbit"
/// Output: 3
/// Explanation:
/// As shown below, there are 3 ways you can generate "rabbit" from s.
/// rabbbit
/// rabbbit
/// rabbbit
/// 
/// Constraints:
/// - 1 <= s.length, t.length <= 1000
/// - s and t consist of English letters.
/// </summary>
public class DistinctSubsequences
{
    public static int NumDistinct(string s, string t)
    {
        // TODO: Implement solution
        // Hint: DP[i][j] = number of ways to form t[0..j-1] from s[0..i-1]
        // If s[i-1] == t[j-1]: DP[i][j] = DP[i-1][j-1] + DP[i-1][j]
        // Else: DP[i][j] = DP[i-1][j]
        // Time Complexity: O(m * n)
        // Space Complexity: O(m * n) or O(n) optimized
        
        return 0;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 19.8: Distinct Subsequences ===");
        
        int result1 = NumDistinct("rabbbit", "rabbit");
        Console.WriteLine($"Test 1 - Input: s = \"rabbbit\", t = \"rabbit\"");
        Console.WriteLine($"         Output: {result1}, Expected: 3");
        Console.WriteLine($"         {(result1 == 3 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int result2 = NumDistinct("babgbag", "bag");
        Console.WriteLine($"Test 2 - Input: s = \"babgbag\", t = \"bag\"");
        Console.WriteLine($"         Output: {result2}, Expected: 5");
        Console.WriteLine($"         {(result2 == 5 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

