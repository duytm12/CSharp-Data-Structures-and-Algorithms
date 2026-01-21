using System;

namespace DSA._15_2_JumpGame_Medium;

/// <summary>
/// Problem 15.2 (Medium): Jump Game (LeetCode 55)
/// 
/// You are given an integer array nums. You are initially positioned at the array's first index,
/// and each element in the array represents your maximum jump length at that position.
/// 
/// Return true if you can reach the last index, or false otherwise.
/// 
/// Example 1:
/// Input: nums = [2,3,1,1,4]
/// Output: true
/// Explanation: Jump 1 step from index 0 to 1, then 3 steps to the last index.
/// 
/// Example 2:
/// Input: nums = [3,2,1,0,4]
/// Output: false
/// Explanation: You will always arrive at index 3 no matter what. Its maximum jump length is 0,
/// which makes it impossible to reach the last index.
/// 
/// Constraints:
/// - 1 <= nums.length <= 10^4
/// - 0 <= nums[i] <= 10^5
/// </summary>
public class JumpGame
{
    public static bool Solution(int[] nums) // nums = [2,3,1,1,4]
    {
        // Greedy: track the farthest index we can reach so far.
        // If we ever land on an index beyond that, we're stuck.
        // Time: O(n), Space: O(1)

        int farthest = 0;
        int lastIndex = nums.Length - 1;

        for (int i = 0; i <= farthest && i < nums.Length; i++)
        {
            farthest = Math.Max(farthest, i + nums[i]); // i = 1, nums[1] = 2, farthest = 3;
            if (farthest >= lastIndex) return true;
        }

        return false;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 15.2: Jump Game ===");
        
        int[] test1 = { 2, 3, 1, 1, 4 };
        bool result1 = Solution(test1);
        Console.WriteLine($"Test 1 - Input: [2,3,1,1,4]");
        Console.WriteLine($"         Output: {result1}, Expected: True");
        Console.WriteLine($"         {(result1 == true ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[] test2 = { 3, 2, 1, 0, 4 };
        bool result2 = Solution(test2);
        Console.WriteLine($"Test 2 - Input: [3,2,1,0,4]");
        Console.WriteLine($"         Output: {result2}, Expected: False");
        Console.WriteLine($"         {(result2 == false ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

