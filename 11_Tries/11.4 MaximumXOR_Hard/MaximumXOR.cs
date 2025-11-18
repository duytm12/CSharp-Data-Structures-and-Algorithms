using System;

namespace DSA._11_4_MaximumXOR_Hard;

/// <summary>
/// Problem 11.4 (Hard): Maximum XOR of Two Numbers in an Array
/// Given an integer array nums, return the maximum result of nums[i] XOR nums[j].
/// 
/// Example:
/// Input: nums = [3,10,5,25,2,8]
/// Output: 28 (5 XOR 25 = 28)
/// </summary>
public class MaximumXOR
{
    public static int Solution(int[] nums)
    {
        // TODO: Implement solution
        // Hint: Use trie to store binary representations, find maximum XOR
        // Time Complexity: O(n * 32) = O(n)
        // Space Complexity: O(n * 32)
        
        return 0;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 11.4: Maximum XOR ===");
        
        int[] test1 = { 3, 10, 5, 25, 2, 8 };
        int result1 = Solution(test1);
        Console.WriteLine($"Test 1 - Input: [3,10,5,25,2,8]");
        Console.WriteLine($"         Output: {result1}, Expected: 28");
        Console.WriteLine($"         {(result1 == 28 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[] test2 = { 14, 70, 53, 83, 49, 91, 36, 80, 92, 51, 66, 70 };
        int result2 = Solution(test2);
        Console.WriteLine($"Test 2 - Input: [14,70,53,83,49,91,36,80,92,51,66,70]");
        Console.WriteLine($"         Output: {result2}, Expected: 127");
        Console.WriteLine($"         {(result2 == 127 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

