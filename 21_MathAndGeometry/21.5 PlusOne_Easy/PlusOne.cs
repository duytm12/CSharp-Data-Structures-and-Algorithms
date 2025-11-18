using System;

namespace DSA._21_5_PlusOne_Easy;

/// <summary>
/// Problem 21.5 (Easy): Plus One
/// You are given a large integer represented as an integer array digits, where each digits[i]
/// is the ith digit of the integer. The digits are ordered from most significant to least
/// significant in left-to-right order. The large integer does not contain any leading zeros.
/// 
/// Increment the large integer by one and return the resulting array of digits.
/// 
/// Example:
/// Input: digits = [1,2,3]
/// Output: [1,2,4]
/// Explanation: The array represents the integer 123. Incrementing by one gives 123 + 1 = 124.
/// 
/// Constraints:
/// - 1 <= digits.length <= 100
/// - 0 <= digits[i] <= 9
/// - digits does not contain any leading zeros.
/// </summary>
public class PlusOne
{
    public static int[] Solution(int[] digits)
    {
        // TODO: Implement solution
        // Hint: Start from right, add 1, handle carry
        // If all digits are 9, need to resize array
        // Time Complexity: O(n)
        // Space Complexity: O(1) or O(n) if resize needed
        
        return new int[0];
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 21.5: Plus One ===");
        
        int[] test1 = { 1, 2, 3 };
        var result1 = Solution(test1);
        Console.WriteLine($"Test 1 - Input: [1,2,3]");
        Console.WriteLine($"         Output: [{string.Join(",", result1)}], Expected: [1,2,4]");
        bool passed1 = result1.Length == 3 && result1[0] == 1 && result1[2] == 4;
        Console.WriteLine($"         {(passed1 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[] test2 = { 9 };
        var result2 = Solution(test2);
        Console.WriteLine($"Test 2 - Input: [9]");
        Console.WriteLine($"         Output: [{string.Join(",", result2)}], Expected: [1,0]");
        bool passed2 = result2.Length == 2 && result2[0] == 1 && result2[1] == 0;
        Console.WriteLine($"         {(passed2 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

