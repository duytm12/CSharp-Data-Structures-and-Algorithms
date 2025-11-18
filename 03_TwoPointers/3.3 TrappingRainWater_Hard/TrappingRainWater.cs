using System;

namespace DSA._3_3_TrappingRainWater_Hard;

/// <summary>
/// Problem 3.3 (Hard): Trapping Rain Water
/// Given n non-negative integers representing an elevation map where the width of each bar is 1,
/// compute how much water it can trap after raining.
/// 
/// Example:
/// Input: height = [0,1,0,2,1,0,1,3,2,1,2,1]
/// Output: 6
/// Explanation: The above elevation map (black section) is represented by array [0,1,0,2,1,0,1,3,2,1,2,1].
/// In this case, 6 units of rain water (blue section) are being trapped.
/// 
/// Constraints:
/// - n == height.length
/// - 1 <= n <= 2 * 10^4
/// - 0 <= height[i] <= 10^5
/// </summary>
public class TrappingRainWater
{
    public static int Solution(int[] height)
    {
        // TODO: Implement solution
        // Hint: Two pointers with maxLeft and maxRight tracking
        // Time Complexity: O(n)
        // Space Complexity: O(1)
        
        return 0;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 3.3: Trapping Rain Water ===");
        
        int[] test1 = { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
        int result1 = Solution(test1);
        Console.WriteLine($"Test 1 - Input: [0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1]");
        Console.WriteLine($"         Output: {result1}, Expected: 6");
        Console.WriteLine($"         {(result1 == 6 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[] test2 = { 4, 2, 0, 3, 2, 5 };
        int result2 = Solution(test2);
        Console.WriteLine($"Test 2 - Input: [4, 2, 0, 3, 2, 5]");
        Console.WriteLine($"         Output: {result2}, Expected: 9");
        Console.WriteLine($"         {(result2 == 9 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

