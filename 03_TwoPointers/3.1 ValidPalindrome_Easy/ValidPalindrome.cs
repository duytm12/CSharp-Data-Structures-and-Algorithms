using System;

namespace DSA._3_1_ValidPalindrome_Easy;

/// <summary>
/// Problem 3.1 (Easy): Valid Palindrome (Integer)
/// Given an integer x, return true if x is a palindrome, and false otherwise.
/// 
/// Example:
/// Input: x = 121
/// Output: true
/// Explanation: 121 reads as 121 from left to right and from right to left.
/// 
/// Example 2:
/// Input: x = -121
/// Output: false
/// Explanation: From left to right, it reads -121. From right to left, it becomes 121-.
/// Therefore it is not a palindrome.
/// 
/// Constraints:
/// - -2^31 <= x <= 2^31 - 1
/// </summary>
public class ValidPalindrome
{
    public static bool Solution(int x)
    {
        // TODO: Implement solution
        // Hint: Reverse the integer and compare with original
        // Negative numbers are not palindromes
        // Time Complexity: O(log n) where n is the number of digits
        // Space Complexity: O(1)
        if (x < 0) return false;
        if (x < 10) return true;
        if (x % 10 == 0) return false;

        // 1. Convert x to string, then reverse, then compare
        // var str = x.ToString();
        // var reverse = new string([.. str.Reverse()]);
        // return str == reverse;

        // 2. 2 pointers:
        // var str = x.ToString();
        // var left = 0;
        // var right = str.Length - 1;

        // while (left < right)
        // {
        //     if (str[left] != str[right]) return false;
        //     left++;
        //     right--;
        // }
        // return true;


        // 3. Do not convert to string, use math
        var original = x;
        var reverse = 0;

        while (x > 0)
        {
            reverse = reverse * 10 + x % 10;
            x /= 10;
        }
        return original == reverse;

    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 3.1: Valid Palindrome (Integer) ===");
        
        int test1 = 121;
        bool result1 = Solution(test1);
        Console.WriteLine($"Test 1 - Input: {test1}");
        Console.WriteLine($"         Output: {result1}, Expected: True");
        Console.WriteLine($"         {(result1 == true ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int test2 = -121;
        bool result2 = Solution(test2);
        Console.WriteLine($"Test 2 - Input: {test2}");
        Console.WriteLine($"         Output: {result2}, Expected: False");
        Console.WriteLine($"         {(result2 == false ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int test3 = 10;
        bool result3 = Solution(test3);
        Console.WriteLine($"Test 3 - Input: {test3}");
        Console.WriteLine($"         Output: {result3}, Expected: False");
        Console.WriteLine($"         {(result3 == false ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int test4 = 0;
        bool result4 = Solution(test4);
        Console.WriteLine($"Test 4 - Input: {test4}");
        Console.WriteLine($"         Output: {result4}, Expected: True");
        Console.WriteLine($"         {(result4 == true ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

