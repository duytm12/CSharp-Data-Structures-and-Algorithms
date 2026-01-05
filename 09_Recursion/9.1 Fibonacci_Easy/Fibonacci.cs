using System;

namespace DSA._9_1_Fibonacci_Easy;

/// <summary>
/// Problem 9.1 (Easy): Fibonacci Number
/// The Fibonacci numbers form a sequence where each number is the sum of the two preceding ones.
/// Calculate the nth Fibonacci number.
/// 
/// Example:
/// Input: n = 4
/// Output: 3 (F(4) = F(3) + F(2) = 2 + 1 = 3)
/// </summary>
public class Fibonacci
{
    public static int Solution(int n)
    {
        // TODO: Implement solution
        // Hint: Base cases: F(0) = 0, F(1) = 1
        // Time Complexity: O(n) iterative, O(2^n) naive recursive
        // Space Complexity: O(1) iterative, O(n) recursive

        // Solution 1: Iteration
        



        // Solution 2: Recursion

        return 0;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 9.1: Fibonacci ===");
        
        int result1 = Solution(4);
        Console.WriteLine($"Test 1 - Input: n = 4");
        Console.WriteLine($"         Output: {result1}, Expected: 3");
        Console.WriteLine($"         {(result1 == 3 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int result2 = Solution(2);
        Console.WriteLine($"Test 2 - Input: n = 2");
        Console.WriteLine($"         Output: {result2}, Expected: 1");
        Console.WriteLine($"         {(result2 == 1 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

