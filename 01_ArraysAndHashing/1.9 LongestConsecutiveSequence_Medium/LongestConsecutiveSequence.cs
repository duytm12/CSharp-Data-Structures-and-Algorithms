using System;
using System.Collections.Generic;

namespace DSA._1_9_LongestConsecutiveSequence_Medium;

/// <summary>
/// Problem 1.9 (Medium): Longest Consecutive Sequence
/// Given an unsorted array of integers nums, return the length of the longest consecutive
/// elements sequence. You must write an algorithm that runs in O(n) time.
/// 
/// Example:
/// Input: nums = [100,4,200,1,3,2]
/// Output: 4
/// Explanation: The longest consecutive elements sequence is [1, 2, 3, 4]. Therefore its length is 4.
/// 
/// Constraints:
/// - 0 <= nums.length <= 10^5
/// - -10^9 <= nums[i] <= 10^9
/// </summary>
public class LongestConsecutiveSequence
{
    public static int Solution(int[] nums)
    {
        // TODO: Implement solution
        // Hint: Use HashSet, find sequence starts (numbers without num-1), then expand
        // Time Complexity: O(n)
        // Space Complexity: O(n)

        if (nums.Length == 0) return 0;

        int maxLength = 1;
        int currentLength = 1;

        var hs = nums.ToHashSet().OrderBy(x => x).ToArray(); // hs = [1,2,3,4,100,200]

        for (int i = 0; i < hs.Length - 1; i++)
        {
            if (hs[i - 1] == hs[i] - 1) currentLength++;
            else
            {
                maxLength = Math.Max(maxLength, currentLength);
                currentLength = 1;
            }
        }
        
        return Math.Max(maxLength, currentLength);
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 1.9: Longest Consecutive Sequence ===");
        
        // Test Case 1: Basic example
        int[] test1 = { 100, 4, 200, 1, 3, 2 };
        int result1 = Solution(test1);
        Console.WriteLine($"Test 1 - Input: [100, 4, 200, 1, 3, 2]");
        Console.WriteLine($"         Output: {result1}, Expected: 4");
        Console.WriteLine($"         {(result1 == 4 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        // Test Case 2: Empty array
        int[] test2 = Array.Empty<int>();
        int result2 = Solution(test2);
        Console.WriteLine($"Test 2 - Input: []");
        Console.WriteLine($"         Output: {result2}, Expected: 0");
        Console.WriteLine($"         {(result2 == 0 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

