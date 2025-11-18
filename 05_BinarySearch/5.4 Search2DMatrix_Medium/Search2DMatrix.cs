using System;

namespace DSA._5_4_Search2DMatrix_Medium;

/// <summary>
/// Problem 5.4 (Medium): Search a 2D Matrix
/// You are given an m x n integer matrix matrix with the following two properties:
/// - Each row is sorted in non-decreasing order.
/// - The first integer of each row is greater than the last integer of the previous row.
/// 
/// Given an integer target, return true if target is in matrix or false otherwise.
/// 
/// Example:
/// Input: matrix = [[1,4,7,11],[2,5,8,12],[3,6,9,16],[10,13,14,17]], target = 5
/// Output: true
/// 
/// Constraints:
/// - m == matrix.length
/// - n == matrix[i].length
/// - 1 <= m, n <= 100
/// - -10^4 <= matrix[i][j], target <= 10^4
/// </summary>
public class Search2DMatrix
{
    public static bool SearchMatrix(int[][] matrix, int target)
    {
        // TODO: Implement solution
        // Hint: Treat 2D matrix as 1D sorted array, use binary search
        // Convert 1D index to 2D: row = index / n, col = index % n
        // Time Complexity: O(log(m * n))
        // Space Complexity: O(1)
        
        return false;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 5.4: Search 2D Matrix ===");
        
        int[][] test1 = new int[][]
        {
            new int[] { 1, 4, 7, 11 },
            new int[] { 2, 5, 8, 12 },
            new int[] { 3, 6, 9, 16 },
            new int[] { 10, 13, 14, 17 }
        };
        int target1 = 5;
        bool result1 = SearchMatrix(test1, target1);
        Console.WriteLine($"Test 1 - Input: matrix with target = {target1}");
        Console.WriteLine($"         Output: {result1}, Expected: True");
        Console.WriteLine($"         {(result1 == true ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[][] test2 = new int[][]
        {
            new int[] { 1, 4, 7, 11 },
            new int[] { 2, 5, 8, 12 },
            new int[] { 3, 6, 9, 16 },
            new int[] { 10, 13, 14, 17 }
        };
        int target2 = 15;
        bool result2 = SearchMatrix(test2, target2);
        Console.WriteLine($"Test 2 - Input: matrix with target = {target2}");
        Console.WriteLine($"         Output: {result2}, Expected: False");
        Console.WriteLine($"         {(result2 == false ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

