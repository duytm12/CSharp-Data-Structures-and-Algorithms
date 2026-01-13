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

        // return [..list.ToHashSet()];
        return [..list.Distinct()];

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
        
        // Test Case 3: Empty list
        var test3 = new List<int>();
        var result3 = Solution(test3);
        Console.WriteLine($"Test 3 - Input: []");
        Console.WriteLine($"         Output: [{string.Join(", ", result3)}], Expected: []");
        bool passed3 = result3.Count == 0;
        Console.WriteLine($"         {(passed3 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        // Test Case 4: All same elements and negative numbers
        var test4 = new List<int> { 5, 5, 5, 5, -1, -1, -2, 0, 0 };
        var result4 = Solution(test4);
        Console.WriteLine($"Test 4 - Input: [5, 5, 5, 5, -1, -1, -2, 0, 0]");
        Console.WriteLine($"         Output: [{string.Join(", ", result4)}], Expected: [5, -1, -2, 0] (order may vary)");
        bool passed4 = result4.Count == 4 && 
                       result4.Contains(5) && 
                       result4.Contains(-1) && 
                       result4.Contains(-2) && 
                       result4.Contains(0);
        Console.WriteLine($"         {(passed4 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

