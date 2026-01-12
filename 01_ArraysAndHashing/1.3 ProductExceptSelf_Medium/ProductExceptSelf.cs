using System;
using System.Linq;

namespace DSA._1_3_ProductExceptSelf_Medium;

/// <summary>
/// Problem 1.3 (Medium): Product of Array Except Self
/// Given an integer array nums, return an array answer such that answer[i] is equal to
/// the product of all the elements of nums except nums[i].
/// 
/// Example:
/// Input: nums = [1,2,3,4]
/// Output: [24,12,8,6]
/// 
/// Constraints:
/// - 2 <= nums.length <= 10^5
/// - -30 <= nums[i] <= 30
/// - The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.
/// 
/// Follow up: Can you solve it in O(1) extra space? (The output array does not count as extra space)
/// </summary>
public class ProductExceptSelf
{
    public static int[] Solution(int[] nums)
    {
        // TODO: Implement solution
        // Hint: Use prefix and suffix products, O(n) time, O(1) extra space
        // Time Complexity: O(n)
        // Space Complexity: O(1) excluding output array



        // for (int i = 0; i < nums.Length; i++)
        // {
        //     var product = 1;
        //     for (int j = 0; j < nums.Length; j++)
        //     {
        //         if (i != j) product *= nums[j];
        //     }
        //     result[i] = product;
        // }

        var result = new int[nums.Length];
        result[0] = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            result[i] = result[i - 1] * nums[i - 1];
        }

        var suffix = 1;
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            result[i] *= suffix;
            suffix *= nums[i];
        }

        return result;
    }

 
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 1.3: Product Except Self ===");

        // Test Case 1: Basic example
        int[] test1 = { 1, 2, 3, 4 };
        int[] result1 = Solution(test1);
        int[] expected1 = { 24, 12, 8, 6 };
        Console.WriteLine($"Test 1 - Input: [1, 2, 3, 4]");
        Console.WriteLine($"         Output: [{string.Join(", ", result1)}], Expected: [{string.Join(", ", expected1)}]");
        bool passed1 = result1.Length == expected1.Length &&
                       result1[0] == expected1[0] && result1[1] == expected1[1] &&
                       result1[2] == expected1[2] && result1[3] == expected1[3];
        Console.WriteLine($"         {(passed1 ? "✓ PASSED" : "✗ FAILED")}\n");

        // Test Case 2: With negative numbers
        int[] test2 = { -1, 1, 0, -3, 3 };
        int[] result2 = Solution(test2);
        int[] expected2 = { 0, 0, 9, 0, 0 };
        Console.WriteLine($"Test 2 - Input: [-1, 1, 0, -3, 3]");
        Console.WriteLine($"         Output: [{string.Join(", ", result2)}], Expected: [{string.Join(", ", expected2)}]");
        bool passed2 = result2.Length == expected2.Length &&
                       result2[0] == expected2[0] && result2[2] == expected2[2];
        Console.WriteLine($"         {(passed2 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        // Test Case 3: Minimum size array (2 elements)
        int[] test3 = { 2, 3 };
        int[] result3 = Solution(test3);
        int[] expected3 = { 3, 2 };
        Console.WriteLine($"Test 3 - Input: [2, 3]");
        Console.WriteLine($"         Output: [{string.Join(", ", result3)}], Expected: [{string.Join(", ", expected3)}]");
        bool passed3 = result3.Length == expected3.Length &&
                       result3[0] == expected3[0] && result3[1] == expected3[1];
        Console.WriteLine($"         {(passed3 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        // Test Case 4: Array with multiple zeros
        int[] test4 = { 0, 0, 2, 3 };
        int[] result4 = Solution(test4);
        int[] expected4 = { 0, 0, 0, 0 };
        Console.WriteLine($"Test 4 - Input: [0, 0, 2, 3]");
        Console.WriteLine($"         Output: [{string.Join(", ", result4)}], Expected: [{string.Join(", ", expected4)}]");
        bool passed4 = result4.Length == expected4.Length &&
                       result4.All(x => x == 0);
        Console.WriteLine($"         {(passed4 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

