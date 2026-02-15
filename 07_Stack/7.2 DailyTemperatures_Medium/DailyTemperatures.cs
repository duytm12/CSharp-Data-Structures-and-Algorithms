using System;
using System.Collections.Generic;
using System.IO.Pipelines;

namespace DSA._7_2_DailyTemperatures_Medium;

/// <summary>
/// Problem 7.2 (Medium): Daily Temperatures
/// Given an array of integers temperatures representing the daily temperatures, return an array
/// answer such that answer[i] is the number of days you have to wait after the ith day to
/// get a warmer temperature. If there is no future day for which this is possible, keep answer[i] == 0.
/// 
/// Example:
/// Input: temperatures = [73,74,75,71,69,72,76,73]
/// Output: [1,1,4,2,1,1,0,0]
/// 
/// Constraints:
/// - 1 <= temperatures.length <= 10^5
/// - 30 <= temperatures[i] <= 100
/// </summary>
public class DailyTemperatures
{
    public static int[] Solution(int[] temperatures)
    {
        // TODO: Implement solution
        // Hint: Monotonic stack - keep decreasing temperatures
        // Time Complexity: O(n)
        // Space Complexity: O(n)

        if (temperatures.Length == 1) return [0];

        var result = new int[temperatures.Length];
        var stack = new Stack<int>();

        for (int i = 0; i < temperatures.Length; i++)
        {
            while (stack.Count > 0 && temperatures[i] > temperatures[stack.Peek()])
            {
                int j = stack.Pop();
                result[j] = i - j;
            }
            stack.Push(i);
        }
       
        return result;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 7.2: Daily Temperatures ===");
        
        int[] test1 = { 73, 74, 75, 71, 69, 72, 76, 73 };
        int[] result1 = Solution(test1);
        Console.WriteLine($"Test 1 - Input: [73,74,75,71,69,72,76,73]");
        Console.WriteLine($"         Output: [{string.Join(", ", result1)}], Expected: [1,1,4,2,1,1,0,0]");
        int[] expected1 = { 1, 1, 4, 2, 1, 1, 0, 0 };
        bool passed1 = result1.Length == expected1.Length && result1[0] == expected1[0] && result1[2] == expected1[2];
        Console.WriteLine($"         {(passed1 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[] test2 = { 30, 40, 50, 60 };
        int[] result2 = Solution(test2);
        Console.WriteLine($"Test 2 - Input: [30,40,50,60]");
        Console.WriteLine($"         Output: [{string.Join(", ", result2)}], Expected: [1,1,1,0]");
        int[] expected2 = { 1, 1, 1, 0 };
        bool passed2 = result2.Length == expected2.Length && result2[0] == expected2[0];
        Console.WriteLine($"         {(passed2 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

