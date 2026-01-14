using System;
using System.Collections.Generic;

namespace DSA._2_5_TwoSumDictionary_Easy;

/// <summary>
/// Problem 2.5 (Easy): Two Sum using Dictionary
/// Given an array of integers nums and an integer target, return indices of the two numbers
/// such that they add up to target using Dictionary&lt;TKey, TValue&gt;.
/// 
/// Example:
/// Input: nums = [2,7,11,15], target = 9
/// Output: [0,1]
/// Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
/// 
/// Constraints:
/// - 2 <= nums.length <= 10^4
/// - -10^9 <= nums[i] <= 10^9
/// - -10^9 <= target <= 10^9
/// - Only one valid answer exists.
/// </summary>
public class TwoSumDictionary
{
    public static int[] Solution(int[] nums, int target)
    {
        // TODO: Implement solution
        // Hint: Use Dictionary to store complement (target - current number) and its index
        // Time Complexity: O(n)
        // Space Complexity: O(n)
        var dict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++) //{ 2, 7, 11, 15 } target = 9;
        {
            var complement = target - nums[i];
            if (dict.TryGetValue(complement, out var compIndex))
            {
                return [i, compIndex];
            }
            dict[nums[i]] = i;
        }

        return [];


    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 2.5: Two Sum Dictionary ===");
        
        int[] test1 = { 2, 7, 11, 15 };
        int target1 = 9;
        int[] result1 = Solution(test1, target1);
        Console.WriteLine($"Test 1 - Input: nums = [2, 7, 11, 15], target = {target1}");
        Console.WriteLine($"         Output: [{result1[0]}, {result1[1]}], Expected: [0, 1]");
        bool passed1 = result1.Length == 2 && test1[result1[0]] + test1[result1[1]] == target1;
        Console.WriteLine($"         {(passed1 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[] test2 = { 3, 2, 4 };
        int target2 = 6;
        int[] result2 = Solution(test2, target2);
        Console.WriteLine($"Test 2 - Input: nums = [3, 2, 4], target = {target2}");
        Console.WriteLine($"         Output: [{result2[0]}, {result2[1]}], Expected: [1, 2]");
        bool passed2 = result2.Length == 2 && test2[result2[0]] + test2[result2[1]] == target2;
        Console.WriteLine($"         {(passed2 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

