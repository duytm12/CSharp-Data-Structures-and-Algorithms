using System;
using System.Collections.Generic;

namespace DSA._21_8_DetectSquares_Medium;

/// <summary>
/// Problem 21.8 (Medium): Detect Squares
/// You are given a stream of points on the X-Y plane. Design an algorithm that:
/// - Adds new points from the stream into a data structure. Duplicate points are allowed and
///   should be treated as different points.
/// - Given a query point, counts the number of ways to choose three points from the data
///   structure such that the three points and the query point form an axis-aligned square with
///   positive area.
/// 
/// An axis-aligned square is a square whose edges are all the same length and are either parallel
/// or perpendicular to the x-axis and y-axis.
/// 
/// Implement the DetectSquares class:
/// - DetectSquares() Initializes the object with an empty data structure.
/// - void Add(int[] point) Adds a new point point = [x, y] to the data structure.
/// - int Count(int[] point) Counts the number of ways to form axis-aligned squares with point
///   point = [x, y] as one of the vertices of the squares.
/// 
/// Example:
/// Input:
/// ["DetectSquares", "add", "add", "add", "count", "count", "add", "count"]
/// [[], [[3, 10]], [[11, 2]], [[3, 2]], [[11, 10]], [[14, 8]], [[11, 2]], [[11, 10]]]
/// Output: [null, null, null, null, 1, 0, null, 2]
/// 
/// Constraints:
/// - point.length == 2
/// - 0 <= x, y <= 1000
/// - At most 3000 calls in total will be made to add and count.
/// </summary>
public class DetectSquares
{
    private Dictionary<(int, int), int> _points;
    
    public DetectSquares()
    {
        // TODO: Initialize data structure
        // Hint: Use Dictionary to count points at each coordinate
        _points = new Dictionary<(int, int), int>();
    }
    
    public void Add(int[] point)
    {
        // TODO: Implement Add method
        // Hint: Increment count for point (x, y)
        var key = (point[0], point[1]);
        if (_points.ContainsKey(key))
            _points[key]++;
        else
            _points[key] = 1;
    }
    
    public int Count(int[] point)
    {
        // TODO: Implement Count method
        // Hint: For query point (x, y), find all points with same x or y
        // Check if they form a square (diagonal points)
        // Time Complexity: O(n) where n is number of points
        // Space Complexity: O(n)
        
        int x = point[0], y = point[1];
        int count = 0;
        
        // TODO: Find all points that can form squares with (x, y)
        // For each point (x1, y1) in _points:
        //   If x1 != x and y1 != y and distance matches:
        //     Check if (x1, y) and (x, y1) exist
        //     count += _points[(x1, y)] * _points[(x, y1)] * _points[(x1, y1)]
        
        return count;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 21.8: Detect Squares ===");
        
        var detectSquares = new DetectSquares();
        detectSquares.Add(new int[] { 3, 10 });
        detectSquares.Add(new int[] { 11, 2 });
        detectSquares.Add(new int[] { 3, 2 });
        int result1 = detectSquares.Count(new int[] { 11, 10 });
        Console.WriteLine($"Test 1 - Add: [[3,10],[11,2],[3,2]], Count([11,10])");
        Console.WriteLine($"         Output: {result1}, Expected: 1");
        Console.WriteLine($"         {(result1 == 1 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        detectSquares.Add(new int[] { 11, 2 });
        int result2 = detectSquares.Count(new int[] { 11, 10 });
        Console.WriteLine($"Test 2 - Add: [[11,2]], Count([11,10])");
        Console.WriteLine($"         Output: {result2}, Expected: 2");
        Console.WriteLine($"         {(result2 == 2 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

