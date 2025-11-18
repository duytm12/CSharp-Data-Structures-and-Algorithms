using System;

namespace DSA._21_6_PowXN_Medium;

/// <summary>
/// Problem 21.6 (Medium): Pow(x, n)
/// Implement pow(x, n), which calculates x raised to the power n (i.e., x^n).
/// 
/// Example:
/// Input: x = 2.00000, n = 10
/// Output: 1024.00000
/// 
/// Example 2:
/// Input: x = 2.10000, n = 3
/// Output: 9.26100
/// 
/// Example 3:
/// Input: x = 2.00000, n = -2
/// Output: 0.25000
/// Explanation: 2^-2 = 1/2^2 = 1/4 = 0.25
/// 
/// Constraints:
/// - -100.0 < x < 100.0
/// - -2^31 <= n <= 2^31-1
/// - n is an integer.
/// - Either x is not zero or n > 0.
/// - -10^4 <= x^n <= 10^4
/// </summary>
public class PowXN
{
    public static double MyPow(double x, int n)
    {
        // TODO: Implement solution
        // Hint: Fast exponentiation using binary representation
        // If n is even: x^n = (x^(n/2))^2
        // If n is odd: x^n = x * (x^(n/2))^2
        // Handle negative n: x^(-n) = 1 / x^n
        // Time Complexity: O(log n)
        // Space Complexity: O(1)
        
        return 0.0;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 21.6: Pow(x, n) ===");
        
        double result1 = MyPow(2.0, 10);
        Console.WriteLine($"Test 1 - Input: x = 2.0, n = 10");
        Console.WriteLine($"         Output: {result1:F5}, Expected: 1024.00000");
        Console.WriteLine($"         {(Math.Abs(result1 - 1024.0) < 0.00001 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        double result2 = MyPow(2.1, 3);
        Console.WriteLine($"Test 2 - Input: x = 2.1, n = 3");
        Console.WriteLine($"         Output: {result2:F5}, Expected: 9.26100");
        Console.WriteLine($"         {(Math.Abs(result2 - 9.261) < 0.00001 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

