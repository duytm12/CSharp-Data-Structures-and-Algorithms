using System;

namespace DSA._20_4_ReverseBits_Easy;

/// <summary>
/// Problem 20.4 (Easy): Reverse Bits
/// Reverse bits of a given 32 bits unsigned integer.
/// 
/// Example:
/// Input: n = 00000010100101000001111010011100
/// Output: 964176192 (00111001011110000010100101000000)
/// Explanation: The input binary string 00000010100101000001111010011100 represents the unsigned
/// integer 43261596, so return 964176192 which its binary representation is 00111001011110000010100101000000.
/// 
/// Constraints:
/// - The input must be a binary string of length 32
/// </summary>
public class ReverseBits
{
    public static uint Solution(uint n)
    {
        // TODO: Implement solution
        // Hint: Extract bits from right to left, build result from left to right
        // result = (result << 1) | (n & 1); n >>= 1;
        // Time Complexity: O(1) - exactly 32 iterations
        // Space Complexity: O(1)
        
        return 0;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 20.4: Reverse Bits ===");
        
        uint test1 = 0b00000010100101000001111010011100;
        uint result1 = Solution(test1);
        Console.WriteLine($"Test 1 - Input: n = 43261596");
        Console.WriteLine($"         Output: {result1}, Expected: 964176192");
        Console.WriteLine($"         {(result1 == 964176192 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        uint test2 = 0b11111111111111111111111111111101;
        uint result2 = Solution(test2);
        Console.WriteLine($"Test 2 - Input: n = 4294967293");
        Console.WriteLine($"         Output: {result2}");
        bool passed2 = result2 > 0;
        Console.WriteLine($"         {(passed2 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

