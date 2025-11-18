using System;
using System.Collections.Generic;

namespace DSA._8_6_RemoveNthNodeFromEnd_Medium;

/// <summary>
/// Problem 8.6 (Medium): Remove Nth Node From End of List
/// Given the head of a linked list, remove the nth node from the end of the list and return its head.
/// 
/// Example:
/// Input: head = [1,2,3,4,5], n = 2
/// Output: [1,2,3,5]
/// 
/// Constraints:
/// - The number of nodes in the list is sz.
/// - 1 <= sz <= 30
/// - 0 <= Node.val <= 100
/// - 1 <= n <= sz
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

public class RemoveNthNodeFromEnd
{
    public static ListNode? RemoveNthFromEnd(ListNode? head, int n)
    {
        // TODO: Implement solution
        // Hint: Use two pointers - move first pointer n steps ahead, then move both together
        // When first pointer reaches end, second pointer is at node before target
        // Time Complexity: O(n)
        // Space Complexity: O(1)
        
        return null;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 8.6: Remove Nth Node From End ===");
        
        var head1 = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
        var result1 = RemoveNthFromEnd(head1, 2);
        var values1 = GetValues(result1);
        Console.WriteLine($"Test 1 - Input: [1,2,3,4,5], n = 2");
        Console.WriteLine($"         Output: [{string.Join(",", values1)}], Expected: [1,2,3,5]");
        bool passed1 = values1.Count == 4 && values1[0] == 1 && values1[3] == 5;
        Console.WriteLine($"         {(passed1 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        var head2 = new ListNode(1);
        var result2 = RemoveNthFromEnd(head2, 1);
        Console.WriteLine($"Test 2 - Input: [1], n = 1");
        Console.WriteLine($"         Output: {(result2 == null ? "null" : "not null")}, Expected: null");
        Console.WriteLine($"         {(result2 == null ? "✓ PASSED" : "✗ FAILED")}\n");
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

