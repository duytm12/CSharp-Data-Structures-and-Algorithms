using System;

namespace DSA._20_7_ReverseInteger_Medium;

/// <summary>
/// Problem 20.7 (Medium): Reverse Integer
/// Given a signed 32-bit integer x, return x with its digits reversed. If reversing x causes
/// the value to go outside the signed 32-bit integer range [-2^31, 2^31 - 1], then return 0.
/// 
/// Assume the environment does not allow you to store 64-bit integers (signed or unsigned).
/// 
/// Example:
/// Input: x = 123
/// Output: 321
/// 
/// Example 2:
/// Input: x = -123
/// Output: -321
/// 
/// Constraints:
/// - -2^31 <= x <= 2^31 - 1
/// </summary>
public class ReverseInteger
{
    public static int Reverse(int x)
    {
        // TODO: Implement solution
        // Hint: Extract digits using modulo and division
        // Check for overflow before multiplying by 10
        // Use int.MaxValue / 10 and int.MinValue / 10 to check bounds
        // Time Complexity: O(log10(x))
        // Space Complexity: O(1)
        
        return 0;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 20.7: Reverse Integer ===");
        
        int result1 = Reverse(123);
        Console.WriteLine($"Test 1 - Input: x = 123");
        Console.WriteLine($"         Output: {result1}, Expected: 321");
        Console.WriteLine($"         {(result1 == 321 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int result2 = Reverse(-123);
        Console.WriteLine($"Test 2 - Input: x = -123");
        Console.WriteLine($"         Output: {result2}, Expected: -321");
        Console.WriteLine($"         {(result2 == -321 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

