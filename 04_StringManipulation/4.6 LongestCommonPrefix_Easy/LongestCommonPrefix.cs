using System;

namespace DSA._4_6_LongestCommonPrefix_Easy;

/// <summary>
/// Problem 4.6 (Easy): Longest Common Prefix (LeetCode 14)
/// 
/// Write a function to find the longest common prefix string amongst an array of strings.
/// If there is no common prefix, return an empty string "".
/// 
/// Example 1:
/// Input:  strs = ["flower","flow","flight"]
/// Output: "fl"
/// 
/// Example 2:
/// Input:  strs = ["dog","racecar","car"]
/// Output: ""
/// Explanation: There is no common prefix among the input strings.
/// 
/// Constraints:
/// - 1 <= strs.Length <= 200
/// - 0 <= strs[i].Length <= 200
/// - strs[i] consists of only lowercase English letters if it is non-empty.
/// </summary>
public class LongestCommonPrefix
{
    /// <summary>
    /// Returns the longest common prefix among all strings in the array.
    /// Uses horizontal scanning: start with the first string as the prefix,
    /// then shrink it until it is a prefix of every other string.
    /// 
    /// Time Complexity: O(S) where S is the sum of all characters in all strings.
    /// Space Complexity: O(1) (ignoring the output string).
    /// </summary>
    public static string Solution(string[] strs)
    {
        if (strs.Length == 1) return strs[0];

        var firstStr = strs[0];

        var minLen = firstStr.Length;

        for (int i = 1; i < strs.Length; i++)
        {
            if (strs[i].Length < minLen) minLen = strs[i].Length;
        }

        var prefixIndex = 0;
        
        while (prefixIndex < minLen)
        {
            char c = firstStr[prefixIndex];
            for (int j = 1; j < strs.Length; j++)
            {
                if (strs[j][prefixIndex] != c) return firstStr[..prefixIndex];
            }
            prefixIndex++;
        }
        return firstStr[..prefixIndex];
    }

    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 4.6: Longest Common Prefix ===");

        // Test Case 1: Example with common prefix "fl"
        string[] test1 = { "flower", "flow", "flight" };
        string result1 = Solution(test1);
        Console.WriteLine("Test 1 - Input: [\"flower\",\"flow\",\"flight\"]");
        Console.WriteLine($"         Output: \"{result1}\", Expected: \"fl\"");
        Console.WriteLine($"         {(result1 == "fl" ? "✓ PASSED" : "✗ FAILED")}\n");

        // Test Case 2: No common prefix
        string[] test2 = { "dog", "racecar", "car" };
        string result2 = Solution(test2);
        Console.WriteLine("Test 2 - Input: [\"dog\",\"racecar\",\"car\"]");
        Console.WriteLine($"         Output: \"{result2}\", Expected: \"\"");
        Console.WriteLine($"         {(result2 == string.Empty ? "✓ PASSED" : "✗ FAILED")}\n");

        // Test Case 3: All strings identical
        string[] test3 = { "test", "test", "test" };
        string result3 = Solution(test3);
        Console.WriteLine("Test 3 - Input: [\"test\",\"test\",\"test\"]");
        Console.WriteLine($"         Output: \"{result3}\", Expected: \"test\"");
        Console.WriteLine($"         {(result3 == "test" ? "✓ PASSED" : "✗ FAILED")}\n");

        // Test Case 4: Single string in array
        string[] test4 = { "alone" };
        string result4 = Solution(test4);
        Console.WriteLine("Test 4 - Input: [\"alone\"]");
        Console.WriteLine($"         Output: \"{result4}\", Expected: \"alone\"");
        Console.WriteLine($"         {(result4 == "alone" ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}


