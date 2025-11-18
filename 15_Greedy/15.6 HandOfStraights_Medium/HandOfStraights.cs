using System;
using System.Collections.Generic;
using System.Linq;

namespace DSA._15_6_HandOfStraights_Medium;

/// <summary>
/// Problem 15.6 (Medium): Hand of Straights
/// Alice has some number of cards and she wants to rearrange the cards into groups so that each
/// group is of size groupSize, and consists of groupSize consecutive cards.
/// 
/// Given an integer array hand where hand[i] is the value written on the ith card and an integer
/// groupSize, return true if she can rearrange the cards, or false otherwise.
/// 
/// Example:
/// Input: hand = [1,2,3,6,2,3,4,7,8], groupSize = 3
/// Output: true
/// Explanation: Alice's hand can be rearranged as [1,2,3],[2,3,4],[6,7,8]
/// 
/// Constraints:
/// - 1 <= hand.length <= 10^4
/// - 0 <= hand[i] <= 10^9
/// - 1 <= groupSize <= hand.length
/// </summary>
public class HandOfStraights
{
    public static bool IsNStraightHand(int[] hand, int groupSize)
    {
        // TODO: Implement solution
        // Hint: Use Dictionary to count frequencies, sort and greedily form groups
        // Time Complexity: O(n log n)
        // Space Complexity: O(n)
        
        return false;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 15.6: Hand of Straights ===");
        
        int[] test1 = { 1, 2, 3, 6, 2, 3, 4, 7, 8 };
        bool result1 = IsNStraightHand(test1, 3);
        Console.WriteLine($"Test 1 - Input: hand = [1,2,3,6,2,3,4,7,8], groupSize = 3");
        Console.WriteLine($"         Output: {result1}, Expected: True");
        Console.WriteLine($"         {(result1 == true ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[] test2 = { 1, 2, 3, 4, 5 };
        bool result2 = IsNStraightHand(test2, 4);
        Console.WriteLine($"Test 2 - Input: hand = [1,2,3,4,5], groupSize = 4");
        Console.WriteLine($"         Output: {result2}, Expected: False");
        Console.WriteLine($"         {(result2 == false ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

