using System;
using System.Collections.Generic;
using System.Linq;

namespace DSA._1_6_TopKFrequentElements_Medium;

/// <summary>
/// Problem 1.6 (Medium): Top K Frequent Elements
/// Given an integer array nums and an integer k, return the k most frequent elements.
/// You may return the answer in any order.
/// 
/// Example:
/// Input: nums = [1,1,1,2,2,3], k = 2
/// Output: [1,2]
/// 
/// Constraints:
/// - 1 <= nums.length <= 10^5
/// - -10^4 <= nums[i] <= 10^4
/// - k is in the range [1, the number of unique elements in the array].
/// - It is guaranteed that the answer is unique.
/// </summary>
public class TopKFrequentElements
{
    public static int[] Solution(int[] nums, int k)
    {
        // TODO: Implement solution
        // Hint: Count frequencies, use PriorityQueue or bucket sort
        // Time Complexity: O(n + k log k) or O(n) with bucket sort
        // Space Complexity: O(n)
        
        return Array.Empty<int>();
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 1.6: Top K Frequent Elements ===");
        
        // Test Case 1: Basic example
        int[] test1 = { 1, 1, 1, 2, 2, 3 };
        int k1 = 2;
        int[] result1 = Solution(test1, k1);
        Console.WriteLine($"Test 1 - Input: nums = [1,1,1,2,2,3], k = {k1}");
        Console.WriteLine($"         Output: [{string.Join(", ", result1)}], Expected: [1, 2]");
        bool passed1 = result1.Length == 2 && result1.Contains(1) && result1.Contains(2);
        Console.WriteLine($"         {(passed1 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        // Test Case 2: Single element
        int[] test2 = { 1 };
        int k2 = 1;
        int[] result2 = Solution(test2, k2);
        Console.WriteLine($"Test 2 - Input: nums = [1], k = {k2}");
        Console.WriteLine($"         Output: [{string.Join(", ", result2)}], Expected: [1]");
        bool passed2 = result2.Length == 1 && result2[0] == 1;
        Console.WriteLine($"         {(passed2 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

