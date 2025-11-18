using System;

namespace DSA._3_2_ContainerWithMostWater_Medium;

/// <summary>
/// Problem 3.2 (Medium): Container With Most Water
/// You are given an integer array height of length n. There are n vertical lines drawn such that
/// the two endpoints of the ith line are (i, 0) and (i, height[i]). Find two lines that together
/// with the x-axis form a container, such that the container contains the most water.
/// 
/// Example:
/// Input: height = [1,8,6,2,5,4,8,3,7]
/// Output: 49
/// Explanation: The above vertical lines are represented by array [1,8,6,2,5,4,8,3,7].
/// In this case, the max area of water the container can contain is 49.
/// 
/// Constraints:
/// - n == height.length
/// - 2 <= n <= 10^5
/// - 0 <= height[i] <= 10^4
/// </summary>
public class ContainerWithMostWater
{
    public static int Solution(int[] height)
    {
        // TODO: Implement solution
        // Hint: Two pointers at start and end, move pointer with smaller height
        // Time Complexity: O(n)
        // Space Complexity: O(1)
        
        return 0;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 3.2: Container With Most Water ===");
        
        int[] test1 = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
        int result1 = Solution(test1);
        Console.WriteLine($"Test 1 - Input: [1, 8, 6, 2, 5, 4, 8, 3, 7]");
        Console.WriteLine($"         Output: {result1}, Expected: 49");
        Console.WriteLine($"         {(result1 == 49 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[] test2 = { 1, 1 };
        int result2 = Solution(test2);
        Console.WriteLine($"Test 2 - Input: [1, 1]");
        Console.WriteLine($"         Output: {result2}, Expected: 1");
        Console.WriteLine($"         {(result2 == 1 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

