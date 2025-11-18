using System;

namespace DSA._15_9_ValidParenthesisString_Medium;

/// <summary>
/// Problem 15.9 (Medium): Valid Parenthesis String
/// Given a string s containing only three types of characters: '(', ')' and '*', return true
/// if s is valid.
/// 
/// The following rules define a valid string:
/// - Any left parenthesis '(' must have a corresponding right parenthesis ')'.
/// - Any right parenthesis ')' must have a corresponding left parenthesis '('.
/// - Left parenthesis '(' must go before the corresponding right parenthesis ')'.
/// - '*' could be treated as a single right parenthesis ')' or a single left parenthesis '(' or an empty string "".
/// 
/// Example:
/// Input: s = "()"
/// Output: true
/// 
/// Example 2:
/// Input: s = "(*)"
/// Output: true
/// 
/// Constraints:
/// - 1 <= s.length <= 100
/// - s[i] is '(', ')' or '*'.
/// </summary>
public class ValidParenthesisString
{
    public static bool CheckValidString(string s)
    {
        // TODO: Implement solution
        // Hint: Greedy - track min and max possible open parentheses
        // '*' can be '(', ')', or '' - adjust range accordingly
        // Time Complexity: O(n)
        // Space Complexity: O(1)
        
        return false;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 15.9: Valid Parenthesis String ===");
        
        bool result1 = CheckValidString("()");
        Console.WriteLine($"Test 1 - Input: \"()\"");
        Console.WriteLine($"         Output: {result1}, Expected: True");
        Console.WriteLine($"         {(result1 == true ? "✓ PASSED" : "✗ FAILED")}\n");
        
        bool result2 = CheckValidString("(*)");
        Console.WriteLine($"Test 2 - Input: \"(*)\"");
        Console.WriteLine($"         Output: {result2}, Expected: True");
        Console.WriteLine($"         {(result2 == true ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

