using System;
using System.Collections.Generic;

namespace DSA._13_7_GenerateParentheses_Medium;

/// <summary>
/// Problem 13.7 (Medium): Generate Parentheses
/// Given n pairs of parentheses, write a function to generate all combinations of well-formed parentheses.
/// 
/// Example:
/// Input: n = 3
/// Output: ["((()))","(()())","(())()","()(())","()()()"]
/// 
/// Constraints:
/// - 1 <= n <= 8
/// </summary>
public class GenerateParentheses
{
    public static IList<string> Solution(int n)
    {
        // TODO: Implement solution
        // Hint: Backtrack, track open and close counts
        // Add '(' if open < n, add ')' if close < open
        // Time Complexity: O(4^n / sqrt(n))
        // Space Complexity: O(4^n / sqrt(n))
        
        return new List<string>();
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 13.7: Generate Parentheses ===");
        
        var result1 = Solution(3);
        Console.WriteLine($"Test 1 - Input: n = 3");
        Console.WriteLine($"         Output: {result1.Count} combinations, Expected: 5");
        Console.WriteLine($"         {(result1.Count == 5 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        var result2 = Solution(1);
        Console.WriteLine($"Test 2 - Input: n = 1");
        Console.WriteLine($"         Output: [{string.Join(",", result2)}], Expected: [\"()\"]");
        Console.WriteLine($"         {(result2.Count == 1 && result2[0] == "()" ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

