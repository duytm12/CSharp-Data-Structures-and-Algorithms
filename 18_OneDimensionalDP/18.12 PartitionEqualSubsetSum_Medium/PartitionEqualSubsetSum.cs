using System;

namespace DSA._18_12_PartitionEqualSubsetSum_Medium;

/// <summary>
/// Problem 18.12 (Medium): Partition Equal Subset Sum
/// Given a non-empty array nums containing only positive integers, find if the array can be
/// partitioned into two subsets such that the sum of elements in both subsets is equal.
/// 
/// Example:
/// Input: nums = [1,5,11,5]
/// Output: true
/// Explanation: The array can be partitioned as [1, 5, 5] and [11].
/// 
/// Constraints:
/// - 1 <= nums.length <= 200
/// - 1 <= nums[i] <= 100
/// </summary>
public class PartitionEqualSubsetSum
{
    public static bool CanPartition(int[] nums)
    {
        // TODO: Implement solution
        // Hint: Subset sum problem - check if sum/2 can be formed
        // DP[i][j] = can we form sum j using first i elements
        // Optimize to 1D DP: DP[j] = can we form sum j
        // Time Complexity: O(n * sum)
        // Space Complexity: O(sum)
        
        return false;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 18.12: Partition Equal Subset Sum ===");
        
        int[] test1 = { 1, 5, 11, 5 };
        bool result1 = CanPartition(test1);
        Console.WriteLine($"Test 1 - Input: [1,5,11,5]");
        Console.WriteLine($"         Output: {result1}, Expected: True");
        Console.WriteLine($"         {(result1 == true ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[] test2 = { 1, 2, 3, 5 };
        bool result2 = CanPartition(test2);
        Console.WriteLine($"Test 2 - Input: [1,2,3,5]");
        Console.WriteLine($"         Output: {result2}, Expected: False");
        Console.WriteLine($"         {(result2 == false ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

