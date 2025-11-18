using System;

namespace DSA._21_3_SetMatrixZeroes_Medium;

/// <summary>
/// Problem 21.3 (Medium): Set Matrix Zeroes
/// Given an m x n integer matrix matrix, if an element is 0, set its entire row and column to 0's.
/// 
/// You must do it in place.
/// 
/// Example:
/// Input: matrix = [[1,1,1],[1,0,1],[1,1,1]]
/// Output: [[1,0,1],[0,0,0],[1,0,1]]
/// 
/// Constraints:
/// - m == matrix.length
/// - n == matrix[0].length
/// - 1 <= m, n <= 200
/// - -2^31 <= matrix[i][j] <= 2^31 - 1
/// </summary>
public class SetMatrixZeroes
{
    public static void SetZeroes(int[][] matrix)
    {
        // TODO: Implement solution
        // Hint: Use first row and column as markers
        // First pass: mark rows/cols that need to be zeroed
        // Second pass: set zeros based on markers
        // Time Complexity: O(m * n)
        // Space Complexity: O(1)
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 21.3: Set Matrix Zeroes ===");
        
        int[][] test1 = new int[][]
        {
            new int[] { 1, 1, 1 },
            new int[] { 1, 0, 1 },
            new int[] { 1, 1, 1 }
        };
        SetZeroes(test1);
        Console.WriteLine($"Test 1 - Input: 3x3 matrix");
        Console.WriteLine($"         Output: Matrix modified");
        bool passed1 = test1[0][1] == 0 && test1[1][0] == 0 && test1[1][2] == 0;
        Console.WriteLine($"         {(passed1 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[][] test2 = new int[][] { new int[] { 0, 1, 2, 0 }, new int[] { 3, 4, 5, 2 }, new int[] { 1, 3, 1, 5 } };
        SetZeroes(test2);
        Console.WriteLine($"Test 2 - Input: 3x4 matrix");
        Console.WriteLine($"         Output: Matrix modified");
        bool passed2 = test2[0][0] == 0 && test2[1][0] == 0;
        Console.WriteLine($"         {(passed2 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

