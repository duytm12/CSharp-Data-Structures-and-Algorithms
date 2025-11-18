using System;
using System.Collections.Generic;

namespace DSA._17_2_NetworkDelayTime_Medium;

/// <summary>
/// Problem 17.2 (Medium): Network Delay Time
/// You are given a network of n nodes, labeled from 1 to n. You are also given times, a list
/// of travel times as directed edges. Return the minimum time it takes for all the n nodes
/// to receive the signal.
/// 
/// Example:
/// Input: times = [[2,1,1],[2,3,1],[3,4,1]], n = 4, k = 2
/// Output: 2
/// </summary>
public class NetworkDelayTime
{
    public static int Solution(int[][] times, int n, int k)
    {
        // TODO: Implement solution
        // Hint: Dijkstra's algorithm for shortest path
        // Time Complexity: O(E log V)
        // Space Complexity: O(V + E)
        
        return -1;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 17.2: Network Delay Time ===");
        
        int[][] test1 = new int[][] { new int[] { 2, 1, 1 }, new int[] { 2, 3, 1 }, new int[] { 3, 4, 1 } };
        int result1 = Solution(test1, 4, 2);
        Console.WriteLine($"Test 1 - Input: times = [[2,1,1],[2,3,1],[3,4,1]], n = 4, k = 2");
        Console.WriteLine($"         Output: {result1}, Expected: 2");
        Console.WriteLine($"         {(result1 == 2 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[][] test2 = new int[][] { new int[] { 1, 2, 1 } };
        int result2 = Solution(test2, 2, 1);
        Console.WriteLine($"Test 2 - Input: times = [[1,2,1]], n = 2, k = 1");
        Console.WriteLine($"         Output: {result2}, Expected: 1");
        Console.WriteLine($"         {(result2 == 1 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

