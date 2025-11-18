using System;
using System.Collections.Generic;

namespace DSA._12_4_KthLargestInStream_Easy;

/// <summary>
/// Problem 12.4 (Easy): Kth Largest Element in a Stream
/// Design a class to find the kth largest element in a stream. Note that it is the kth largest
/// element in the sorted order, not the kth distinct element.
/// 
/// Implement KthLargest class:
/// - KthLargest(int k, int[] nums) Initializes the object with the integer k and the stream of integers nums.
/// - int Add(int val) Appends the integer val to the stream and returns the element representing
///   the kth largest element in the stream.
/// 
/// Example:
/// Input: ["KthLargest", "add", "add", "add", "add", "add"]
/// [[3, [4, 5, 8, 2]], [3], [5], [10], [9], [4]]
/// Output: [null, 4, 5, 5, 8, 8]
/// 
/// Constraints:
/// - 1 <= k <= 10^4
/// - 0 <= nums.length <= 10^4
/// - -10^4 <= nums[i] <= 10^4
/// - -10^4 <= val <= 10^4
/// - At most 10^4 calls will be made to add.
/// </summary>
public class KthLargest
{
    // TODO: Implement KthLargest using PriorityQueue or SortedSet
    // Hint: Maintain a min heap of size k, return the smallest element (which is kth largest)
    // Time Complexity: O(n log k) for constructor, O(log k) for add
    // Space Complexity: O(k)
    
    public KthLargest(int k, int[] nums)
    {
        // Initialize your data structure here
    }
    
    public int Add(int val)
    {
        // TODO: Implement add
        return 0;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 12.4: Kth Largest in Stream ===");
        
        var kthLargest = new KthLargest(3, new int[] { 4, 5, 8, 2 });
        int result1 = kthLargest.Add(3);
        int result2 = kthLargest.Add(5);
        int result3 = kthLargest.Add(10);
        Console.WriteLine($"Test 1 - k = 3, nums = [4,5,8,2], Add(3) = {result1}, Add(5) = {result2}, Add(10) = {result3}");
        Console.WriteLine($"         Expected: 4, 5, 5");
        bool passed1 = result1 == 4 && result2 == 5 && result3 == 5;
        Console.WriteLine($"         {(passed1 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        var kthLargest2 = new KthLargest(1, Array.Empty<int>());
        int result4 = kthLargest2.Add(-3);
        int result5 = kthLargest2.Add(-2);
        Console.WriteLine($"Test 2 - k = 1, nums = [], Add(-3) = {result4}, Add(-2) = {result5}");
        Console.WriteLine($"         Expected: -3, -2");
        bool passed2 = result4 == -3 && result5 == -2;
        Console.WriteLine($"         {(passed2 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

