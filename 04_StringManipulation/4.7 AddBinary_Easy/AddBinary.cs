using System;
using System.Text;
using System.Numerics;

namespace DSA._4_7_AddBinary_Easy;

/// <summary>
/// Problem 4.7 (Easy): Add Binary
/// Given two binary strings a and b, return their sum as a binary string.
///
/// Example 1:
/// Input: a = "11", b = "1"
/// Output: "100"
///
/// Example 2:
/// Input: a = "1010", b = "1011"
/// Output: "10101"
/// </summary>
/// 
/// Constraints:
// 1 <= a.length, b.length <= 104
// a and b consist only of '0' or '1' characters.
// Each string does not contain leading zeros except for the zero itself.
public class AddBinary
{
    public static string Solution(string a, string b)
    {

        // 1) Convert binary strings a and b to integer values
        BigInteger valA = 0;
        foreach (char c in a)           // read bits left → right
        {
            valA = valA * 2 + (c - '0'); // shift left and add current bit
        }

        BigInteger valB = 0;
        foreach (char c in b)
        {
            valB = valB * 2 + (c - '0');
        }

        BigInteger sum = valA + valB;   // integer sum

        // 2) Convert integer sum back to binary string
        if (sum == 0)
            return "0";

        var sb = new StringBuilder();

        while (sum > 0)
        {
            // sum % 2 gives the least significant bit (0 or 1)
            BigInteger bit = sum % 2;
            sb.Append(bit == 1 ? '1' : '0'); // build from least-significant to most

            sum /= 2; // move to the next bit (integer divide by 2)
        }

        // We built the string backwards, so reverse it once at the end
        char[] chars = sb.ToString().ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }

    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 4.7: Add Binary ===");

        // Test Case 1
        string a1 = "11";
        string b1 = "1";
        string result1 = Solution(a1, b1);
        string expected1 = "100";
        Console.WriteLine($"Test 1 - Input: a = \"{a1}\", b = \"{b1}\"");
        Console.WriteLine($"         Output: {result1}, Expected: {expected1}");
        Console.WriteLine($"         {(result1 == expected1 ? "✓ PASSED" : "✗ FAILED")}\n");

        // Test Case 2
        string a2 = "1010";
        string b2 = "1011";
        string result2 = Solution(a2, b2);
        string expected2 = "10101";
        Console.WriteLine($"Test 2 - Input: a = \"{a2}\", b = \"{b2}\"");
        Console.WriteLine($"         Output: {result2}, Expected: {expected2}");
        Console.WriteLine($"         {(result2 == expected2 ? "✓ PASSED" : "✗ FAILED")}\n");

        // Test Case 3: different lengths
        string a3 = "1";
        string b3 = "111";
        string result3 = Solution(a3, b3);
        string expected3 = "1000";
        Console.WriteLine($"Test 3 - Input: a = \"{a3}\", b = \"{b3}\"");
        Console.WriteLine($"         Output: {result3}, Expected: {expected3}");
        Console.WriteLine($"         {(result3 == expected3 ? "✓ PASSED" : "✗ FAILED")}\n");

        // Test Case 4: zeros
        string a4 = "0";
        string b4 = "0";
        string result4 = Solution(a4, b4);
        string expected4 = "0";
        Console.WriteLine($"Test 4 - Input: a = \"{a4}\", b = \"{b4}\"");
        Console.WriteLine($"         Output: {result4}, Expected: {expected4}");
        Console.WriteLine($"         {(result4 == expected4 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

