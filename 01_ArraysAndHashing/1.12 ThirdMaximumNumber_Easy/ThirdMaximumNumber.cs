using System;

namespace DSA._1_12_ThirdMaximumNumber_Easy;

/// <summary>
/// Problem 1.12 (Easy): Third Maximum Number (LeetCode 414)
/// Given an integer array nums, return the third distinct maximum number in this array.
/// If the third maximum does not exist, return the maximum number.
/// 
/// Example 1:
/// Input: nums = [3,2,1]
/// Output: 1
/// Explanation: The first distinct maximum is 3. The second distinct maximum is 2. The third distinct maximum is 1.
/// 
/// Example 2:
/// Input: nums = [1,2]
/// Output: 2
/// Explanation: The first distinct maximum is 2. The second distinct maximum is 1. The third distinct maximum does not exist, so the maximum (2) is returned.
/// 
/// Example 3:
/// Input: nums = [2,2,3,1]
/// Output: 1
/// Explanation: The first distinct maximum is 3. The second distinct maximum is 2 (both 2's are counted together since they have the same value). The third distinct maximum is 1.
/// 
/// Constraints:
/// - 1 <= nums.length <= 10^4
/// - -2^31 <= nums[i] <= 2^31 - 1
/// </summary>
public class ThirdMaximumNumber
{
    public static int Solution(int[] nums)
    {
        // TODO: Implement solution
        return 0;
    }

    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 1.12: Third Maximum Number ===");

        int[] test1 = { 3, 2, 1 };
        int result1 = Solution(test1);
        Console.WriteLine($"Test 1 - Input: [3,2,1]");
        Console.WriteLine($"         Output: {result1}, Expected: 1");
        Console.WriteLine($"         {(result1 == 1 ? "✓ PASSED" : "✗ FAILED")}\n");

        int[] test2 = { 1, 2 };
        int result2 = Solution(test2);
        Console.WriteLine($"Test 2 - Input: [1,2]");
        Console.WriteLine($"         Output: {result2}, Expected: 2");
        Console.WriteLine($"         {(result2 == 2 ? "✓ PASSED" : "✗ FAILED")}\n");

        int[] test3 = { 2, 2, 3, 1 };
        int result3 = Solution(test3);
        Console.WriteLine($"Test 3 - Input: [2,2,3,1]");
        Console.WriteLine($"         Output: {result3}, Expected: 1");
        Console.WriteLine($"         {(result3 == 1 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}
