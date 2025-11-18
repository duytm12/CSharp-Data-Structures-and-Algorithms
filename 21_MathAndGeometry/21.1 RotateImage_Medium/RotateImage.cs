using System;

namespace DSA._21_1_RotateImage_Medium;

/// <summary>
/// Problem 21.1 (Medium): Rotate Image
/// You are given an n x n 2D matrix representing an image, rotate the image by 90 degrees (clockwise).
/// 
/// You have to rotate the image in-place, which means you have to modify the input 2D matrix directly.
/// DO NOT allocate another 2D matrix and do the rotation.
/// 
/// Example:
/// Input: matrix = [[1,2,3],[4,5,6],[7,8,9]]
/// Output: [[7,4,1],[8,5,2],[9,6,3]]
/// 
/// Constraints:
/// - n == matrix.length == matrix[i].length
/// - 1 <= n <= 20
/// - -1000 <= matrix[i][j] <= 1000
/// </summary>
public class RotateImage
{
    public static void Rotate(int[][] matrix)
    {
        // TODO: Implement solution
        // Hint: Transpose then reverse each row, or rotate in layers
        // For clockwise: transpose + reverse rows
        // Time Complexity: O(n^2)
        // Space Complexity: O(1)
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 21.1: Rotate Image ===");
        
        int[][] test1 = new int[][]
        {
            new int[] { 1, 2, 3 },
            new int[] { 4, 5, 6 },
            new int[] { 7, 8, 9 }
        };
        Rotate(test1);
        Console.WriteLine($"Test 1 - Input: 3x3 matrix");
        Console.WriteLine($"         Output: Matrix rotated");
        bool passed1 = test1[0][0] == 7 && test1[0][2] == 1 && test1[2][2] == 3;
        Console.WriteLine($"         {(passed1 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[][] test2 = new int[][] { new int[] { 1, 2 }, new int[] { 3, 4 } };
        Rotate(test2);
        Console.WriteLine($"Test 2 - Input: 2x2 matrix");
        Console.WriteLine($"         Output: Matrix rotated");
        bool passed2 = test2[0][0] == 3 && test2[0][1] == 1;
        Console.WriteLine($"         {(passed2 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

