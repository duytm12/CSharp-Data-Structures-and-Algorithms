using System;
using System.Collections.Generic;

namespace DSA._6_3_SlidingWindowMaximum_Hard;

/// <summary>
/// Problem 6.3 (Hard): Sliding Window Maximum
/// You are given an array of integers nums, there is a sliding window of size k which is
/// moving from the very left of the array to the very right. You can only see the k numbers
/// in the window. Each time the sliding window moves right by one position.
/// 
/// Return the max sliding window.
/// 
/// Example:
/// Input: nums = [1,3,-1,-3,5,3,6,7], k = 3
/// Output: [3,3,5,5,6,7]
/// 
/// Constraints:
/// - 1 <= nums.length <= 10^5
/// - -10^4 <= nums[i] <= 10^4
/// - 1 <= k <= nums.length
/// </summary>
public class SlidingWindowMaximum
{
    public static int[] Solution(int[] nums, int k)
    {
        // TODO: Implement solution
        // Hint: Use deque (double-ended queue) to maintain window maximum
        // Time Complexity: O(n)
        // Space Complexity: O(k)
        
        return Array.Empty<int>();
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 6.3: Sliding Window Maximum ===");
        
        int[] test1 = { 1, 3, -1, -3, 5, 3, 6, 7 };
        int k1 = 3;
        int[] result1 = Solution(test1, k1);
        Console.WriteLine($"Test 1 - Input: nums = [1,3,-1,-3,5,3,6,7], k = {k1}");
        Console.WriteLine($"         Output: [{string.Join(", ", result1)}], Expected: [3,3,5,5,6,7]");
        int[] expected1 = { 3, 3, 5, 5, 6, 7 };
        bool passed1 = result1.Length == expected1.Length && result1[0] == expected1[0] && result1[5] == expected1[5];
        Console.WriteLine($"         {(passed1 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[] test2 = { 1 };
        int k2 = 1;
        int[] result2 = Solution(test2, k2);
        Console.WriteLine($"Test 2 - Input: nums = [1], k = {k2}");
        Console.WriteLine($"         Output: [{string.Join(", ", result2)}], Expected: [1]");
        bool passed2 = result2.Length == 1 && result2[0] == 1;
        Console.WriteLine($"         {(passed2 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

