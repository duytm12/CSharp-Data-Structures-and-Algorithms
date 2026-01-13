using System;
using System.Collections.Generic;
using System.Linq;

namespace DSA._2_3_GroupAnagrams_Medium;

/// <summary>
/// Problem 2.3 (Medium): Group Anagrams
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

        foreach (var str in strs)
        {
            var charArr = str.ToCharArray();
            Array.Sort(charArr);
            var sortedKey = new string(charArr);

            if (!dict.TryGetValue(str, out var vals))
            {
                vals = [];
                dict[sortedKey] = vals;
            }
            vals.Add(str);
        }

        foreach (var val in dict.Values) result.Add(val);

        return result;


    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 2.3: Group Anagrams ===");
        
        string[] test1 = { "eat", "tea", "tan", "ate", "nat", "bat" };
        var result1 = Solution(test1);
        Console.WriteLine($"Test 1 - Input: [\"eat\", \"tea\", \"tan\", \"ate\", \"nat\", \"bat\"]");
        Console.WriteLine($"         Output: {result1.Count} groups, Expected: 3 groups");
        bool passed1 = result1.Count == 3;
        Console.WriteLine($"         {(passed1 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        string[] test2 = { "a" };
        var result2 = Solution(test2);
        Console.WriteLine($"Test 2 - Input: [\"a\"]");
        Console.WriteLine($"         Output: {result2.Count} groups, Expected: 1 group");
        bool passed2 = result2.Count == 1;
        Console.WriteLine($"         {(passed2 ? "✓ PASSED" : "✗ FAILED")}\n");

        // Test 3: Complex case with multiple groups, different lengths, and empty strings
        string[] test3 = { "listen", "silent", "enlist", "hello", "world", "dlrow", "a", "b", "c", "", "abc", "bac", "cab", "xyz" };
        var result3 = Solution(test3);
        Console.WriteLine($"Test 3 - Input: [\"listen\", \"silent\", \"enlist\", \"hello\", \"world\", \"dlrow\", \"a\", \"b\", \"c\", \"\", \"abc\", \"bac\", \"cab\", \"xyz\"]");
        Console.WriteLine($"         Output: {result3.Count} groups, Expected: 9 groups");
        Console.WriteLine($"         Groups: {string.Join(", ", result3.Select((g, i) => $"[{string.Join(",", g)}]"))}");
        // Expected groups: ["listen","silent","enlist"], ["hello"], ["world","dlrow"], ["a"], ["b"], ["c"], [""], ["abc","bac","cab"], ["xyz"]
        bool passed3 = result3.Count == 9;
        Console.WriteLine($"         {(passed3 ? "✓ PASSED" : "✗ FAILED")}\n");

        // Test 4: Large array with many anagram groups of varying lengths
        string[] test4 = { "rat", "tar", "art", "cat", "act", "tac", "dog", "god", "flow", "wolf", "lowf", "listen", "silent", "enlist", "tinsel", "a", "aa", "aaa", "ab", "ba", "abc", "acb", "bca", "bac", "cab", "cba" };
        var result4 = Solution(test4);
        Console.WriteLine($"Test 4 - Input: Array with {test4.Length} strings of varying lengths");
        Console.WriteLine($"         Output: {result4.Count} groups, Expected: 10 groups");
        Console.WriteLine($"         Groups: {string.Join(", ", result4.Select((g, i) => $"[{string.Join(",", g)}]"))}");
        // Expected groups: ["rat","tar","art"], ["cat","act","tac"], ["dog","god"], ["flow","wolf","lowf"], ["listen","silent","enlist","tinsel"], ["a"], ["aa"], ["aaa"], ["ab","ba"], ["abc","acb","bca","bac","cab","cba"]
        bool passed4 = result4.Count == 10;
        Console.WriteLine($"         {(passed4 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

