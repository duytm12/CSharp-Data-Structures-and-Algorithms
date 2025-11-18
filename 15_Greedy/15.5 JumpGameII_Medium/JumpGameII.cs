using System;

namespace DSA._15_5_JumpGameII_Medium;

/// <summary>
/// Problem 15.5 (Medium): Jump Game II
/// You are given a 0-indexed array of integers nums of length n. You are initially positioned at nums[0].
/// 
/// Each element nums[i] represents the maximum length of a forward jump from index i. In other words,
/// if you are at nums[i], you can jump to any nums[i + j] where:
/// - 0 <= j <= nums[i] and
/// - i + j < n
/// 
/// Return the minimum number of jumps to reach nums[n - 1]. The test cases are generated such that
/// you can reach nums[n - 1].
/// 
/// Example:
/// Input: nums = [2,3,1,1,4]
/// Output: 2
/// Explanation: The minimum number of jumps to reach the last index is 2. Jump 1 step from index 0 to 1, then 3 steps to the last index.
/// 
/// Constraints:
/// - 1 <= nums.length <= 10^4
/// - 0 <= nums[i] <= 1000
/// - It's guaranteed that you can reach nums[n - 1].
/// </summary>
public class JumpGameII
{
    public static int Jump(int[] nums)
    {
        // TODO: Implement solution
        // Hint: Greedy - track farthest reachable and current jump end
        // Increment jumps when reaching current jump end
        // Time Complexity: O(n)
        // Space Complexity: O(1)
        
        return 0;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 15.5: Jump Game II ===");
        
        int[] test1 = { 2, 3, 1, 1, 4 };
        int result1 = Jump(test1);
        Console.WriteLine($"Test 1 - Input: [2,3,1,1,4]");
        Console.WriteLine($"         Output: {result1}, Expected: 2");
        Console.WriteLine($"         {(result1 == 2 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[] test2 = { 2, 3, 0, 1, 4 };
        int result2 = Jump(test2);
        Console.WriteLine($"Test 2 - Input: [2,3,0,1,4]");
        Console.WriteLine($"         Output: {result2}, Expected: 2");
        Console.WriteLine($"         {(result2 == 2 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

