using System;

namespace DSA._16_1_NumberOfIslands_Medium;

/// <summary>
/// Problem 16.1 (Medium): Number of Islands
/// Given an m x n 2D binary grid which represents a map of '1's (land) and '0's (water),
/// return the number of islands.
/// 
/// Example:
/// Input: grid = [
///   ["1","1","1","1","0"],
///   ["1","1","0","1","0"],
///   ["1","1","0","0","0"],
///   ["0","0","0","0","0"]
/// ]
/// Output: 1
/// </summary>
public class NumberOfIslands
{
    public static int Solution(char[][] grid)
    {
        // TODO: Implement solution
        // Hint: DFS or BFS to mark connected components
        // Time Complexity: O(m * n)
        // Space Complexity: O(m * n) worst case for recursion
        
        return 0;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 16.1: Number of Islands ===");
        
        char[][] test1 = new char[][]
        {
            new char[] { '1', '1', '1', '1', '0' },
            new char[] { '1', '1', '0', '1', '0' },
            new char[] { '1', '1', '0', '0', '0' },
            new char[] { '0', '0', '0', '0', '0' }
        };
        int result1 = Solution(test1);
        Console.WriteLine($"Test 1 - Input: 4x5 grid");
        Console.WriteLine($"         Output: {result1}, Expected: 1");
        Console.WriteLine($"         {(result1 == 1 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        char[][] test2 = new char[][]
        {
            new char[] { '1', '1', '0', '0', '0' },
            new char[] { '1', '1', '0', '0', '0' },
            new char[] { '0', '0', '1', '0', '0' },
            new char[] { '0', '0', '0', '1', '1' }
        };
        int result2 = Solution(test2);
        Console.WriteLine($"Test 2 - Input: 4x5 grid");
        Console.WriteLine($"         Output: {result2}, Expected: 3");
        Console.WriteLine($"         {(result2 == 3 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

