using System;
using System.Collections.Generic;

namespace DSA._17_3_CriticalConnections_Hard;

/// <summary>
/// Problem 17.3 (Hard): Critical Connections in a Network
/// There are n servers numbered from 0 to n-1 connected by undirected server-to-server connections.
/// A critical connection is a connection that, if removed, will make some servers unable to reach
/// some other server. Find all critical connections.
/// 
/// Example:
/// Input: n = 4, connections = [[0,1],[1,2],[2,0],[1,3]]
/// Output: [[1,3]]
/// </summary>
public class CriticalConnections
{
    public static IList<IList<int>> Solution(int n, IList<IList<int>> connections)
    {
        // TODO: Implement solution
        // Hint: Tarjan's algorithm to find bridges
        // Time Complexity: O(V + E)
        // Space Complexity: O(V + E)
        
        return new List<IList<int>>();
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 17.3: Critical Connections ===");
        
        var connections1 = new List<IList<int>>
        {
            new List<int> { 0, 1 },
            new List<int> { 1, 2 },
            new List<int> { 2, 0 },
            new List<int> { 1, 3 }
        };
        var result1 = Solution(4, connections1);
        Console.WriteLine($"Test 1 - Input: n = 4, connections = [[0,1],[1,2],[2,0],[1,3]]");
        Console.WriteLine($"         Output: {result1.Count} critical connections, Expected: 1");
        Console.WriteLine($"         {(result1.Count == 1 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        var connections2 = new List<IList<int>>
        {
            new List<int> { 0, 1 }
        };
        var result2 = Solution(2, connections2);
        Console.WriteLine($"Test 2 - Input: n = 2, connections = [[0,1]]");
        Console.WriteLine($"         Output: {result2.Count} critical connections, Expected: 1");
        Console.WriteLine($"         {(result2.Count == 1 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

