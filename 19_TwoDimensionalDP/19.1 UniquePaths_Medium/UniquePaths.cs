using System;

namespace DSA._19_1_UniquePaths_Medium;

/// <summary>
/// Problem 19.1 (Medium): Unique Paths
/// There is a robot on an m x n grid. The robot is initially located at the top-left corner
/// (i.e., grid[0][0]). The robot tries to move to the bottom-right corner (i.e., grid[m - 1][n - 1]).
/// The robot can only move either down or right at any point in time.
/// 
/// Given the two integers m and n, return the number of possible unique paths that the robot
/// can take to reach the bottom-right corner.
/// 
/// Example:
/// Input: m = 3, n = 7
/// Output: 28
/// 
/// Constraints:
/// - 1 <= m, n <= 100
/// </summary>
public class UniquePaths
{
    public static int Solution(int m, int n)
    {
        // TODO: Implement solution
        // Hint: DP[i][j] = number of ways to reach (i,j)
        // DP[i][j] = DP[i-1][j] + DP[i][j-1]
        // Time Complexity: O(m * n)
        // Space Complexity: O(m * n) or O(min(m,n)) optimized
        
        return 0;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 19.1: Unique Paths ===");
        
        int result1 = Solution(3, 7);
        Console.WriteLine($"Test 1 - Input: m = 3, n = 7");
        Console.WriteLine($"         Output: {result1}, Expected: 28");
        Console.WriteLine($"         {(result1 == 28 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int result2 = Solution(3, 2);
        Console.WriteLine($"Test 2 - Input: m = 3, n = 2");
        Console.WriteLine($"         Output: {result2}, Expected: 3");
        Console.WriteLine($"         {(result2 == 3 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}
