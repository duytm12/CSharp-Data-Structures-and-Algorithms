using System;

namespace DSA._5_3_FindMinInRotatedSortedArray_Medium;

/// <summary>
/// Problem 5.3 (Medium): Find Minimum in Rotated Sorted Array
/// Suppose an array of length n sorted in ascending order is rotated between 1 and n times.
/// Find the minimum element of this array.
/// 
/// Example:
/// Input: nums = [3,4,5,1,2]
/// Output: 1
/// Explanation: The original array was [1,2,3,4,5] rotated 3 times.
/// 
/// Constraints:
/// - n == nums.length
/// - 1 <= n <= 5000
/// - -5000 <= nums[i] <= 5000
/// - All the integers of nums are unique.
/// - nums is sorted and rotated between 1 and n times.
/// </summary>
public class FindMinInRotatedSortedArray
{
    public static int Solution(int[] nums)
    {
        // TODO: Implement solution
        // Hint: Binary search comparing mid with right boundary
        // Time Complexity: O(log n)
        // Space Complexity: O(1)
        
        return 0;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 5.3: Find Minimum in Rotated Sorted Array ===");
        
        int[] test1 = { 3, 4, 5, 1, 2 };
        int result1 = Solution(test1);
        Console.WriteLine($"Test 1 - Input: [3, 4, 5, 1, 2]");
        Console.WriteLine($"         Output: {result1}, Expected: 1");
        Console.WriteLine($"         {(result1 == 1 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[] test2 = { 4, 5, 6, 7, 0, 1, 2 };
        int result2 = Solution(test2);
        Console.WriteLine($"Test 2 - Input: [4, 5, 6, 7, 0, 1, 2]");
        Console.WriteLine($"         Output: {result2}, Expected: 0");
        Console.WriteLine($"         {(result2 == 0 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

