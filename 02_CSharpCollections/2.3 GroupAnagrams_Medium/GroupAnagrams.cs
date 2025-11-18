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
    public static IList<IList<string>> Solution(string[] strs)
    {
        // TODO: Implement solution
        // Hint: Use Dictionary with sorted string as key, List as value
        // Time Complexity: O(n * k log k) where k is average string length
        // Space Complexity: O(n * k)
        
        return new List<IList<string>>();
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
    }
}

