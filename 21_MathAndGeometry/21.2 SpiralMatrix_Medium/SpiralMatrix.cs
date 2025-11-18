using System;
using System.Collections.Generic;

namespace DSA._21_2_SpiralMatrix_Medium;

/// <summary>
/// Problem 21.2 (Medium): Spiral Matrix
/// Given an m x n matrix, return all elements of the matrix in spiral order.
/// 
/// Example:
/// Input: matrix = [[1,2,3],[4,5,6],[7,8,9]]
/// Output: [1,2,3,6,9,8,7,4,5]
/// 
/// Constraints:
/// - m == matrix.length
/// - n == matrix[i].length
/// - 1 <= m, n <= 10
/// - -100 <= matrix[i][j] <= 100
/// </summary>
public class SpiralMatrix
{
    public static IList<int> SpiralOrder(int[][] matrix)
    {
        // TODO: Implement solution
        // Hint: Use four boundaries: top, bottom, left, right
        // Traverse right -> down -> left -> up, shrink boundaries
        // Time Complexity: O(m * n)
        // Space Complexity: O(1) excluding output
        
        return new List<int>();
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 21.2: Spiral Matrix ===");
        
        int[][] test1 = new int[][]
        {
            new int[] { 1, 2, 3 },
            new int[] { 4, 5, 6 },
            new int[] { 7, 8, 9 }
        };
        var result1 = SpiralOrder(test1);
        Console.WriteLine($"Test 1 - Input: 3x3 matrix");
        Console.WriteLine($"         Output: [{string.Join(",", result1)}], Expected: [1,2,3,6,9,8,7,4,5]");
        bool passed1 = result1.Count == 9 && result1[0] == 1 && result1[8] == 5;
        Console.WriteLine($"         {(passed1 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[][] test2 = new int[][] { new int[] { 1, 2, 3, 4 }, new int[] { 5, 6, 7, 8 }, new int[] { 9, 10, 11, 12 } };
        var result2 = SpiralOrder(test2);
        Console.WriteLine($"Test 2 - Input: 3x4 matrix");
        Console.WriteLine($"         Output: [{string.Join(",", result2)}]");
        bool passed2 = result2.Count == 12;
        Console.WriteLine($"         {(passed2 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

