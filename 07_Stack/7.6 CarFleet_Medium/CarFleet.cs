using System;
using System.Collections.Generic;
using System.Linq;

namespace DSA._7_6_CarFleet_Medium;

/// <summary>
/// Problem 7.6 (Medium): Car Fleet
/// There are n cars going to the same destination along a one-lane road. The destination is target miles away.
/// 
/// You are given two integer array position and speed, both of length n, where position[i] is the position
/// of the ith car and speed[i] is the speed of the ith car (in miles per hour).
/// 
/// A car can never pass another car ahead of it, but it can catch up to it and drive bumper to bumper
/// at the same speed. The faster car will slow down to match the slower car's speed. The distance between
/// these two cars is ignored (i.e., they are assumed to have the same position).
/// 
/// A car fleet is some non-empty set of cars driving at the same position and same speed. Note that a
/// single car is also a car fleet.
/// 
/// If a car catches up to a car fleet right at the destination point, it will still be considered as
/// one car fleet.
/// 
/// Return the number of car fleets that will arrive at the destination.
/// 
/// Example:
/// Input: target = 12, position = [10,8,0,5,3], speed = [2,4,1,1,3]
/// Output: 3
/// Explanation:
/// The cars starting at 10 (speed 2) and 8 (speed 4) become a fleet, meeting each other at 12.
/// The car starting at 0 does not catch up to any other car, so it is a fleet by itself.
/// The cars starting at 5 (speed 1) and 3 (speed 3) become a fleet, meeting each other at 6.
/// Note that no other cars meet these fleets before the destination, so the answer is 3.
/// 
/// Constraints:
/// - n == position.length == speed.length
/// - 1 <= n <= 10^5
/// - 0 < target <= 10^6
/// - 0 <= position[i] < target
/// - All the values of position are unique.
/// - 0 < speed[i] <= 10^6
/// </summary>
public class CarFleet
{
    public static int Solution(int target, int[] position, int[] speed)
    {
        // TODO: Implement solution
        // Hint: Sort by position, calculate time to reach target, use stack to track fleets
        // If a car reaches target faster than the car ahead, they form a fleet
        // Time Complexity: O(n log n) due to sorting
        // Space Complexity: O(n)
        
        return 0;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 7.6: Car Fleet ===");
        
        int target1 = 12;
        int[] position1 = { 10, 8, 0, 5, 3 };
        int[] speed1 = { 2, 4, 1, 1, 3 };
        int result1 = Solution(target1, position1, speed1);
        Console.WriteLine($"Test 1 - Input: target = {target1}, position = [10,8,0,5,3], speed = [2,4,1,1,3]");
        Console.WriteLine($"         Output: {result1}, Expected: 3");
        Console.WriteLine($"         {(result1 == 3 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int target2 = 10;
        int[] position2 = { 3 };
        int[] speed2 = { 3 };
        int result2 = Solution(target2, position2, speed2);
        Console.WriteLine($"Test 2 - Input: target = {target2}, position = [3], speed = [3]");
        Console.WriteLine($"         Output: {result2}, Expected: 1");
        Console.WriteLine($"         {(result2 == 1 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

