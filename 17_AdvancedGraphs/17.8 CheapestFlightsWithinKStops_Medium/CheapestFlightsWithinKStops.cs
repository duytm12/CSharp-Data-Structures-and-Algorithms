using System;
using System.Collections.Generic;

namespace DSA._17_8_CheapestFlightsWithinKStops_Medium;

/// <summary>
/// Problem 17.8 (Medium): Cheapest Flights Within K Stops
/// There are n cities connected by some number of flights. You are given an array flights where
/// flights[i] = [fromi, toi, pricei] indicates that there is a flight from city fromi to city
/// toi with cost pricei.
/// 
/// You are also given three integers src, dst, and k, return the cheapest price from src to dst
/// with at most k stops. If there is no such route, return -1.
/// 
/// Example:
/// Input: n = 4, flights = [[0,1,100],[1,2,100],[2,0,100],[1,3,600],[2,3,200]], src = 0, dst = 3, k = 1
/// Output: 700
/// Explanation:
/// The graph is shown above.
/// The optimal path with at most 1 stop from city 0 to 3 is marked in red and has cost 100 + 600 = 700.
/// Note that the path through cities [0,1,2,3] is cheaper but is invalid because it uses 2 stops.
/// 
/// Constraints:
/// - 1 <= n <= 100
/// - 0 <= flights.length <= (n * (n - 1) / 2)
/// - flights[i].length == 3
/// - 0 <= fromi, toi < n
/// - fromi != toi
/// - 1 <= pricei <= 10^4
/// - There will not be any multiple flights between two cities.
/// - 0 <= src, dst, k < n
/// - src != dst
/// </summary>
public class CheapestFlightsWithinKStops
{
    public static int FindCheapestPrice(int n, int[][] flights, int src, int dst, int k)
    {
        // TODO: Implement solution
        // Hint: Modified Dijkstra's or Bellman-Ford with k stops constraint
        // Track (node, stops) pairs, relax edges up to k stops
        // Time Complexity: O(E * k) with Bellman-Ford
        // Space Complexity: O(V)
        
        return -1;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 17.8: Cheapest Flights Within K Stops ===");
        
        int[][] test1 = new int[][]
        {
            new int[] { 0, 1, 100 },
            new int[] { 1, 2, 100 },
            new int[] { 2, 0, 100 },
            new int[] { 1, 3, 600 },
            new int[] { 2, 3, 200 }
        };
        int result1 = FindCheapestPrice(4, test1, 0, 3, 1);
        Console.WriteLine($"Test 1 - Input: n = 4, flights = [[0,1,100],[1,2,100],[2,0,100],[1,3,600],[2,3,200]], src = 0, dst = 3, k = 1");
        Console.WriteLine($"         Output: {result1}, Expected: 700");
        Console.WriteLine($"         {(result1 == 700 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[][] test2 = new int[][] { new int[] { 0, 1, 100 }, new int[] { 1, 2, 100 }, new int[] { 0, 2, 500 } };
        int result2 = FindCheapestPrice(3, test2, 0, 2, 1);
        Console.WriteLine($"Test 2 - Input: n = 3, flights = [[0,1,100],[1,2,100],[0,2,500]], src = 0, dst = 2, k = 1");
        Console.WriteLine($"         Output: {result2}, Expected: 200");
        Console.WriteLine($"         {(result2 == 200 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

