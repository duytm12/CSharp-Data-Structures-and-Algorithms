using System;

namespace DSA._15_3_GasStation_Medium;

/// <summary>
/// Problem 15.3 (Medium): Gas Station
/// There are n gas stations along a circular route. You have a car with an unlimited gas tank.
/// Return the starting gas station's index if you can travel around the circuit once, otherwise return -1.
/// 
/// Example:
/// Input: gas = [1,2,3,4,5], cost = [3,4,5,1,2]
/// Output: 3
/// </summary>
public class GasStation
{
    public static int Solution(int[] gas, int[] cost)
    {
        // TODO: Implement solution
        // Hint: If total gas >= total cost, solution exists. Find starting point.
        // Time Complexity: O(n)
        // Space Complexity: O(1)
        
        return -1;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 15.3: Gas Station ===");
        
        int[] gas1 = { 1, 2, 3, 4, 5 };
        int[] cost1 = { 3, 4, 5, 1, 2 };
        int result1 = Solution(gas1, cost1);
        Console.WriteLine($"Test 1 - Input: gas = [1,2,3,4,5], cost = [3,4,5,1,2]");
        Console.WriteLine($"         Output: {result1}, Expected: 3");
        Console.WriteLine($"         {(result1 == 3 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[] gas2 = { 2, 3, 4 };
        int[] cost2 = { 3, 4, 3 };
        int result2 = Solution(gas2, cost2);
        Console.WriteLine($"Test 2 - Input: gas = [2,3,4], cost = [3,4,3]");
        Console.WriteLine($"         Output: {result2}, Expected: -1");
        Console.WriteLine($"         {(result2 == -1 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

