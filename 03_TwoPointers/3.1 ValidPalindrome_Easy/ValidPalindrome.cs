using System;

namespace DSA._3_1_ValidPalindrome_Easy;

/// <summary>
/// Problem 3.1 (Easy): Valid Palindrome
/// A phrase is a palindrome if, after converting all uppercase letters into lowercase letters
/// and removing all non-alphanumeric characters, it reads the same forward and backward.
/// 
/// Example:
/// Input: s = "A man, a plan, a canal: Panama"
/// Output: true
/// Explanation: "amanaplanacanalpanama" is a palindrome.
/// 
/// Constraints:
/// - 1 <= s.length <= 2 * 10^5
/// - s consists only of printable ASCII characters.
/// </summary>
public class ValidPalindrome
{
    public static bool Solution(string s)
    {
        // TODO: Implement solution
        // Hint: Use two pointers (left and right), move towards center
        // Time Complexity: O(n)
        // Space Complexity: O(1)
        
        return false;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 3.1: Valid Palindrome ===");
        
        string test1 = "A man, a plan, a canal: Panama";
        bool result1 = Solution(test1);
        Console.WriteLine($"Test 1 - Input: \"A man, a plan, a canal: Panama\"");
        Console.WriteLine($"         Output: {result1}, Expected: True");
        Console.WriteLine($"         {(result1 == true ? "✓ PASSED" : "✗ FAILED")}\n");
        
        string test2 = "race a car";
        bool result2 = Solution(test2);
        Console.WriteLine($"Test 2 - Input: \"race a car\"");
        Console.WriteLine($"         Output: {result2}, Expected: False");
        Console.WriteLine($"         {(result2 == false ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

