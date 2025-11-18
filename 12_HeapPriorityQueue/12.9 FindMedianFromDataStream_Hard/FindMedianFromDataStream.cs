using System;
using System.Collections.Generic;

namespace DSA._12_9_FindMedianFromDataStream_Hard;

/// <summary>
/// Problem 12.9 (Hard): Find Median from Data Stream
/// The median is the middle value in an ordered integer list. If the size of the list is even,
/// there is no middle value, and the median is the mean of the two middle values.
/// 
/// Implement the MedianFinder class:
/// - MedianFinder() initializes the MedianFinder object.
/// - void AddNum(int num) adds the integer num from the data stream to the data structure.
/// - double FindMedian() returns the median of all elements so far.
/// 
/// Example:
/// MedianFinder medianFinder = new MedianFinder();
/// medianFinder.AddNum(1);    // arr = [1]
/// medianFinder.AddNum(2);    // arr = [1, 2]
/// medianFinder.FindMedian(); // return 1.5 (i.e., (1 + 2) / 2)
/// medianFinder.AddNum(3);    // arr[1, 2, 3]
/// medianFinder.FindMedian(); // return 2.0
/// 
/// Constraints:
/// - -10^5 <= num <= 10^5
/// - There will be at least one element in the data structure before calling FindMedian.
/// - At most 5 * 10^4 calls will be made to AddNum and FindMedian.
/// </summary>
public class MedianFinder
{
    // TODO: Implement MedianFinder using two heaps (two PriorityQueues)
    // Hint: Use max heap for lower half, min heap for upper half
    // Keep heaps balanced (size difference <= 1)
    // Time Complexity: O(log n) for AddNum, O(1) for FindMedian
    // Space Complexity: O(n)
    
    public MedianFinder()
    {
        // Initialize your data structure here
    }
    
    public void AddNum(int num)
    {
        // TODO: Implement add number
    }
    
    public double FindMedian()
    {
        // TODO: Implement find median
        return 0.0;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 12.9: Find Median from Data Stream ===");
        
        var medianFinder = new MedianFinder();
        medianFinder.AddNum(1);
        medianFinder.AddNum(2);
        double result1 = medianFinder.FindMedian();
        Console.WriteLine($"Test 1 - AddNum(1), AddNum(2), FindMedian() = {result1}");
        Console.WriteLine($"         Expected: 1.5");
        Console.WriteLine($"         {(Math.Abs(result1 - 1.5) < 0.0001 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        medianFinder.AddNum(3);
        double result2 = medianFinder.FindMedian();
        Console.WriteLine($"Test 2 - AddNum(3), FindMedian() = {result2}");
        Console.WriteLine($"         Expected: 2.0");
        Console.WriteLine($"         {(Math.Abs(result2 - 2.0) < 0.0001 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

