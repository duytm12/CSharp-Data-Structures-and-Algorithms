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

        // Step 1: Count frequencies
        var dict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            dict[nums[i]] = dict.GetValueOrDefault(nums[i], 0) +1;
        }

        return dict.OrderByDescending(x => x.Value).Take(k).Select(y => y.Key).ToArray();

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
        
        // Test Case 3: All elements have same frequency
        int[] test3 = { 1, 2, 3, 4 };
        int k3 = 2;
        int[] result3 = Solution(test3, k3);
        Console.WriteLine($"Test 3 - Input: nums = [1, 2, 3, 4], k = {k3}");
        Console.WriteLine($"         Output: [{string.Join(", ", result3)}], Expected: Any 2 elements from [1, 2, 3, 4]");
        bool passed3 = result3.Length == 2 && 
                       result3.All(x => test3.Contains(x)) && 
                       result3.Distinct().Count() == 2;
        Console.WriteLine($"         {(passed3 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        // Test Case 4: Negative numbers and larger k
        int[] test4 = { -1, -1, -2, -2, -2, -3 };
        int k4 = 2;
        int[] result4 = Solution(test4, k4);
        Console.WriteLine($"Test 4 - Input: nums = [-1, -1, -2, -2, -2, -3], k = {k4}");
        Console.WriteLine($"         Output: [{string.Join(", ", result4)}], Expected: [-2, -1]");
        bool passed4 = result4.Length == 2 && 
                       result4.Contains(-2) && 
                       result4.Contains(-1);
        Console.WriteLine($"         {(passed4 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

