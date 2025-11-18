using System;

namespace DSA._16_12_RedundantConnection_Medium;

/// <summary>
/// Problem 16.12 (Medium): Redundant Connection
/// In this problem, a tree is an undirected graph that is connected and has no cycles.
/// 
/// You are given a graph that started as a tree with n nodes labeled from 1 to n, with one additional
/// edge added. The added edge has two different vertices chosen from 1 to n, and was not an edge that
/// already existed. The graph is represented as an array edges of length n where edges[i] = [ai, bi]
/// indicates that there is an edge between nodes ai and bi in the graph.
/// 
/// Return an edge that can be removed so that the resulting graph is a tree of n nodes. If there are
/// multiple answers, return the answer that occurs last in the input.
/// 
/// Example:
/// Input: edges = [[1,2],[1,3],[2,3]]
/// Output: [2,3]
/// 
/// Constraints:
/// - n == edges.length
/// - 3 <= n <= 1000
/// - edges[i].length == 2
/// - 1 <= ai < bi <= edges.length
/// - ai != bi
/// - There are no repeated edges.
/// - The given graph is connected.
/// </summary>
public class RedundantConnection
{
    public static int[] FindRedundantConnection(int[][] edges)
    {
        // TODO: Implement solution
        // Hint: Use Union-Find, return edge that creates cycle
        // Time Complexity: O(n * α(n)) where α is inverse Ackermann function
        // Space Complexity: O(n)
        
        return Array.Empty<int>();
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 16.12: Redundant Connection ===");
        
        int[][] test1 = new int[][] { new int[] { 1, 2 }, new int[] { 1, 3 }, new int[] { 2, 3 } };
        var result1 = FindRedundantConnection(test1);
        Console.WriteLine($"Test 1 - Input: edges = [[1,2],[1,3],[2,3]]");
        Console.WriteLine($"         Output: [{result1[0]},{result1[1]}], Expected: [2,3]");
        bool passed1 = (result1[0] == 2 && result1[1] == 3) || (result1[0] == 1 && result1[1] == 3);
        Console.WriteLine($"         {(passed1 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[][] test2 = new int[][] { new int[] { 1, 2 }, new int[] { 2, 3 }, new int[] { 3, 4 }, new int[] { 1, 4 }, new int[] { 1, 5 } };
        var result2 = FindRedundantConnection(test2);
        Console.WriteLine($"Test 2 - Input: edges = [[1,2],[2,3],[3,4],[1,4],[1,5]]");
        Console.WriteLine($"         Output: [{result2[0]},{result2[1]}]");
        bool passed2 = result2.Length == 2;
        Console.WriteLine($"         {(passed2 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

