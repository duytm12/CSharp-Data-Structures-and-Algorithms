using System;
using System.Collections.Generic;

namespace DSA._6_5_PermutationInString_Medium;

/// <summary>
/// Problem 6.5 (Medium): Permutation in String
/// Given two strings s1 and s2, return true if s2 contains a permutation of s1, or false otherwise.
/// In other words, return true if one of s1's permutations is the substring of s2.
/// 
/// Example:
/// Input: s1 = "ab", s2 = "eidbaooo"
/// Output: true
/// Explanation: s2 contains one permutation of s1 ("ba").
/// 
/// Constraints:
/// - 1 <= s1.length, s2.length <= 10^4
/// - s1 and s2 consist of lowercase English letters.
/// </summary>
public class PermutationInString
{
    public static bool CheckInclusion(string s1, string s2)
    {
        // TODO: Implement solution
        // Hint: Sliding window of size s1.length, compare character frequencies
        // Use fixed-size sliding window with frequency map
        // Time Complexity: O(n) where n is s2.length
        // Space Complexity: O(1) - at most 26 characters
        
        return false;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 6.5: Permutation in String ===");
        
        string test1_s1 = "ab";
        string test1_s2 = "eidbaooo";
        bool result1 = CheckInclusion(test1_s1, test1_s2);
        Console.WriteLine($"Test 1 - Input: s1 = \"{test1_s1}\", s2 = \"{test1_s2}\"");
        Console.WriteLine($"         Output: {result1}, Expected: True");
        Console.WriteLine($"         {(result1 == true ? "✓ PASSED" : "✗ FAILED")}\n");
        
        string test2_s1 = "ab";
        string test2_s2 = "eidboaoo";
        bool result2 = CheckInclusion(test2_s1, test2_s2);
        Console.WriteLine($"Test 2 - Input: s1 = \"{test2_s1}\", s2 = \"{test2_s2}\"");
        Console.WriteLine($"         Output: {result2}, Expected: False");
        Console.WriteLine($"         {(result2 == false ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

