using System;
using System.Collections.Generic;

namespace DSA._2_2_CharacterFrequency_Medium;

/// <summary>
/// Problem 2.2 (Medium): Dictionary Frequency Counter
/// Count the frequency of each character in a string using Dictionary&lt;TKey, TValue&gt;.
/// 
/// Example:
/// Input: "hello"
/// Output: Dictionary with h:1, e:1, l:2, o:1
/// </summary>
public class CharacterFrequency
{
    public static Dictionary<char, int> Solution(string s)
    {
        // TODO: Implement solution
        // Hint: Use Dictionary.TryGetValue or Dictionary.ContainsKey
        // Time Complexity: O(n)
        // Space Complexity: O(k) where k is number of unique characters
        var dict = new Dictionary<char, int>();
        var charArr = s.ToCharArray();

        foreach (var c in charArr)
        {
            dict[c] = dict.GetValueOrDefault(c, 0) + 1;
        }

        return dict;

    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 2.2: Character Frequency ===");
        
        string test1 = "hello";
        var result1 = Solution(test1);
        Console.WriteLine($"Test 1 - Input: \"hello\"");
        Console.WriteLine($"         Output: Dictionary with {result1.Count} entries");
        bool passed1 = result1.ContainsKey('h') && result1['h'] == 1 && 
                       result1.ContainsKey('l') && result1['l'] == 2;
        Console.WriteLine($"         {(passed1 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        string test2 = "a";
        var result2 = Solution(test2);
        Console.WriteLine($"Test 2 - Input: \"a\"");
        Console.WriteLine($"         Output: Dictionary with {result2.Count} entries");
        bool passed2 = result2.ContainsKey('a') && result2['a'] == 1;
        Console.WriteLine($"         {(passed2 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        // Test Case 3: Empty string
        string test3 = "";
        var result3 = Solution(test3);
        Console.WriteLine($"Test 3 - Input: \"\"");
        Console.WriteLine($"         Output: Dictionary with {result3.Count} entries, Expected: 0");
        bool passed3 = result3.Count == 0;
        Console.WriteLine($"         {(passed3 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        // Test Case 4: String with special characters, numbers, and spaces
        string test4 = "Hello World! 123";
        var result4 = Solution(test4);
        Console.WriteLine($"Test 4 - Input: \"Hello World! 123\"");
        Console.WriteLine($"         Output: Dictionary with {result4.Count} entries");
        bool passed4 = result4.ContainsKey('H') && result4['H'] == 1 &&
                       result4.ContainsKey('l') && result4['l'] == 3 &&
                       result4.ContainsKey(' ') && result4[' '] == 2 &&
                       result4.ContainsKey('1') && result4['1'] == 1 &&
                       result4.ContainsKey('!') && result4['!'] == 1;
        Console.WriteLine($"         {(passed4 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

