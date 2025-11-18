using System;

namespace DSA._20_5_MissingNumber_Easy;

/// <summary>
/// Problem 20.5 (Easy): Missing Number
/// Given an array nums containing n distinct numbers in the range [0, n], return the only
/// number in the range that is missing from the array.
/// 
/// Example:
/// Input: nums = [3,0,1]
/// Output: 2
/// Explanation: n = 3 since there are 3 numbers, so all numbers are in the range [0,3].
/// 2 is the missing number in the range since it does not appear in nums.
/// 
/// Constraints:
/// - n == nums.length
/// - 1 <= n <= 10^4
/// - 0 <= nums[i] <= n
/// - All the numbers of nums are unique.
/// </summary>
public class MissingNumber
{
    public static int Solution(int[] nums)
    {
        // TODO: Implement solution
        // Hint: XOR approach - XOR all numbers from 0 to n with all numbers in array
        // Missing number will remain
        // Alternative: Sum formula - expected sum - actual sum
        // Time Complexity: O(n)
        // Space Complexity: O(1)
        
        return 0;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 20.5: Missing Number ===");
        
        int[] test1 = { 3, 0, 1 };
        int result1 = Solution(test1);
        Console.WriteLine($"Test 1 - Input: [3,0,1]");
        Console.WriteLine($"         Output: {result1}, Expected: 2");
        Console.WriteLine($"         {(result1 == 2 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[] test2 = { 0, 1 };
        int result2 = Solution(test2);
        Console.WriteLine($"Test 2 - Input: [0,1]");
        Console.WriteLine($"         Output: {result2}, Expected: 2");
        Console.WriteLine($"         {(result2 == 2 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

