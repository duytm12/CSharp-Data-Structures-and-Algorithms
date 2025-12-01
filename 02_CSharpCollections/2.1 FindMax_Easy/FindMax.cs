using System;
using System.Collections.Generic;
using System.Linq;

namespace DSA._2_1_FindMax_Easy;

/// <summary>
/// Problem 2.1 (Easy): List Operations - Find Maximum
/// Given a list of integers, find the maximum value using List&lt;T&gt; methods.
/// 
/// Example:
/// Input: [3, 7, 2, 9, 1]
/// Output: 9
/// </summary>
public class FindMax
{
    public static int Solution(List<int> numbers)
    {
        // TODO: Implement solution
        // Hint: Use LINQ Max() or manual iteration
        // Time Complexity: O(n)
        // Space Complexity: O(1)

        // Solution 1: Sort the list
        // numbers.Sort();
        //return numbers.Last();

        // Solution 2: LinQ Max
        //int result = numbers.Max();
        return numbers.Max();
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 2.1: Find Maximum ===");
        
        var test1 = new List<int> { 3, 7, 2, 9, 1 };
        int result1 = Solution(test1);
        Console.WriteLine($"Test 1 - Input: [3, 7, 2, 9, 1]");
        Console.WriteLine($"         Output: {result1}, Expected: 9");
        Console.WriteLine($"         {(result1 == 9 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        var test2 = new List<int> { 5 };
        int result2 = Solution(test2);
        Console.WriteLine($"Test 2 - Input: [5]");
        Console.WriteLine($"         Output: {result2}, Expected: 5");
        Console.WriteLine($"         {(result2 == 5 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

