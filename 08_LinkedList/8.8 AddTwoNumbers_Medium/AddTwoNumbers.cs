using System;
using System.Collections.Generic;

namespace DSA._8_8_AddTwoNumbers_Medium;

/// <summary>
/// Problem 8.8 (Medium): Add Two Numbers
/// You are given two non-empty linked lists representing two non-negative integers. The digits
/// are stored in reverse order, and each of their nodes contains a single digit. Add the two
/// numbers and return the sum as a linked list.
/// 
/// You may assume the two numbers do not contain any leading zero, except the number 0 itself.
/// 
/// Example:
/// Input: l1 = [2,4,3], l2 = [5,6,4]
/// Output: [7,0,8]
/// Explanation: 342 + 465 = 807.
/// 
/// Constraints:
/// - The number of nodes in each linked list is in the range [1, 100].
/// - 0 <= Node.val <= 9
/// - It is guaranteed that the list represents a number that does not have leading zeros.
/// </summary>
public class ListNode
{
    public int val;
    public ListNode? next;
    
    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class AddTwoNumbers
{
    public static ListNode? Solution(ListNode? l1, ListNode? l2)
    {
        // TODO: Implement solution
        // Hint: Traverse both lists simultaneously, handle carry, create new nodes for result
        // Time Complexity: O(max(m, n))
        // Space Complexity: O(max(m, n))
        
        return null;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 8.8: Add Two Numbers ===");
        
        var l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
        var l2 = new ListNode(5, new ListNode(6, new ListNode(4)));
        var result1 = Solution(l1, l2);
        var values1 = GetValues(result1);
        Console.WriteLine($"Test 1 - Input: l1 = [2,4,3], l2 = [5,6,4]");
        Console.WriteLine($"         Output: [{string.Join(",", values1)}], Expected: [7,0,8]");
        bool passed1 = values1.Count == 3 && values1[0] == 7 && values1[2] == 8;
        Console.WriteLine($"         {(passed1 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        var l3 = new ListNode(0);
        var l4 = new ListNode(0);
        var result2 = Solution(l3, l4);
        var values2 = GetValues(result2);
        Console.WriteLine($"Test 2 - Input: l1 = [0], l2 = [0]");
        Console.WriteLine($"         Output: [{string.Join(",", values2)}], Expected: [0]");
        bool passed2 = values2.Count == 1 && values2[0] == 0;
        Console.WriteLine($"         {(passed2 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
    
    private static List<int> GetValues(ListNode? head)
    {
        var values = new List<int>();
        var current = head;
        while (current != null)
        {
            values.Add(current.val);
            current = current.next;
        }
        return values;
    }
}

