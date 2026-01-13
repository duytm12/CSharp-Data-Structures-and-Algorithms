using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace DSA._1_5_GroupAnagrams_Medium;

/// <summary>
/// Problem 1.5 (Medium): Group Anagrams
/// Given an array of strings strs, group the anagrams together. You can return the answer in any order.
/// 
/// Example:
/// Input: strs = ["eat","tea","tan","ate","nat","bat"]
/// Output: [["bat"],["nat","tan"],["ate","eat","tea"]]
/// 
/// Constraints:
/// - 1 <= strs.length <= 10^4
/// - 0 <= strs[i].length <= 100
/// - strs[i] consists of lowercase English letters.
/// </summary>
public class GroupAnagrams
{
    public static List<IList<string>> Solution(string[] strs)
    {
        // TODO: Implement solution
        // Hint: Use Dictionary with sorted string as key, List as value
        // Time Complexity: O(n * k log k) where k is average string length
        // Space Complexity: O(n * k)
        var result = new List<IList<string>>();
        var dict = new Dictionary<string, List<string>>();

        for (int i = 0; i < strs.Length; i++)
        {
            var charArr = strs[i].ToCharArray();
            Array.Sort(charArr);
            var sortedKey = new string(charArr);

            if (!dict.TryGetValue(sortedKey, out var values))
            {
                values = [];
                dict[sortedKey] = [strs[i]];
                
            }
            values.Add(strs[i]);
        }

        foreach (var value in dict.Values)
        {
            result.Add(value);
        }

        return result;
        
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 1.5: Group Anagrams ===");
        
        // Test Case 1: Basic example
        string[] test1 = { "eat", "tea", "tan", "ate", "nat", "bat" };
        var result1 = Solution(test1);
        Console.WriteLine($"Test 1 - Input: [\"eat\", \"tea\", \"tan\", \"ate\", \"nat\", \"bat\"]");
        Console.WriteLine($"         Output: {result1.Count} groups, Expected: 3 groups");
        bool passed1 = result1.Count == 3;
        Console.WriteLine($"         {(passed1 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        // Test Case 2: Single string
        string[] test2 = { "a" };
        var result2 = Solution(test2);
        Console.WriteLine($"Test 2 - Input: [\"a\"]");
        Console.WriteLine($"         Output: {result2.Count} groups, Expected: 1 group");
        bool passed2 = result2.Count == 1;
        Console.WriteLine($"         {(passed2 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        // Test Case 3: Empty strings
        string[] test3 = { "", "" };
        var result3 = Solution(test3);
        Console.WriteLine($"Test 3 - Input: [\"\", \"\"]");
        Console.WriteLine($"         Output: {result3.Count} groups, Expected: 1 group");
        bool passed3 = result3.Count == 1 && result3[0].Count == 2;
        Console.WriteLine($"         {(passed3 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        // Test Case 4: All strings are anagrams of each other
        string[] test4 = { "listen", "silent", "enlist", "tinsel" };
        var result4 = Solution(test4);
        Console.WriteLine($"Test 4 - Input: [\"listen\", \"silent\", \"enlist\", \"tinsel\"]");
        Console.WriteLine($"         Output: {result4.Count} groups, Expected: 1 group");
        bool passed4 = result4.Count == 1 && result4[0].Count == 4;
        Console.WriteLine($"         {(passed4 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

