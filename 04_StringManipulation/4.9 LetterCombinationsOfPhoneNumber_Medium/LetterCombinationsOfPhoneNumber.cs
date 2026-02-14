using System;
using System.Collections.Generic;

namespace DSA._4_9_LetterCombinationsOfPhoneNumber_Medium;

/// <summary>
/// Problem 4.9 (Medium): Letter Combinations of a Phone Number (LeetCode 17)
/// Given digits (e.g. "23"), return all possible letter combinations the number could represent.
/// Keypad: 2=abc, 3=def, 4=ghi, 5=jkl, 6=mno, 7=pqrs, 8=tuv, 9=wxyz
///
/// Example 1:
/// Input: "23"
/// Output: ["ad","ae","af","bd","be","bf","cd","ce","cf"]
///
/// Example 2:
/// Input: "2"
/// Output: ["a","b","c"]
/// </summary>
public class LetterCombinationsOfPhoneNumber
{
    
    public static IList<string> Solution(string digits)
    {
        
        return [];
    }

    

    public static void Test()
    {
        Console.WriteLine("\n=== Problem 4.9: Letter Combinations of Phone Number ===\n");

        foreach (var input in new[] { "2", "23", "4357" })
        {
            var combos = Solution(input);
            Console.WriteLine($"\"{input}\" => [{string.Join(", ", combos)}]");
        }
    }
}
