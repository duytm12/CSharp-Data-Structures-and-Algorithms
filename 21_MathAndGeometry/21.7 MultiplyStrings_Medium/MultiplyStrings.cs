using System;
using System.Text;

namespace DSA._21_7_MultiplyStrings_Medium;

/// <summary>
/// Problem 21.7 (Medium): Multiply Strings
/// Given two non-negative integers num1 and num2 represented as strings, return the product
/// of num1 and num2, also represented as a string.
/// 
/// Note: You must not use any built-in BigInteger library or convert the inputs to integer directly.
/// 
/// Example:
/// Input: num1 = "2", num2 = "3"
/// Output: "6"
/// 
/// Example 2:
/// Input: num1 = "123", num2 = "456"
/// Output: "56088"
/// 
/// Constraints:
/// - 1 <= num1.length, num2.length <= 200
/// - num1 and num2 consist of digits only.
/// - Both num1 and num2 do not contain any leading zero, except the number 0 itself.
/// </summary>
public class MultiplyStrings
{
    public static string Multiply(string num1, string num2)
    {
        // TODO: Implement solution
        // Hint: Simulate multiplication like grade school
        // result[i+j] += (num1[i] - '0') * (num2[j] - '0')
        // Handle carries, remove leading zeros
        // Time Complexity: O(m * n)
        // Space Complexity: O(m + n)
        
        return string.Empty;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 21.7: Multiply Strings ===");
        
        string result1 = Multiply("2", "3");
        Console.WriteLine($"Test 1 - Input: num1 = \"2\", num2 = \"3\"");
        Console.WriteLine($"         Output: \"{result1}\", Expected: \"6\"");
        Console.WriteLine($"         {(result1 == "6" ? "✓ PASSED" : "✗ FAILED")}\n");
        
        string result2 = Multiply("123", "456");
        Console.WriteLine($"Test 2 - Input: num1 = \"123\", num2 = \"456\"");
        Console.WriteLine($"         Output: \"{result2}\", Expected: \"56088\"");
        Console.WriteLine($"         {(result2 == "56088" ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

