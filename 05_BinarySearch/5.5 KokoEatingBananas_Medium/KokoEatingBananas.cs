using System;
using System.Linq;

namespace DSA._5_5_KokoEatingBananas_Medium;

/// <summary>
/// Problem 5.5 (Medium): Koko Eating Bananas
/// Koko loves to eat bananas. There are n piles of bananas, the ith pile has piles[i] bananas.
/// The guards have gone and will come back in h hours.
/// 
/// Koko can decide her bananas-per-hour eating speed of k. Each hour, she chooses some pile of
/// bananas and eats k bananas from that pile. If the pile has less than k bananas, she eats all
/// of them instead and will not eat any more bananas during this hour.
/// 
/// Koko wants to finish eating all the bananas before the guards return.
/// 
/// Return the minimum integer k such that she can eat all the bananas within h hours.
/// 
/// Example:
/// Input: piles = [3,6,7,11], h = 8
/// Output: 4
/// 
/// Constraints:
/// - 1 <= piles.length <= 10^4
/// - piles.length <= h <= 10^9
/// - 1 <= piles[i] <= 10^9
/// </summary>
public class KokoEatingBananas
{
    public static int MinEatingSpeed(int[] piles, int h)
    {
        // TODO: Implement solution
        // Hint: Binary search on the answer (eating speed k)
        // Check if a given speed k can finish all bananas in h hours
        // Time Complexity: O(n * log(max(piles)))
        // Space Complexity: O(1)
        
        return 0;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 5.5: Koko Eating Bananas ===");
        
        int[] test1 = { 3, 6, 7, 11 };
        int h1 = 8;
        int result1 = MinEatingSpeed(test1, h1);
        Console.WriteLine($"Test 1 - Input: piles = [3,6,7,11], h = {h1}");
        Console.WriteLine($"         Output: {result1}, Expected: 4");
        Console.WriteLine($"         {(result1 == 4 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[] test2 = { 30, 11, 23, 4, 20 };
        int h2 = 5;
        int result2 = MinEatingSpeed(test2, h2);
        Console.WriteLine($"Test 2 - Input: piles = [30,11,23,4,20], h = {h2}");
        Console.WriteLine($"         Output: {result2}, Expected: 30");
        Console.WriteLine($"         {(result2 == 30 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

