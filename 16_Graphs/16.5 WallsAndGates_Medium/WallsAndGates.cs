using System;
using System.Collections.Generic;

namespace DSA._16_5_WallsAndGates_Medium;

/// <summary>
/// Problem 16.5 (Medium): Walls and Gates
/// You are given an m x n grid rooms initialized with these three possible values:
/// - -1 A wall or an obstacle.
/// - 0 A gate.
/// - INF Infinity means an empty room. We use the value 2^31 - 1 = 2147483647 to represent INF.
/// 
/// Fill each empty room with the distance to its nearest gate. If it is impossible to reach a gate,
/// it should remain filled with INF.
/// 
/// Example:
/// Input: rooms = [[2147483647,-1,0,2147483647],[2147483647,2147483647,2147483647,-1],[2147483647,-1,2147483647,-1],[0,-1,2147483647,2147483647]]
/// Output: [[3,-1,0,1],[2,2,1,-1],[1,-1,2,-1],[0,-1,3,4]]
/// 
/// Constraints:
/// - m == rooms.length
/// - n == rooms[i].length
/// - 1 <= m, n <= 250
/// - rooms[i][j] is -1, 0, or 2^31 - 1.
/// </summary>
public class WallsAndGates
{
    public static void WallsAndGatesSolution(int[][] rooms)
    {
        // TODO: Implement solution
        // Hint: Multi-source BFS starting from all gates simultaneously
        // Time Complexity: O(m * n)
        // Space Complexity: O(m * n)
        
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 16.5: Walls and Gates ===");
        
        int INF = int.MaxValue;
        int[][] test1 = new int[][]
        {
            new int[] { INF, -1, 0, INF },
            new int[] { INF, INF, INF, -1 },
            new int[] { INF, -1, INF, -1 },
            new int[] { 0, -1, INF, INF }
        };
        WallsAndGatesSolution(test1);
        Console.WriteLine($"Test 1 - Input: 4x4 grid with gates");
        Console.WriteLine($"         Output: Grid modified");
        bool passed1 = test1[0][3] == 1 && test1[1][0] == 2;
        Console.WriteLine($"         {(passed1 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[][] test2 = new int[][] { new int[] { 0, INF }, new int[] { INF, 0 } };
        WallsAndGatesSolution(test2);
        Console.WriteLine($"Test 2 - Input: 2x2 grid");
        Console.WriteLine($"         Output: Grid modified");
        bool passed2 = test2[0][1] == 1 && test2[1][0] == 1;
        Console.WriteLine($"         {(passed2 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

