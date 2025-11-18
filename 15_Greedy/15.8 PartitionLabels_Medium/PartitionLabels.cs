using System;
using System.Collections.Generic;

namespace DSA._15_8_PartitionLabels_Medium;

/// <summary>
/// Problem 15.8 (Medium): Partition Labels
/// You are given a string s. We want to partition the string into as many parts as possible so
/// that each letter appears in at most one part.
/// 
/// Note that the partition is done so that after concatenating all the parts in order, the
/// resultant string should be s.
/// 
/// Return a list of integers representing the size of these parts.
/// 
/// Example:
/// Input: s = "ababcbacadefegdehijhklij"
/// Output: [9,7,8]
/// Explanation:
/// The partition is "ababcbaca", "defegde", "hijhklij".
/// This is a partition so that each letter appears in at most one part.
/// A partition like "ababcbacadefegde", "hijhklij" is incorrect, because it splits s into less parts.
/// 
/// Constraints:
/// - 1 <= s.length <= 500
/// - s consists of lowercase English letters.
/// </summary>
public class PartitionLabels
{
    public static IList<int> Solution(string s)
    {
        // TODO: Implement solution
        // Hint: Greedy - track last occurrence of each character
        // Extend partition until reaching last occurrence of all characters in current partition
        // Time Complexity: O(n)
        // Space Complexity: O(1) - at most 26 characters
        
        return new List<int>();
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 15.8: Partition Labels ===");
        
        var result1 = Solution("ababcbacadefegdehijhklij");
        Console.WriteLine($"Test 1 - Input: \"ababcbacadefegdehijhklij\"");
        Console.WriteLine($"         Output: [{string.Join(",", result1)}], Expected: [9,7,8]");
        bool passed1 = result1.Count == 3 && result1[0] == 9 && result1[1] == 7 && result1[2] == 8;
        Console.WriteLine($"         {(passed1 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        var result2 = Solution("eccbbbbdec");
        Console.WriteLine($"Test 2 - Input: \"eccbbbbdec\"");
        Console.WriteLine($"         Output: [{string.Join(",", result2)}], Expected: [10]");
        bool passed2 = result2.Count == 1 && result2[0] == 10;
        Console.WriteLine($"         {(passed2 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

