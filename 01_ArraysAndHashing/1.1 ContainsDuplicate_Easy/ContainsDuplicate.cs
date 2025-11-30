using System;
using System.Collections.Generic;
using System.Linq;

namespace DSA._1_1_ContainsDuplicate_Easy;

/// <summary>
/// Problem 1.1 (Easy): Contains Duplicate
/// Given an integer array nums, return true if any value appears at least twice in the array,
/// and return false if every element is distinct.
/// 
/// Example:
/// Input: nums = [1,2,3,1]
/// Output: true
/// 
/// Constraints:
/// - 1 <= nums.length <= 10^5
/// - -10^9 <= nums[i] <= 10^9
/// </summary>
public class ContainsDuplicate
{
    public static bool Solution(int[] nums)
    {
        // Array.Sort(nums);
        // // Solution 1
        // for (int i =0; i < nums.Length; i++)
        // {
        //     for (int j = i+1; j<nums.Length; j++)
        //     {
        //         if (nums[i]==nums[j]) return true;
        //     }
        // }



        // Solution 2.1: Add all elements to HashSet, then compare counts
        // If HashSet count < array length, there are duplicates
        // var seen = new HashSet<int>(); 
        // for (int i = 0; i < nums.Length; i++)
        // {
        //     if (seen.Contains(nums[i])) return true;
        //     seen.Add(nums[i]);
        // }

        // var seen = new HashSet<int>(nums);
        // return seen.Count < nums.Length;

        // Solution 2.2: Using LinQ .ToHashSet() function.
        return nums.ToHashSet().Count < nums.Length;

        // Approach:
        // 1. We need to check if any number appears more than once
        // 2. Think about what data structure can help us track "seen" numbers
        // 3. As we iterate through the array, check if we've seen the current number before
        //
        // Hint: HashSet<T> is perfect for this - it stores unique values and has O(1) lookup
        //
        // Time Complexity: Try to achieve O(n)
        // Space Complexity: Try to achieve O(n)

    // return false; 
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 1.1: Contains Duplicate ===");
        
        // Test Case 1: Has duplicates
        int[] test1 = { 1, 2, 3, 1 };
        bool result1 = Solution(test1);
        Console.WriteLine($"Test 1 - Input: [1, 2, 3, 1]");
        Console.WriteLine($"         Output: {result1}, Expected: True");
        Console.WriteLine($"         {(result1 == true ? "✓ PASSED" : "✗ FAILED")}\n");
        
        // Test Case 2: No duplicates
        int[] test2 = { 1, 2, 3, 4 };
        bool result2 = Solution(test2);
        Console.WriteLine($"Test 2 - Input: [1, 2, 3, 4]");
        Console.WriteLine($"         Output: {result2}, Expected: False");
        Console.WriteLine($"         {(result2 == false ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

