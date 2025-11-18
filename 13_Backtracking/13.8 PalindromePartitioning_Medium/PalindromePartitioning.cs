using System;
using System.Collections.Generic;

namespace DSA._13_8_PalindromePartitioning_Medium;

/// <summary>
/// Problem 13.8 (Medium): Palindrome Partitioning
/// Given a string s, partition s such that every substring of the partition is a palindrome.
/// Return all possible palindrome partitioning of s.
/// 
/// Example:
/// Input: s = "aab"
/// Output: [["a","a","b"],["aa","b"]]
/// 
/// Constraints:
/// - 1 <= s.length <= 16
/// - s contains only lowercase English letters.
/// </summary>
public class PalindromePartitioning
{
    public static IList<IList<string>> Solution(string s)
    {
        // TODO: Implement solution
        // Hint: Backtrack, check if substring is palindrome before adding
        // Try all possible partitions
        // Time Complexity: O(2^n * n)
        // Space Complexity: O(n)
        
        return new List<IList<string>>();
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 13.8: Palindrome Partitioning ===");
        
        var result1 = Solution("aab");
        Console.WriteLine($"Test 1 - Input: \"aab\"");
        Console.WriteLine($"         Output: {result1.Count} partitions, Expected: 2");
        Console.WriteLine($"         {(result1.Count == 2 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        var result2 = Solution("a");
        Console.WriteLine($"Test 2 - Input: \"a\"");
        Console.WriteLine($"         Output: {result2.Count} partitions, Expected: 1");
        Console.WriteLine($"         {(result2.Count == 1 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

