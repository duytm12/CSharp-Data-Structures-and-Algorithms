using System;

namespace DSA._5_1_BinarySearch_Easy;

/// <summary>
/// Problem 5.1 (Easy): Binary Search
/// Given an array of integers nums which is sorted in ascending order, and an integer target,
/// write a function to search target in nums. If target exists, then return its index.
/// Otherwise, return -1.
/// 
/// Example:
/// Input: nums = [-1,0,3,5,9,12], target = 9
/// Output: 4
/// Explanation: 9 exists in nums and its index is 4
/// 
/// Constraints:
/// - 1 <= nums.length <= 10^4
/// - -10^4 < nums[i], target < 10^4
/// - All the integers in nums are unique.
/// - nums is sorted in ascending order.
/// </summary>
public class BinarySearch
{
    public static int Solution(int[] nums, int target)
    {
        // TODO: Implement solution
        // Hint: Classic binary search with left and right pointers
        // Time Complexity: O(log n)
        // Space Complexity: O(1)
        
        return -1;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 5.1: Binary Search ===");
        
        int[] test1 = { -1, 0, 3, 5, 9, 12 };
        int target1 = 9;
        int result1 = Solution(test1, target1);
        Console.WriteLine($"Test 1 - Input: nums = [-1,0,3,5,9,12], target = {target1}");
        Console.WriteLine($"         Output: {result1}, Expected: 4");
        Console.WriteLine($"         {(result1 == 4 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[] test2 = { -1, 0, 3, 5, 9, 12 };
        int target2 = 2;
        int result2 = Solution(test2, target2);
        Console.WriteLine($"Test 2 - Input: nums = [-1,0,3,5,9,12], target = {target2}");
        Console.WriteLine($"         Output: {result2}, Expected: -1");
        Console.WriteLine($"         {(result2 == -1 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

