using System;

namespace DSA._20_6_SumOfTwoIntegers_Medium;

/// <summary>
/// Problem 20.6 (Medium): Sum of Two Integers
/// Given two integers a and b, return the sum of the two integers without using the operators + and -.
/// 
/// Example:
/// Input: a = 1, b = 2
/// Output: 3
/// 
/// Constraints:
/// - -1000 <= a, b <= 1000
/// </summary>
public class SumOfTwoIntegers
{
    public static int GetSum(int a, int b)
    {
        // TODO: Implement solution
        // Hint: Use bitwise operations
        // sum = a ^ b (XOR gives sum without carry)
        // carry = (a & b) << 1 (AND gives carry bits, shift left)
        // Repeat until carry is 0
        // Time Complexity: O(1) - at most 32 iterations
        // Space Complexity: O(1)
        
        return 0;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 20.6: Sum of Two Integers ===");
        
        int result1 = GetSum(1, 2);
        Console.WriteLine($"Test 1 - Input: a = 1, b = 2");
        Console.WriteLine($"         Output: {result1}, Expected: 3");
        Console.WriteLine($"         {(result1 == 3 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int result2 = GetSum(2, 3);
        Console.WriteLine($"Test 2 - Input: a = 2, b = 3");
        Console.WriteLine($"         Output: {result2}, Expected: 5");
        Console.WriteLine($"         {(result2 == 5 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

