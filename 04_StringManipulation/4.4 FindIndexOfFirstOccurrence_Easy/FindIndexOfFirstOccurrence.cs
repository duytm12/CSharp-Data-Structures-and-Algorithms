using System;
using System.Globalization;

namespace DSA._4_4_FindIndexOfFirstOccurrence_Easy;

/// <summary>
/// Problem 4.4 (Easy): Find the Index of the First Occurrence in a String
/// Given two strings needle and haystack, return the index of the first occurrence of needle in haystack,
/// or -1 if needle is not part of haystack.
/// 
/// Example 1:
/// Input: haystack = "sadbutsad", needle = "sad"
/// Output: 0
/// Explanation: "sad" occurs at index 0 and 6. The first occurrence is at index 0.
/// 
/// Example 2:
/// Input: haystack = "leetcode", needle = "leeto"
/// Output: -1
/// Explanation: "leeto" did not occur in "leetcode", so -1 is returned.
/// 
/// Constraints:
/// - 1 <= haystack.length, needle.length <= 10^4
/// - haystack and needle consist of only lowercase English characters.
/// </summary>
public class FindIndexOfFirstOccurrence
{
    public static int Solution(string haystack, string needle)
    {
        // TODO: Implement solution
        // Hint: Use string.IndexOf() or implement manually with nested loops
        // Time Complexity: O(n * m) where n = haystack.length, m = needle.length
        // Space Complexity: O(1)

        // Solution 1: Built-in IndexOf
        if (haystack.Length == 0 || needle.Length > haystack.Length) return -1;

        if (string.IsNullOrWhiteSpace(needle) || needle == haystack) return 0;

        // return haystack.IndexOf(needle);

        // Solution 2: Sliding window

        // for (int i = 0; i <= haystack.Length - needle.Length; i++)
        // {
        //     if (haystack[i] == needle[0])
        //     {
        //         int j = 1;
        //         while (j < needle.Length && haystack[i + j] == needle[j])
        //         {
        //             j++;
        //         }
        //         if (j == needle.Length) return i;
        //     }
        // }
        // return -1;

        // Solution 3: Substring

        for (int i = 0; i <= haystack.Length - needle.Length; i++)
        {
            if (haystack.Substring(i, needle.Length) == needle) return i;
        }

        return -1;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 4.4: Find the Index of the First Occurrence in a String ===");
        
        // Test Case 1: Basic example
        string test1_haystack = "sadbutsad";
        string test1_needle = "sad";
        int result1 = Solution(test1_haystack, test1_needle);
        Console.WriteLine($"Test 1 - Input: haystack = \"{test1_haystack}\", needle = \"{test1_needle}\"");
        Console.WriteLine($"         Output: {result1}, Expected: 0");
        bool passed1 = result1 == 0;
        Console.WriteLine($"         {(passed1 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        // Test Case 2: Needle not found
        string test2_haystack = "leetcode";
        string test2_needle = "leeto";
        int result2 = Solution(test2_haystack, test2_needle);
        Console.WriteLine($"Test 2 - Input: haystack = \"{test2_haystack}\", needle = \"{test2_needle}\"");
        Console.WriteLine($"         Output: {result2}, Expected: -1");
        bool passed2 = result2 == -1;
        Console.WriteLine($"         {(passed2 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        // Test Case 3: Needle at the end
        string test3_haystack = "hello";
        string test3_needle = "lo";
        int result3 = Solution(test3_haystack, test3_needle);
        Console.WriteLine($"Test 3 - Input: haystack = \"{test3_haystack}\", needle = \"{test3_needle}\"");
        Console.WriteLine($"         Output: {result3}, Expected: 3");
        bool passed3 = result3 == 3;
        Console.WriteLine($"         {(passed3 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        // Test Case 4: Single character match
        string test4_haystack = "a";
        string test4_needle = "a";
        int result4 = Solution(test4_haystack, test4_needle);
        Console.WriteLine($"Test 4 - Input: haystack = \"{test4_haystack}\", needle = \"{test4_needle}\"");
        Console.WriteLine($"         Output: {result4}, Expected: 0");
        bool passed4 = result4 == 0;
        Console.WriteLine($"         {(passed4 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

