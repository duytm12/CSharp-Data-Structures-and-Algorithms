using System;
using System.Collections.Generic;

namespace DSA._8_10_ReverseNodesInKGroup_Hard;

/// <summary>
/// Problem 8.10 (Hard): Reverse Nodes in k-Group
/// Given the head of a linked list, reverse the nodes of the list k at a time, and return the modified list.
/// 
/// k is a positive integer and is less than or equal to the length of the linked list. If the number
/// of nodes is not a multiple of k then left-out nodes, in the end, should remain as it is.
/// 
/// You may not alter the values in the list's nodes, only nodes themselves may be changed.
/// 
/// Example:
/// Input: head = [1,2,3,4,5], k = 2
/// Output: [2,1,4,3,5]
/// 
/// Constraints:
/// - The number of nodes in the list is n.
/// - 1 <= k <= n <= 5000
/// - 0 <= Node.val <= 1000
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

public class ReverseNodesInKGroup
{
    public static ListNode? ReverseKGroup(ListNode? head, int k)
    {
        // TODO: Implement solution
        // Hint: Reverse k nodes at a time, recursively handle remaining groups
        // Check if there are k nodes remaining before reversing
        // Time Complexity: O(n)
        // Space Complexity: O(n/k) for recursion stack
        
        return null;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 8.10: Reverse Nodes in K Group ===");
        
        var head1 = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
        var result1 = ReverseKGroup(head1, 2);
        var values1 = GetValues(result1);
        Console.WriteLine($"Test 1 - Input: [1,2,3,4,5], k = 2");
        Console.WriteLine($"         Output: [{string.Join(",", values1)}], Expected: [2,1,4,3,5]");
        bool passed1 = values1.Count == 5 && values1[0] == 2 && values1[1] == 1;
        Console.WriteLine($"         {(passed1 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        var head2 = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4))));
        var result2 = ReverseKGroup(head2, 2);
        var values2 = GetValues(result2);
        Console.WriteLine($"Test 2 - Input: [1,2,3,4], k = 2");
        Console.WriteLine($"         Output: [{string.Join(",", values2)}], Expected: [2,1,4,3]");
        bool passed2 = values2.Count == 4 && values2[0] == 2 && values2[3] == 3;
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

