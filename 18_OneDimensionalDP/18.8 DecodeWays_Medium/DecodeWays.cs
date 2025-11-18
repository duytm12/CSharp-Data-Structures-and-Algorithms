using System;

namespace DSA._18_8_DecodeWays_Medium;

/// <summary>
/// Problem 18.8 (Medium): Decode Ways
/// A message containing letters from A-Z can be encoded into numbers using the following mapping:
/// 'A' -> "1"
/// 'B' -> "2"
/// ...
/// 'Z' -> "26"
/// 
/// To decode an encoded message, all the digits must be grouped then mapped back into letters using
/// the reverse of the mapping above (there may be multiple ways). For example, "11106" can be mapped into:
/// - "AAJF" with the grouping (1 1 10 6)
/// - "KJF" with the grouping (11 10 6)
/// 
/// Note that the grouping (1 11 06) is invalid because "06" cannot be mapped into 'F' since "6" is different from "06".
/// 
/// Given a string s containing only digits, return the number of ways to decode it.
/// 
/// Example:
/// Input: s = "12"
/// Output: 2
/// Explanation: "12" could be decoded as "AB" (1 2) or "L" (12).
/// 
/// Constraints:
/// - 1 <= s.length <= 100
/// - s contains only digits and may contain leading zero(s).
/// </summary>
public class DecodeWays
{
    public static int NumDecodings(string s)
    {
        // TODO: Implement solution
        // Hint: DP[i] = ways to decode s[0..i]
        // Check if single digit (1-9) or two digits (10-26) are valid
        // Time Complexity: O(n)
        // Space Complexity: O(1)
        
        return 0;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 18.8: Decode Ways ===");
        
        int result1 = NumDecodings("12");
        Console.WriteLine($"Test 1 - Input: \"12\"");
        Console.WriteLine($"         Output: {result1}, Expected: 2");
        Console.WriteLine($"         {(result1 == 2 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int result2 = NumDecodings("226");
        Console.WriteLine($"Test 2 - Input: \"226\"");
        Console.WriteLine($"         Output: {result2}, Expected: 3");
        Console.WriteLine($"         {(result2 == 3 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

