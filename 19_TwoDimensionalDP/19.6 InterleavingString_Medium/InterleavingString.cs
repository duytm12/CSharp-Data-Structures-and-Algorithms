using System;

namespace DSA._19_6_InterleavingString_Medium;

/// <summary>
/// Problem 19.6 (Medium): Interleaving String
/// Given strings s1, s2, and s3, find whether s3 is formed by an interleaving of s1 and s2.
/// 
/// An interleaving of two strings s and t is a configuration where s and t are divided into
/// n and m non-empty substrings respectively, such that:
/// - s = s1 + s2 + ... + sn
/// - t = t1 + t2 + ... + tm
/// - |n - m| <= 1
/// - The interleaving is s1 + t1 + s2 + t2 + ... or t1 + s1 + t2 + s2 + ...
/// 
/// Example:
/// Input: s1 = "aabcc", s2 = "dbbca", s3 = "aadbbcbcac"
/// Output: true
/// Explanation: One possible interleaving is shown.
/// 
/// Constraints:
/// - 0 <= s1.length, s2.length <= 100
/// - 0 <= s3.length <= 200
/// - s1, s2, and s3 consist of lowercase English letters.
/// </summary>
public class InterleavingString
{
    public static bool IsInterleave(string s1, string s2, string s3)
    {
        // TODO: Implement solution
        // Hint: DP[i][j] = can s3[0..i+j-1] be formed by interleaving s1[0..i-1] and s2[0..j-1]
        // DP[i][j] = (DP[i-1][j] && s1[i-1] == s3[i+j-1]) || (DP[i][j-1] && s2[j-1] == s3[i+j-1])
        // Time Complexity: O(m * n)
        // Space Complexity: O(m * n) or O(min(m,n)) optimized
        
        return false;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 19.6: Interleaving String ===");
        
        bool result1 = IsInterleave("aabcc", "dbbca", "aadbbcbcac");
        Console.WriteLine($"Test 1 - Input: s1 = \"aabcc\", s2 = \"dbbca\", s3 = \"aadbbcbcac\"");
        Console.WriteLine($"         Output: {result1}, Expected: True");
        Console.WriteLine($"         {(result1 == true ? "✓ PASSED" : "✗ FAILED")}\n");
        
        bool result2 = IsInterleave("aabcc", "dbbca", "aadbbbaccc");
        Console.WriteLine($"Test 2 - Input: s1 = \"aabcc\", s2 = \"dbbca\", s3 = \"aadbbbaccc\"");
        Console.WriteLine($"         Output: {result2}, Expected: False");
        Console.WriteLine($"         {(result2 == false ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

