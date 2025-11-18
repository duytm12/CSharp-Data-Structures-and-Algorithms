using System;

namespace DSA._8_9_FindDuplicateNumber_Medium;

/// <summary>
/// Problem 8.9 (Medium): Find the Duplicate Number
/// Given an array of integers nums containing n + 1 integers where each integer is in the range [1, n] inclusive.
/// 
/// There is only one repeated number in nums, return this repeated number.
/// 
/// You must solve the problem without modifying the array nums and uses only constant extra space.
/// 
/// Example:
/// Input: nums = [1,3,4,2,2]
/// Output: 2
/// 
/// Constraints:
/// - 1 <= n <= 10^5
/// - nums.length == n + 1
/// - 1 <= nums[i] <= n
/// - All the integers in nums appear only once except for precisely one integer which appears two or more times.
/// </summary>
public class FindDuplicateNumber
{
    public static int FindDuplicate(int[] nums)
    {
        // TODO: Implement solution
        // Hint: Treat array as linked list, use Floyd's cycle detection (fast and slow pointers)
        // The duplicate creates a cycle in the linked list representation
        // Time Complexity: O(n)
        // Space Complexity: O(1)
        
        return 0;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 8.9: Find Duplicate Number ===");
        
        int[] test1 = { 1, 3, 4, 2, 2 };
        int result1 = FindDuplicate(test1);
        Console.WriteLine($"Test 1 - Input: [1,3,4,2,2]");
        Console.WriteLine($"         Output: {result1}, Expected: 2");
        Console.WriteLine($"         {(result1 == 2 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[] test2 = { 3, 1, 3, 4, 2 };
        int result2 = FindDuplicate(test2);
        Console.WriteLine($"Test 2 - Input: [3,1,3,4,2]");
        Console.WriteLine($"         Output: {result2}, Expected: 3");
        Console.WriteLine($"         {(result2 == 3 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

