using System;

namespace DSA._12_1_KthLargest_Medium;

/// <summary>
/// Problem 12.1 (Medium): Kth Largest Element in an Array
/// Given an integer array nums and an integer k, return the kth largest element in the array.
/// 
/// Example:
/// Input: nums = [3,2,1,5,6,4], k = 2
/// Output: 5
/// </summary>
public class KthLargest
{
    public static int Solution(int[] nums, int k)
    {
        // TODO: Implement solution
        // Hint: Use PriorityQueue or QuickSelect algorithm
        // Time Complexity: O(n) average with QuickSelect, O(n log k) with heap
        // Space Complexity: O(1) QuickSelect, O(k) heap
        
        return 0;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 12.1: Kth Largest ===");
        
        int[] test1 = { 3, 2, 1, 5, 6, 4 };
        int result1 = Solution(test1, 2);
        Console.WriteLine($"Test 1 - Input: [3,2,1,5,6,4], k = 2");
        Console.WriteLine($"         Output: {result1}, Expected: 5");
        Console.WriteLine($"         {(result1 == 5 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[] test2 = { 3, 2, 3, 1, 2, 4, 5, 5, 6 };
        int result2 = Solution(test2, 4);
        Console.WriteLine($"Test 2 - Input: [3,2,3,1,2,4,5,5,6], k = 4");
        Console.WriteLine($"         Output: {result2}, Expected: 4");
        Console.WriteLine($"         {(result2 == 4 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

