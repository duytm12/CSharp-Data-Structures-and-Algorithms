using System;
using System.Text;

namespace DSA._4_8_VanityNumberToDigits_Easy;

/// <summary>
/// Problem 4.8 (Easy): Vanity Number to Digits
/// Convert a phone number with letters (vanity format) to its numeric form.
/// Standard phone keypad: ABC=2, DEF=3, GHI=4, JKL=5, MNO=6, PQRS=7, TUV=8, WXYZ=9
///
/// Example 1:
/// Input: "800-HELP"
/// Output: "800-4357"
///
/// Example 2:
/// Input: "1-800-FLOWERS"
/// Output: "1-800-3569377"
/// </summary>
public class VanityNumberToDigits
{
    public static string Solution(string s)
    {
        // Dictionary { charArray, int}
        // Split Input (-)
        // Check each part
        // Use String builder to Append

        var dict = new Dictionary<char, int>();
        string[] groups = { "", "", "ABC", "DEF", "GHI", "JKL", "MNO", "PQRS", "TUV", "WXYZ" };

        for (int i = 2; i <= 9; i++)
        {
            foreach (char d in groups[i])
            {
                dict[d] = i;
                dict[char.ToLower(d)] = i;
            }
        }

        var result = new StringBuilder();
        foreach (char c in s)
        {
            if (char.IsLetter(c)) result.Append(dict.GetValueOrDefault(c));
            else result.Append(c);
        }

        return result.ToString();

    }

    public static void Test()
    {
        Console.WriteLine("\n=== Problem 4.8: Vanity Number to Digits ===\n");

        Console.WriteLine($"\"800-HELP\"      => \"{Solution("800-HELP")}\"      (expected: 800-4357)");
        Console.WriteLine($"\"1-800-FLOWERS\" => \"{Solution("1-800-FLOWERS")}\" (expected: 1-800-3569377)");
        Console.WriteLine($"\"555-PIZZA\"     => \"{Solution("555-PIZZA")}\"     (expected: 555-74992)");
    }
}
