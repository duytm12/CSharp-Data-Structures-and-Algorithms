using System;
using System.Linq;
using System.Text;

namespace DSA._4_5_ReverseWordsInString_Medium;

/// <summary>
/// Problem 4.5 (Medium): Reverse Words in a String
/// Given an input string s, reverse the order of the words.
/// A word is defined as a sequence of non-space characters. The words in s will be separated by at least one space.
/// Return a string of the words in reverse order concatenated by a single space.
/// 
/// Note that s may contain leading or trailing spaces or multiple spaces between two words. 
/// The returned string should only have a single space separating the words. Do not include any extra spaces.
/// 
/// Example 1:
/// Input: s = "the sky is blue"
/// Output: "blue is sky the"
/// 
/// Example 2:
/// Input: s = "  hello world  "
/// Output: "world hello"
/// Explanation: Your reversed string should not contain leading or trailing spaces.
/// 
/// Example 3:
/// Input: s = "a good   example"
/// Output: "example good a"
/// Explanation: You need to reduce multiple spaces between two words to a single space in the reversed string.
/// 
/// Constraints:
/// - 1 <= s.length <= 10^4
/// - s contains English letters (upper-case and lower-case), digits, and spaces ' '.
/// - There is at least one word in s.
/// </summary>
public class ReverseWordsInString
{
    public static string Solution(string s)
    {
        // Solution 1: String.Split and Sb.Append 

        // var wordArray = s.Split(' ');

        // // Build result by iterating backwards, skipping empty strings
        // var result = new StringBuilder();
        // for (int i = wordArray.Length - 1; i >= 0; i--)
        // {
        //     // Skip empty strings
        //     if (string.IsNullOrWhiteSpace(wordArray[i]))
        //         continue;

        //     // Add space between words (not before first word)
        //     if (result.Length > 0)
        //         result.Append(" ");

        //     result.Append(wordArray[i]);
        // }

        // return result.ToString();

        // Solution 2: String.Split with StringSplitOptions.RemoveEmptyEntries

        var words = s.Split(" ", StringSplitOptions.RemoveEmptyEntries);
        return string.Join(" ", words.Reverse());
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 4.5: Reverse Words in a String ===");
        
        // Test Case 1: Basic example
        string test1 = "the sky is blue";
        string result1 = Solution(test1);
        Console.WriteLine($"Test 1 - Input: \"the sky is blue\"");
        Console.WriteLine($"         Output: \"{result1}\", Expected: \"blue is sky the\"");
        bool passed1 = result1 == "blue is sky the";
        Console.WriteLine($"         {(passed1 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        // Test Case 2: Leading and trailing spaces
        string test2 = "  hello world  ";
        string result2 = Solution(test2);
        Console.WriteLine($"Test 2 - Input: \"  hello world  \"");
        Console.WriteLine($"         Output: \"{result2}\", Expected: \"world hello\"");
        bool passed2 = result2 == "world hello";
        Console.WriteLine($"         {(passed2 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        // Test Case 3: Multiple spaces between words
        string test3 = "a good   example";
        string result3 = Solution(test3);
        Console.WriteLine($"Test 3 - Input: \"a good   example\"");
        Console.WriteLine($"         Output: \"{result3}\", Expected: \"example good a\"");
        bool passed3 = result3 == "example good a";
        Console.WriteLine($"         {(passed3 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

