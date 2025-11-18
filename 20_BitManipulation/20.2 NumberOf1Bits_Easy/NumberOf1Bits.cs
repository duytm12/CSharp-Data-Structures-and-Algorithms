using System;

namespace DSA._20_2_NumberOf1Bits_Easy;

/// <summary>
/// Problem 20.2 (Easy): Number of 1 Bits
/// Write a function that takes the binary representation of an unsigned integer and returns
/// the number of '1' bits it has (also known as the Hamming weight).
/// 
/// Example:
/// Input: n = 00000000000000000000000000001011
/// Output: 3
/// Explanation: The input binary string 00000000000000000000000000001011 has a total of three '1' bits.
/// 
/// Constraints:
/// - The input must be a binary string of length 32.
/// </summary>
public class NumberOf1Bits
{
    public static int Solution(uint n)
    {
        // TODO: Implement solution
        // Hint: Use n & (n - 1) to remove the rightmost 1 bit
        // Or count bits by shifting: count += n & 1; n >>= 1;
        // Time Complexity: O(1) - at most 32 iterations
        // Space Complexity: O(1)
        
        return 0;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 20.2: Number of 1 Bits ===");
        
        uint test1 = 0b00000000000000000000000000001011;
        int result1 = Solution(test1);
        Console.WriteLine($"Test 1 - Input: n = 11 (binary: 1011)");
        Console.WriteLine($"         Output: {result1}, Expected: 3");
        Console.WriteLine($"         {(result1 == 3 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        uint test2 = 0b00000000000000000000000010000000;
        int result2 = Solution(test2);
        Console.WriteLine($"Test 2 - Input: n = 128 (binary: 10000000)");
        Console.WriteLine($"         Output: {result2}, Expected: 1");
        Console.WriteLine($"         {(result2 == 1 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

