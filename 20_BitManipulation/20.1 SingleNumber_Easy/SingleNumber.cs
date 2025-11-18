using System;

namespace DSA._20_1_SingleNumber_Easy;

/// <summary>
/// Problem 20.1 (Easy): Single Number
/// Given a non-empty array of integers nums, every element appears twice except for one.
/// Find that single one.
/// 
/// You must implement a solution with a linear runtime complexity and use only constant extra space.
/// 
/// Example:
/// Input: nums = [2,2,1]
/// Output: 1
/// 
/// Example 2:
/// Input: nums = [4,1,2,1,2]
/// Output: 4
/// 
/// Constraints:
/// - 1 <= nums.length <= 3 * 10^4
/// - -3 * 10^4 <= nums[i] <= 3 * 10^4
/// - Each element in the array appears twice except for one element which appears only once.
/// </summary>
public class SingleNumber
{
    public static int Solution(int[] nums)
    {
        // TODO: Implement solution
        // Hint: Use XOR operation - a ^ a = 0, a ^ 0 = a
        // XOR all numbers, duplicates cancel out, leaving the single number
        // Time Complexity: O(n)
        // Space Complexity: O(1)
        
        return 0;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 20.1: Single Number ===");
        
        int[] test1 = { 2, 2, 1 };
        int result1 = Solution(test1);
        Console.WriteLine($"Test 1 - Input: [2,2,1]");
        Console.WriteLine($"         Output: {result1}, Expected: 1");
        Console.WriteLine($"         {(result1 == 1 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[] test2 = { 4, 1, 2, 1, 2 };
        int result2 = Solution(test2);
        Console.WriteLine($"Test 2 - Input: [4,1,2,1,2]");
        Console.WriteLine($"         Output: {result2}, Expected: 4");
        Console.WriteLine($"         {(result2 == 4 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

