using System;

namespace DSA._20_3_CountingBits_Easy;

/// <summary>
/// Problem 20.3 (Easy): Counting Bits
/// Given an integer n, return an array ans of length n + 1 such that for each i (0 <= i <= n),
/// ans[i] is the number of 1's in the binary representation of i.
/// 
/// Example:
/// Input: n = 2
/// Output: [0,1,1]
/// Explanation:
/// 0 --> 0
/// 1 --> 1
/// 2 --> 10
/// 
/// Constraints:
/// - 0 <= n <= 10^5
/// </summary>
public class CountingBits
{
    public static int[] CountBits(int n)
    {
        // TODO: Implement solution
        // Hint: DP approach - ans[i] = ans[i >> 1] + (i & 1)
        // Or: ans[i] = ans[i & (i - 1)] + 1
        // Time Complexity: O(n)
        // Space Complexity: O(n)
        
        return new int[n + 1];
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 20.3: Counting Bits ===");
        
        var result1 = CountBits(2);
        Console.WriteLine($"Test 1 - Input: n = 2");
        Console.WriteLine($"         Output: [{string.Join(",", result1)}], Expected: [0,1,1]");
        bool passed1 = result1.Length == 3 && result1[0] == 0 && result1[1] == 1 && result1[2] == 1;
        Console.WriteLine($"         {(passed1 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        var result2 = CountBits(5);
        Console.WriteLine($"Test 2 - Input: n = 5");
        Console.WriteLine($"         Output: [{string.Join(",", result2)}], Expected: [0,1,1,2,1,2]");
        bool passed2 = result2.Length == 6 && result2[0] == 0 && result2[5] == 2;
        Console.WriteLine($"         {(passed2 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

