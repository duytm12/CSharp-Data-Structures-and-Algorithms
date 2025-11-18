using System;
using System.Collections.Generic;

namespace DSA._16_11_NumberOfConnectedComponents_Medium;

/// <summary>
/// Problem 16.11 (Medium): Number of Connected Components in an Undirected Graph
/// You have a graph of n nodes. You are given an integer n and an array edges where edges[i] = [ai, bi]
/// indicates that there is an undirected edge between nodes ai and bi in the graph.
/// 
/// Return the number of connected components in the graph.
/// 
/// Example:
/// Input: n = 5, edges = [[0,1],[1,2],[3,4]]
/// Output: 2
/// 
/// Constraints:
/// - 1 <= n <= 2000
/// - 1 <= edges.length <= 5000
/// - edges[i].length == 2
/// - 0 <= ai <= bi < n
/// - ai != bi
/// - There are no repeated edges.
/// </summary>
public class NumberOfConnectedComponents
{
    public static int CountComponents(int n, int[][] edges)
    {
        // TODO: Implement solution
        // Hint: Use Union-Find or DFS to count connected components
        // Time Complexity: O(V + E)
        // Space Complexity: O(V)
        
        return 0;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 16.11: Number of Connected Components ===");
        
        int[][] test1 = new int[][] { new int[] { 0, 1 }, new int[] { 1, 2 }, new int[] { 3, 4 } };
        int result1 = CountComponents(5, test1);
        Console.WriteLine($"Test 1 - Input: n = 5, edges = [[0,1],[1,2],[3,4]]");
        Console.WriteLine($"         Output: {result1}, Expected: 2");
        Console.WriteLine($"         {(result1 == 2 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[][] test2 = new int[][] { new int[] { 0, 1 }, new int[] { 2, 3 }, new int[] { 4, 5 } };
        int result2 = CountComponents(6, test2);
        Console.WriteLine($"Test 2 - Input: n = 6, edges = [[0,1],[2,3],[4,5]]");
        Console.WriteLine($"         Output: {result2}, Expected: 3");
        Console.WriteLine($"         {(result2 == 3 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

