using System;

namespace DSA._15_2_JumpGame_Medium;

/// <summary>
/// Problem 15.2 (Medium): Jump Game
/// You are given an integer array nums. You are initially positioned at the array's first index,
/// and each element in the array represents your maximum jump length at that position.
/// Return true if you can reach the last index, or false otherwise.
/// 
/// Example:
/// Input: nums = [2,3,1,1,4]
/// Output: true
/// </summary>
public class JumpGame
{
    public static bool Solution(int[] nums)
    {
        // TODO: Implement solution
        // Hint: Track farthest reachable index
        // Time Complexity: O(n)
        // Space Complexity: O(1)
        
        return false;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 15.2: Jump Game ===");
        
        int[] test1 = { 2, 3, 1, 1, 4 };
        bool result1 = Solution(test1);
        Console.WriteLine($"Test 1 - Input: [2,3,1,1,4]");
        Console.WriteLine($"         Output: {result1}, Expected: True");
        Console.WriteLine($"         {(result1 == true ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[] test2 = { 3, 2, 1, 0, 4 };
        bool result2 = Solution(test2);
        Console.WriteLine($"Test 2 - Input: [3,2,1,0,4]");
        Console.WriteLine($"         Output: {result2}, Expected: False");
        Console.WriteLine($"         {(result2 == false ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

