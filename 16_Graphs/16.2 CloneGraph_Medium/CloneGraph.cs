using System;
using System.Collections.Generic;

namespace DSA._16_2_CloneGraph_Medium;

/// <summary>
/// Problem 16.2 (Medium): Clone Graph
/// Given a reference of a node in a connected undirected graph, return a deep copy (clone) of the graph.
/// 
/// Example:
/// Input: adjList = [[2,4],[1,3],[2,4],[1,3]]
/// Output: [[2,4],[1,3],[2,4],[1,3]]
/// </summary>
public class Node
{
    public int val;
    public List<Node> neighbors;
    
    public Node()
    {
        val = 0;
        neighbors = new List<Node>();
    }
    
    public Node(int _val)
    {
        val = _val;
        neighbors = new List<Node>();
    }
    
    public Node(int _val, List<Node> _neighbors)
    {
        val = _val;
        neighbors = _neighbors;
    }
}

public class CloneGraph
{
    public static Node? Solution(Node? node)
    {
        // TODO: Implement solution
        // Hint: Use HashMap to map old nodes to new nodes, DFS/BFS
        // Time Complexity: O(V + E)
        // Space Complexity: O(V)
        
        return null;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 16.2: Clone Graph ===");
        
        var node1 = new Node(1);
        var node2 = new Node(2);
        var node3 = new Node(3);
        var node4 = new Node(4);
        node1.neighbors.Add(node2);
        node1.neighbors.Add(node4);
        node2.neighbors.Add(node1);
        node2.neighbors.Add(node3);
        node3.neighbors.Add(node2);
        node3.neighbors.Add(node4);
        node4.neighbors.Add(node1);
        node4.neighbors.Add(node3);
        
        var result1 = Solution(node1);
        Console.WriteLine($"Test 1 - Input: graph with 4 nodes");
        Console.WriteLine($"         Output: {(result1 != null ? "Graph cloned" : "null")}");
        bool passed1 = result1 != null && result1.val == 1;
        Console.WriteLine($"         {(passed1 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        var result2 = Solution(null);
        Console.WriteLine($"Test 2 - Input: null");
        Console.WriteLine($"         Output: {(result2 == null ? "null" : "not null")}, Expected: null");
        Console.WriteLine($"         {(result2 == null ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

