using System;
using System.Collections.Generic;

namespace DSA._7_3_LargestRectangleInHistogram_Hard;

/// <summary>
/// Problem 7.3 (Hard): Largest Rectangle in Histogram
/// Given an array of integers heights representing the histogram's bar height where the width
/// of each bar is 1, return the area of the largest rectangle in the histogram.
/// 
/// Example:
/// Input: heights = [2,1,5,6,2,3]
/// Output: 10
/// Explanation: The largest rectangle is shown in the red area, which has an area = 10 units.
/// 
/// Constraints:
/// - 1 <= heights.length <= 10^5
/// - 0 <= heights[i] <= 10^4
/// </summary>
public class LargestRectangleInHistogram
{
    public static int Solution(int[] heights)
    {
        // TODO: Implement solution
        // Hint: Monotonic stack to track increasing heights
        // Time Complexity: O(n)
        // Space Complexity: O(n)
        
        return 0;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 7.3: Largest Rectangle in Histogram ===");
        
        int[] test1 = { 2, 1, 5, 6, 2, 3 };
        int result1 = Solution(test1);
        Console.WriteLine($"Test 1 - Input: [2,1,5,6,2,3]");
        Console.WriteLine($"         Output: {result1}, Expected: 10");
        Console.WriteLine($"         {(result1 == 10 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[] test2 = { 2, 4 };
        int result2 = Solution(test2);
        Console.WriteLine($"Test 2 - Input: [2,4]");
        Console.WriteLine($"         Output: {result2}, Expected: 4");
        Console.WriteLine($"         {(result2 == 4 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

