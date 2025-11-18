using System;
using System.Collections.Generic;

namespace DSA._12_5_LastStoneWeight_Easy;

/// <summary>
/// Problem 12.5 (Easy): Last Stone Weight
/// You are given an array of integers stones where stones[i] is the weight of the ith stone.
/// 
/// We are playing a game with the stones. On each turn, we choose the heaviest two stones and
/// smash them together. Suppose the heaviest two stones have weights x and y with x <= y.
/// The result of this smash is:
/// - If x == y, both stones are totally destroyed;
/// - If x != y, the stone of weight x is totally destroyed, and the stone of weight y has new weight y - x.
/// 
/// At the end of the game, there is at most one stone left.
/// 
/// Return the weight of the last remaining stone. If there are no stones left, return 0.
/// 
/// Example:
/// Input: stones = [2,7,4,1,8,1]
/// Output: 1
/// Explanation:
/// We combine 7 and 8 to get 1 so the array converts to [2,4,1,1,1] then,
/// we combine 2 and 4 to get 2 so the array converts to [2,1,1,1] then,
/// we combine 2 and 1 to get 1 so the array converts to [1,1,1] then,
/// we combine 1 and 1 to get 0 so the array converts to [1] then that's the value of last stone.
/// 
/// Constraints:
/// - 1 <= stones.length <= 30
/// - 1 <= stones[i] <= 1000
/// </summary>
public class LastStoneWeight
{
    public static int Solution(int[] stones)
    {
        // TODO: Implement solution
        // Hint: Use max heap (PriorityQueue), repeatedly pop two largest, push difference
        // Time Complexity: O(n log n)
        // Space Complexity: O(n)
        
        return 0;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 12.5: Last Stone Weight ===");
        
        int[] test1 = { 2, 7, 4, 1, 8, 1 };
        int result1 = Solution(test1);
        Console.WriteLine($"Test 1 - Input: [2,7,4,1,8,1]");
        Console.WriteLine($"         Output: {result1}, Expected: 1");
        Console.WriteLine($"         {(result1 == 1 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[] test2 = { 1 };
        int result2 = Solution(test2);
        Console.WriteLine($"Test 2 - Input: [1]");
        Console.WriteLine($"         Output: {result2}, Expected: 1");
        Console.WriteLine($"         {(result2 == 1 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

