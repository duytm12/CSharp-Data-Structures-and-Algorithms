using System;

namespace DSA._9_2_Pow_Medium;

/// <summary>
/// Problem 9.2 (Medium): Pow(x, n)
/// Implement pow(x, n), which calculates x raised to the power n.
/// 
/// Example:
/// Input: x = 2.00000, n = 10
/// Output: 1024.00000
/// </summary>
public class Pow
{
    public static double Solution(double x, int n)
    {
        // TODO: Implement solution
        // Hint: Use divide and conquer: x^n = (x^(n/2))^2
        // Time Complexity: O(log n)
        // Space Complexity: O(log n) recursive, O(1) iterative
        
        return 0.0;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 9.2: Pow ===");
        
        double result1 = Solution(2.0, 10);
        Console.WriteLine($"Test 1 - Input: x = 2.0, n = 10");
        Console.WriteLine($"         Output: {result1:F5}, Expected: 1024.00000");
        Console.WriteLine($"         {(Math.Abs(result1 - 1024.0) < 0.00001 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        double result2 = Solution(2.1, 3);
        Console.WriteLine($"Test 2 - Input: x = 2.1, n = 3");
        Console.WriteLine($"         Output: {result2:F5}, Expected: 9.26100");
        Console.WriteLine($"         {(Math.Abs(result2 - 9.261) < 0.00001 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

