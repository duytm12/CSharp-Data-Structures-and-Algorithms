using System;
using System.Text;

namespace DSA._4_1_ReverseString_Easy;

/// <summary>
/// Problem 4.1 (Easy): Reverse String
/// Write a function that reverses a string using StringBuilder.
/// 
/// Example:
/// Input: "hello"
/// Output: "olleh"
/// 
/// Constraints:
/// - 1 <= s.length <= 10^5
/// - s[i] is a printable ascii character.
/// </summary>
public class ReverseString
{
    public static string Solution(string s)
    {
        // TODO: Implement solution
        // Hint: Use StringBuilder for efficient string building
        // Time Complexity: O(n)
        // Space Complexity: O(n)
        
        return string.Empty;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 4.1: Reverse String ===");
        
        string test1 = "hello";
        string result1 = Solution(test1);
        Console.WriteLine($"Test 1 - Input: \"hello\"");
        Console.WriteLine($"         Output: \"{result1}\", Expected: \"olleh\"");
        Console.WriteLine($"         {(result1 == "olleh" ? "✓ PASSED" : "✗ FAILED")}\n");
        
        string test2 = "a";
        string result2 = Solution(test2);
        Console.WriteLine($"Test 2 - Input: \"a\"");
        Console.WriteLine($"         Output: \"{result2}\", Expected: \"a\"");
        Console.WriteLine($"         {(result2 == "a" ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

