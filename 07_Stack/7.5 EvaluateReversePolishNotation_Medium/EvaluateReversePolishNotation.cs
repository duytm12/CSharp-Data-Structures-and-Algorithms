using System;
using System.Collections.Generic;

namespace DSA._7_5_EvaluateReversePolishNotation_Medium;

/// <summary>
/// Problem 7.5 (Medium): Evaluate Reverse Polish Notation
/// You are given an array of strings tokens that represents an arithmetic expression
/// in Reverse Polish Notation (RPN). Evaluate the expression and return an integer.
/// 
/// Valid operators are '+', '-', '*', and '/'. Each operand may be an integer or another expression.
/// Note that division between two integers should truncate toward zero.
/// 
/// Example:
/// Input: tokens = ["2","1","+","3","*"]
/// Output: 9
/// Explanation: ((2 + 1) * 3) = 9
/// 
/// Example 2:
/// Input: tokens = ["4","13","5","/","+"]
/// Output: 6
/// Explanation: (4 + (13 / 5)) = 6
/// 
/// Constraints:
/// - 1 <= tokens.length <= 10^4
/// - tokens[i] is either an operator: "+", "-", "*", or "/", or an integer in the range [-200, 200].
/// </summary>
public class EvaluateReversePolishNotation
{
    public static int EvalRPN(string[] tokens)
    {
        // TODO: Implement solution
        // Hint: Use Stack to store operands, when operator encountered, pop two operands, compute, push result
        // Time Complexity: O(n)
        // Space Complexity: O(n)
        
        return 0;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 7.5: Evaluate Reverse Polish Notation ===");
        
        string[] test1 = { "2", "1", "+", "3", "*" };
        int result1 = EvalRPN(test1);
        Console.WriteLine($"Test 1 - Input: [\"2\",\"1\",\"+\",\"3\",\"*\"]");
        Console.WriteLine($"         Output: {result1}, Expected: 9");
        Console.WriteLine($"         {(result1 == 9 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        string[] test2 = { "4", "13", "5", "/", "+" };
        int result2 = EvalRPN(test2);
        Console.WriteLine($"Test 2 - Input: [\"4\",\"13\",\"5\",\"/\",\"+\"]");
        Console.WriteLine($"         Output: {result2}, Expected: 6");
        Console.WriteLine($"         {(result2 == 6 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

