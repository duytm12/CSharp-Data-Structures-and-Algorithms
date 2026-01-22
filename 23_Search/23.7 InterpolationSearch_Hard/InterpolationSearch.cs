using System;

namespace DSA._23_7_InterpolationSearch_Hard;

/// <summary>
/// Problem 23.7 (Hard): Interpolation Search
/// 
/// Interpolation Search is an improved variant of binary search for uniformly
/// distributed sorted arrays. It uses linear interpolation to estimate the position
/// of the target value, rather than always checking the middle element.
/// 
/// Key Formula:
/// pos = low + ((target - nums[low]) * (high - low)) / (nums[high] - nums[low])
/// 
/// This formula estimates where the target would be if values were uniformly
/// distributed. For uniformly distributed data, this often finds the target
/// in O(log log n) time instead of O(log n).
/// 
/// Time Complexity: O(log log n) average (uniform distribution), O(n) worst case
/// Space Complexity: O(1)
/// </summary>
public class InterpolationSearch
{
    public static int Solution(int[] nums, int target)
    {
        if (nums == null || nums.Length == 0)
            return -1;

        int left = 0;
        int right = nums.Length - 1;

        while (left <= right && target >= nums[left] && target <= nums[right])
        {
            // Handle edge case: if range has only one element
            if (left == right)
            {
                if (nums[left] == target)
                    return left;
                return -1;
            }

            int mid = left + (int)(((double)(target - nums[left]) * (right - left)) / (nums[right] - nums[left]));

            // Safety check: ensure mid is within bounds
            if (mid < left || mid > right)
                break;

            // Compare and adjust search range
            if (nums[mid] == target)
            {
                return mid; // Found!
            }
            else if (nums[mid] < target)
            {
                left = mid + 1; // Target is in right half
            }
            else
            {
                right = mid - 1; // Target is in left half
            }
        }

        return -1; // Target not found
    }

    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 23.7: Interpolation Search ===");

        // Test Case 1: Target found in uniformly distributed array
        int[] test1 = { 10, 12, 13, 16, 18, 19, 20, 21, 22, 23, 24, 33, 35, 42, 47 };
        int result1 = Solution(test1, 18);
        int expected1 = 4;
        Console.WriteLine($"Test 1 - Input: nums = [10, 12, 13, 16, 18, 19, 20, 21, 22, 23, 24, 33, 35, 42, 47], target = 18");
        Console.WriteLine($"         Output: {result1}, Expected: {expected1}");
        Console.WriteLine($"         {(result1 == expected1 ? "✓ PASSED" : "✗ FAILED")}\n");

        // Test Case 2: Target not found
        int[] test2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int result2 = Solution(test2, 11);
        int expected2 = -1;
        Console.WriteLine($"Test 2 - Input: nums = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10], target = 11");
        Console.WriteLine($"         Output: {result2}, Expected: {expected2}");
        Console.WriteLine($"         {(result2 == expected2 ? "✓ PASSED" : "✗ FAILED")}\n");

        // Test Case 3: Target at beginning
        int[] test3 = { 0, 10, 20, 30, 40, 50, 60, 70, 80, 90 };
        int result3 = Solution(test3, 0);
        int expected3 = 0;
        Console.WriteLine($"Test 3 - Input: nums = [0, 10, 20, 30, 40, 50, 60, 70, 80, 90], target = 0");
        Console.WriteLine($"         Output: {result3}, Expected: {expected3}");
        Console.WriteLine($"         {(result3 == expected3 ? "✓ PASSED" : "✗ FAILED")}\n");

        // Test Case 4: Target at end
        int[] test4 = { 5, 15, 25, 35, 45, 55, 65, 75, 85, 95 };
        int result4 = Solution(test4, 95);
        int expected4 = 9;
        Console.WriteLine($"Test 4 - Input: nums = [5, 15, 25, 35, 45, 55, 65, 75, 85, 95], target = 95");
        Console.WriteLine($"         Output: {result4}, Expected: {expected4}");
        Console.WriteLine($"         {(result4 == expected4 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}
