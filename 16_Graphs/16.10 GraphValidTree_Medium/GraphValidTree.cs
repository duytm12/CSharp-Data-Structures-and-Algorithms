using System;
using System.Collections.Generic;

namespace DSA._16_10_GraphValidTree_Medium;

/// <summary>
/// Problem 16.10 (Medium): Graph Valid Tree
/// You have a graph of n nodes labeled from 0 to n - 1. You are given an integer n and an array
/// edges where edges[i] = [ai, bi] indicates that there is an undirected edge between nodes ai and bi in the graph.
/// 
/// Return true if the edges of the given graph make up a valid tree, and false otherwise.
/// 
/// Example:
/// Input: n = 5, edges = [[0,1],[0,2],[0,3],[1,4]]
/// Output: true
/// 
/// Constraints:
/// - 1 <= n <= 2000
/// - 0 <= edges.length <= 5000
/// - edges[i].length == 2
/// - 0 <= ai <= bi < n
/// - ai != bi
/// - There are no self-loops or repeated edges.
/// </summary>
public class GraphValidTree
{
    public static bool ValidTree(int n, int[][] edges)
    {
        // TODO: Implement solution
        // Hint: Tree has n-1 edges and is connected (no cycles)
        // Use Union-Find or DFS to check connectivity and cycle
        // Time Complexity: O(V + E)
        // Space Complexity: O(V)
        
        return false;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 16.10: Graph Valid Tree ===");
        
        int[][] test1 = new int[][] { new int[] { 0, 1 }, new int[] { 0, 2 }, new int[] { 0, 3 }, new int[] { 1, 4 } };
        bool result1 = ValidTree(5, test1);
        Console.WriteLine($"Test 1 - Input: n = 5, edges = [[0,1],[0,2],[0,3],[1,4]]");
        Console.WriteLine($"         Output: {result1}, Expected: True");
        Console.WriteLine($"         {(result1 == true ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[][] test2 = new int[][] { new int[] { 0, 1 }, new int[] { 1, 2 }, new int[] { 2, 0 } };
        bool result2 = ValidTree(3, test2);
        Console.WriteLine($"Test 2 - Input: n = 3, edges = [[0,1],[1,2],[2,0]] (cycle)");
        Console.WriteLine($"         Output: {result2}, Expected: False");
        Console.WriteLine($"         {(result2 == false ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

