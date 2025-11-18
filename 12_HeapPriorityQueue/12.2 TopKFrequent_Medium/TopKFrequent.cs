using System;
using System.Collections.Generic;

namespace DSA._12_2_TopKFrequent_Medium;

/// <summary>
/// Problem 12.2 (Medium): Top K Frequent Elements
/// Given an integer array nums and an integer k, return the k most frequent elements.
/// 
/// Example:
/// Input: nums = [1,1,1,2,2,3], k = 2
/// Output: [1,2]
/// </summary>
public class TopKFrequent
{
    public static int[] Solution(int[] nums, int k)
    {
        // TODO: Implement solution
        // Hint: Count frequencies, use PriorityQueue with frequency as priority
        // Time Complexity: O(n + k log k)
        // Space Complexity: O(n)
        
        return Array.Empty<int>();
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 12.2: Top K Frequent ===");
        
        int[] test1 = { 1, 1, 1, 2, 2, 3 };
        var result1 = Solution(test1, 2);
        Console.WriteLine($"Test 1 - Input: [1,1,1,2,2,3], k = 2");
        Console.WriteLine($"         Output: [{string.Join(",", result1)}], Expected: [1,2]");
        bool passed1 = result1.Length == 2 && result1.Contains(1) && result1.Contains(2);
        Console.WriteLine($"         {(passed1 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[] test2 = { 1 };
        var result2 = Solution(test2, 1);
        Console.WriteLine($"Test 2 - Input: [1], k = 1");
        Console.WriteLine($"         Output: [{string.Join(",", result2)}], Expected: [1]");
        Console.WriteLine($"         {(result2.Length == 1 && result2[0] == 1 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

