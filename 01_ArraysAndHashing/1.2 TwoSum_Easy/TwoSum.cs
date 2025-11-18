using System;
using System.Collections.Generic;

namespace DSA._1_2_TwoSum_Easy;

/// <summary>
/// Problem 1.2 (Easy): Two Sum
/// Given an array of integers nums and an integer target, return indices of the two numbers
/// such that they add up to target.
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
public class TwoSum
{
    public static int[] Solution(int[] nums, int target)
    {
        // TODO: Implement your solution here
        //
        // Approach:
        // 1. We need to find two numbers that add up to target
        // 2. For each number, we can calculate what its "complement" would be (target - num)
        // 3. If we've seen the complement before, we found our pair!
        //
        // Hint: Dictionary<int, int> is perfect - store (number, index) pairs
        //       Key = number value, Value = its index in the array
        //
        // Algorithm:
        // - Iterate through the array
        // - For each number, calculate complement = target - num
        // - Check if complement exists in Dictionary
        //   - If yes: return [index of complement, current index]
        //   - If no: add (num, current index) to Dictionary
        //
        // Time Complexity: Try to achieve O(n)
        // Space Complexity: Try to achieve O(n)

        // 1. Brute Force

        // for (int i = 0; i < nums.Length; i++)
        // {
        //     for (int j = i + 1; j < nums.Length; j++)
        //     {
        //         if (nums[i] + nums[j] == target)
        //         {
        //             return new int[] { i, j };
        //         }
        //     }
        // }
        // return Array.Empty<int>();

        // 2.1 Dictionary
        // Dictionary <int, int> dict = new Dictionary<int, int>();
        // for (int i=0; i < nums.Length; i++)
        // {
        //     int complement = target - nums[i];
        //     if (dict.ContainsKey(complement))
        //     {
        //         return new int[] {dict[complement], i};
        //     }
        //     dict[nums[i]] = i;
        // }
        // return Array.Empty<int>();
 

        // 2.2 Advanced Dictionary Initialize
        var dict = new Dictionary<int, int> ();
        for (int i =0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (dict.TryGetValue(complement, out int complementIndex))
            {
                return [complementIndex, i];
            }
            dict[nums[i]] = i;
        }
        return [];

    }


        


    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 1.2: Two Sum ===");
        
        // Test Case 1: Basic example
        int[] test1 = { 2, 7, 11, 15 };
        int target1 = 9;
        int[] result1 = Solution(test1, target1);
        Console.WriteLine($"Test 1 - Input: nums = [2, 7, 11, 15], target = {target1}");
        Console.WriteLine($"         Output: [{result1[0]}, {result1[1]}], Expected: [0, 1]");
        bool passed1 = (result1.Length == 2 && test1[result1[0]] + test1[result1[1]] == target1);
        Console.WriteLine($"         {(passed1 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        // Test Case 2: Different target
        int[] test2 = { 3, 2, 4 };
        int target2 = 6;
        int[] result2 = Solution(test2, target2);
        Console.WriteLine($"Test 2 - Input: nums = [3, 2, 4], target = {target2}");
        Console.WriteLine($"         Output: [{result2[0]}, {result2[1]}], Expected: [1, 2]");
        bool passed2 = (result2.Length == 2 && test2[result2[0]] + test2[result2[1]] == target2);
        Console.WriteLine($"         {(passed2 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

