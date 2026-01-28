using System;
using System.Collections.Generic;

namespace DSA._7_1_ValidParentheses_Easy;

/// <summary>
/// Problem 7.1 (Easy): Valid Parentheses
/// Given a string s containing just the characters '(', ')', '{', '}', '[' and ']',
/// determine if the input string is valid.
/// 
/// Example:
/// Input: s = "()[]{}"
/// Output: true
/// 
/// Constraints:
/// - 1 <= s.length <= 10^4
/// - s consists of parentheses only '()[]{}'.
/// </summary>
public class ValidParentheses
{
    public static bool Solution(string s)
    {
        // TODO: Implement solution
        // Hint: Use Stack to match opening and closing brackets
        // Time Complexity: O(n)
        // Space Complexity: O(n)

        
        
        return false;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 7.1: Valid Parentheses ===");
        
        string test1 = "()[]{}";
        bool result1 = Solution(test1);
        Console.WriteLine($"Test 1 - Input: \"{test1}\"");
        Console.WriteLine($"         Output: {result1}, Expected: True");
        Console.WriteLine($"         {(result1 == true ? "✓ PASSED" : "✗ FAILED")}\n");
        
        string test2 = "(]";
        bool result2 = Solution(test2);
        Console.WriteLine($"Test 2 - Input: \"{test2}\"");
        Console.WriteLine($"         Output: {result2}, Expected: False");
        Console.WriteLine($"         {(result2 == false ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

