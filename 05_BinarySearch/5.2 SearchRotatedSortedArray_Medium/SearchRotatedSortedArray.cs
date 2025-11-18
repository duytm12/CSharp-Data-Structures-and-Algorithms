using System;

namespace DSA._5_2_SearchRotatedSortedArray_Medium;

/// <summary>
/// Problem 5.2 (Medium): Search in Rotated Sorted Array
/// There is an integer array nums sorted in ascending order (with distinct values).
/// The array is rotated at an unknown pivot index k (0-indexed).
/// 
/// Example:
/// Input: nums = [4,5,6,7,0,1,2], target = 0
/// Output: 4
/// 
/// Constraints:
/// - 1 <= nums.length <= 5000
/// - -10^4 <= nums[i] <= 10^4
/// - All values of nums are unique.
/// - nums is an ascending array that is possibly rotated.
/// - -10^4 <= target <= 10^4
/// </summary>
public class SearchRotatedSortedArray
{
    public static int Solution(int[] nums, int target)
    {
        // TODO: Implement solution
        // Hint: Modified binary search, check which half is sorted
        // Time Complexity: O(log n)
        // Space Complexity: O(1)
        
        return -1;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 5.2: Search Rotated Sorted Array ===");
        
        int[] test1 = { 4, 5, 6, 7, 0, 1, 2 };
        int target1 = 0;
        int result1 = Solution(test1, target1);
        Console.WriteLine($"Test 1 - Input: nums = [4,5,6,7,0,1,2], target = {target1}");
        Console.WriteLine($"         Output: {result1}, Expected: 4");
        Console.WriteLine($"         {(result1 == 4 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[] test2 = { 4, 5, 6, 7, 0, 1, 2 };
        int target2 = 3;
        int result2 = Solution(test2, target2);
        Console.WriteLine($"Test 2 - Input: nums = [4,5,6,7,0,1,2], target = {target2}");
        Console.WriteLine($"         Output: {result2}, Expected: -1");
        Console.WriteLine($"         {(result2 == -1 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

