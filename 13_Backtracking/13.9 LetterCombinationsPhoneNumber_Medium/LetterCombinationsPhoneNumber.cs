using System;
using System.Collections.Generic;

namespace DSA._13_9_LetterCombinationsPhoneNumber_Medium;

/// <summary>
/// Problem 13.9 (Medium): Letter Combinations of a Phone Number
/// Given a string containing digits from 2-9 inclusive, return all possible letter combinations
/// that the number could represent. Return the answer in any order.
/// 
/// A mapping of digits to letters (just like on the telephone buttons) is given below.
/// Note that 1 does not map to any letters.
/// 
/// Example:
/// Input: digits = "23"
/// Output: ["ad","ae","af","bd","be","bf","cd","ce","cf"]
/// 
/// Constraints:
/// - 0 <= digits.length <= 4
/// - digits[i] is a digit in the range ['2', '9'].
/// </summary>
public class LetterCombinationsPhoneNumber
{
    public static IList<string> Solution(string digits)
    {
        // TODO: Implement solution
        // Hint: Backtrack, for each digit, try all possible letters
        // Build combinations character by character
        // Time Complexity: O(4^n * n) where n is digits length
        // Space Complexity: O(4^n * n)
        
        return new List<string>();
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 13.9: Letter Combinations Phone Number ===");
        
        var result1 = Solution("23");
        Console.WriteLine($"Test 1 - Input: \"23\"");
        Console.WriteLine($"         Output: {result1.Count} combinations, Expected: 9");
        Console.WriteLine($"         {(result1.Count == 9 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        var result2 = Solution("");
        Console.WriteLine($"Test 2 - Input: \"\"");
        Console.WriteLine($"         Output: {result2.Count} combinations, Expected: 0");
        Console.WriteLine($"         {(result2.Count == 0 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

