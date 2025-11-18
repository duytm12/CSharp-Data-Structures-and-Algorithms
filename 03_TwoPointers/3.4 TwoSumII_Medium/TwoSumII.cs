using System;

namespace DSA._3_4_TwoSumII_Medium;

/// <summary>
/// Problem 3.4 (Medium): Two Sum II - Input Array Is Sorted
/// Given a 1-indexed array of integers numbers that is already sorted in non-decreasing order,
/// find two numbers such that they add up to a specific target number. Let these two numbers
/// be numbers[index1] and numbers[index2] where 1 <= index1 < index2 <= numbers.length.
/// 
/// Return the indices of the two numbers, index1 and index2, added by one as an integer array
/// [index1, index2] of length 2.
/// 
/// Example:
/// Input: numbers = [2,7,11,15], target = 9
/// Output: [1,2]
/// Explanation: The sum of 2 and 7 is 9. Therefore, index1 = 1, index2 = 2. We return [1, 2].
/// 
/// Constraints:
/// - 2 <= numbers.length <= 3 * 10^4
/// - -1000 <= numbers[i] <= 1000
/// - numbers is sorted in non-decreasing order.
/// - -1000 <= target <= 1000
/// - The tests are generated such that there is exactly one solution.
/// </summary>
public class TwoSumII
{
    public static int[] Solution(int[] numbers, int target)
    {
        // TODO: Implement solution
        // Hint: Use two pointers (left and right), move based on sum comparison
        // Since array is sorted, if sum > target, move right pointer left; if sum < target, move left pointer right
        // Time Complexity: O(n)
        // Space Complexity: O(1)
        
        return Array.Empty<int>();
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 3.4: Two Sum II ===");
        
        int[] test1 = { 2, 7, 11, 15 };
        int target1 = 9;
        int[] result1 = Solution(test1, target1);
        Console.WriteLine($"Test 1 - Input: numbers = [2, 7, 11, 15], target = {target1}");
        Console.WriteLine($"         Output: [{result1[0]}, {result1[1]}], Expected: [1, 2]");
        bool passed1 = result1.Length == 2 && result1[0] == 1 && result1[1] == 2;
        Console.WriteLine($"         {(passed1 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[] test2 = { 2, 3, 4 };
        int target2 = 6;
        int[] result2 = Solution(test2, target2);
        Console.WriteLine($"Test 2 - Input: numbers = [2, 3, 4], target = {target2}");
        Console.WriteLine($"         Output: [{result2[0]}, {result2[1]}], Expected: [1, 3]");
        bool passed2 = result2.Length == 2 && result2[0] == 1 && result2[1] == 3;
        Console.WriteLine($"         {(passed2 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

