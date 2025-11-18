using System;
using System.Collections.Generic;
using System.Linq;

namespace DSA._2_4_RemoveDuplicates_Easy;

/// <summary>
/// Problem 2.4 (Easy): Remove Duplicates from List
/// Given a list of integers, remove all duplicates and return a new list containing only unique elements.
/// 
/// Example:
/// Input: [1, 2, 2, 3, 4, 4, 5]
/// Output: [1, 2, 3, 4, 5]
/// 
/// Constraints:
/// - 0 <= list.length <= 10^4
/// - -10^4 <= list[i] <= 10^4
/// </summary>
public class RemoveDuplicates
{
    public static List<int> Solution(List<int> list)
    {
        // TODO: Implement solution
        // Hint: Use HashSet<T> or LINQ Distinct()
        // Time Complexity: O(n)
        // Space Complexity: O(n)
        
        return new List<int>();
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 2.4: Remove Duplicates ===");
        
        var test1 = new List<int> { 1, 2, 2, 3, 4, 4, 5 };
        var result1 = Solution(test1);
        Console.WriteLine($"Test 1 - Input: [1, 2, 2, 3, 4, 4, 5]");
        Console.WriteLine($"         Output: [{string.Join(", ", result1)}], Expected: [1, 2, 3, 4, 5]");
        bool passed1 = result1.Count == 5 && result1[0] == 1 && result1[4] == 5;
        Console.WriteLine($"         {(passed1 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        var test2 = new List<int> { 1, 2, 3 };
        var result2 = Solution(test2);
        Console.WriteLine($"Test 2 - Input: [1, 2, 3]");
        Console.WriteLine($"         Output: [{string.Join(", ", result2)}]");
        bool passed2 = result2.Count == 3;
        Console.WriteLine($"         {(passed2 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

