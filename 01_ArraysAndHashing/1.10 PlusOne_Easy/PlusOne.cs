using System;

namespace DSA._1_10_PlusOne_Easy;

/// <summary>
/// Problem 1.10 (Easy): Plus One
/// You are given a large integer represented as an integer array digits, where each digits[i]
/// is the ith digit of the integer. The digits are ordered from most significant to least
/// significant in left-to-right order. The large integer does not contain any leading zeros.
/// 
/// Increment the large integer by one and return the resulting array of digits.
/// 
/// Example 1:
/// Input: digits = [1,2,3]
/// Output: [1,2,4]
/// Explanation: The array represents the integer 123. Incrementing by one gives 123 + 1 = 124.
/// Thus, the result should be [1,2,4].
/// 
/// Example 2:
/// Input: digits = [4,3,2,1]
/// Output: [4,3,2,2]
/// Explanation: The array represents the integer 4321. Incrementing by one gives 4321 + 1 = 4322.
/// Thus, the result should be [4,3,2,2].
/// 
/// Example 3:
/// Input: digits = [9]
/// Output: [1,0]
/// Explanation: The array represents the integer 9. Incrementing by one gives 9 + 1 = 10.
/// Thus, the result should be [1,0].
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
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            digits[i]++;
            if (digits[i] < 10) return digits;
            else digits[i] = 0;
        }
        return [1, .. digits];
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 1.10: Plus One ===");
        
        // Test Case 1: Basic example
        int[] test1 = { 1, 2, 3 };
        var result1 = Solution(test1);
        Console.WriteLine($"Test 1 - Input: [1,2,3]");
        Console.WriteLine($"         Output: [{string.Join(",", result1)}], Expected: [1,2,4]");
        bool passed1 = result1.Length == 3 && result1[0] == 1 && result1[1] == 2 && result1[2] == 4;
        Console.WriteLine($"         {(passed1 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        // Test Case 2: Another example
        int[] test2 = { 4, 3, 2, 1 };
        var result2 = Solution(test2);
        Console.WriteLine($"Test 2 - Input: [4,3,2,1]");
        Console.WriteLine($"         Output: [{string.Join(",", result2)}], Expected: [4,3,2,2]");
        bool passed2 = result2.Length == 4 && result2[0] == 4 && result2[1] == 3 && 
                       result2[2] == 2 && result2[3] == 2;
        Console.WriteLine($"         {(passed2 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        // Test Case 3: All 9s (requires array resize)
        int[] test3 = { 9 };
        var result3 = Solution(test3);
        Console.WriteLine($"Test 3 - Input: [9]");
        Console.WriteLine($"         Output: [{string.Join(",", result3)}], Expected: [1,0]");
        bool passed3 = result3.Length == 2 && result3[0] == 1 && result3[1] == 0;
        Console.WriteLine($"         {(passed3 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

