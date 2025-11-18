using System;
using System.Collections.Generic;

namespace DSA._21_4_HappyNumber_Easy;

/// <summary>
/// Problem 21.4 (Easy): Happy Number
/// Write an algorithm to determine if a number n is happy.
/// 
/// A happy number is a number defined by the following process:
/// - Starting with any positive integer, replace the number by the sum of the squares of its digits.
/// - Repeat the process until the number equals 1 (where it will stay), or it loops endlessly
///   in a cycle which does not include 1.
/// - Those numbers for which this process ends in 1 are happy.
/// 
/// Return true if n is a happy number, and false if not.
/// 
/// Example:
/// Input: n = 19
/// Output: true
/// Explanation:
/// 1^2 + 9^2 = 82
/// 8^2 + 2^2 = 68
/// 6^2 + 8^2 = 100
/// 1^2 + 0^2 + 0^2 = 1
/// 
/// Constraints:
/// - 1 <= n <= 2^31 - 1
/// </summary>
public class HappyNumber
{
    public static bool IsHappy(int n)
    {
        // TODO: Implement solution
        // Hint: Use HashSet to detect cycles, or Floyd's cycle detection
        // Extract digits, square and sum them
        // Time Complexity: O(log n) per iteration
        // Space Complexity: O(log n) with HashSet, O(1) with Floyd's
        
        return false;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 21.4: Happy Number ===");
        
        bool result1 = IsHappy(19);
        Console.WriteLine($"Test 1 - Input: n = 19");
        Console.WriteLine($"         Output: {result1}, Expected: True");
        Console.WriteLine($"         {(result1 == true ? "✓ PASSED" : "✗ FAILED")}\n");
        
        bool result2 = IsHappy(2);
        Console.WriteLine($"Test 2 - Input: n = 2");
        Console.WriteLine($"         Output: {result2}, Expected: False");
        Console.WriteLine($"         {(result2 == false ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}
