using System;
using System.Collections.Generic;

namespace DSA._6_2_CharacterReplacement_Medium;

/// <summary>
/// Problem 6.2 (Medium): Longest Repeating Character Replacement
/// You are given a string s and an integer k. You can choose any character of the string
/// and change it to any other uppercase English letter. You can perform this operation at most k times.
/// 
/// Return the length of the longest substring containing the same letter you can get after
/// performing the above operations.
/// 
/// Example:
/// Input: s = "ABAB", k = 2
/// Output: 4
/// Explanation: Replace the two 'A's with two 'B's or vice versa.
/// 
/// Constraints:
/// - 1 <= s.length <= 10^5
/// - s consists of only uppercase English letters.
/// - 0 <= k <= s.length
/// </summary>
public class CharacterReplacement
{
    public static int Solution(string s, int k)
    {
        // TODO: Implement solution
        // Hint: Variable-size sliding window with character frequency
        // Time Complexity: O(n)
        // Space Complexity: O(1) - at most 26 characters
        
        return 0;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 6.2: Character Replacement ===");
        
        string test1 = "ABAB";
        int k1 = 2;
        int result1 = Solution(test1, k1);
        Console.WriteLine($"Test 1 - Input: s = \"{test1}\", k = {k1}");
        Console.WriteLine($"         Output: {result1}, Expected: 4");
        Console.WriteLine($"         {(result1 == 4 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        string test2 = "AABABBA";
        int k2 = 1;
        int result2 = Solution(test2, k2);
        Console.WriteLine($"Test 2 - Input: s = \"{test2}\", k = {k2}");
        Console.WriteLine($"         Output: {result2}, Expected: 4");
        Console.WriteLine($"         {(result2 == 4 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

