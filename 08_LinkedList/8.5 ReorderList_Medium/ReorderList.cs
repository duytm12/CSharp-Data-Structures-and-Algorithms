using System;
using System.Collections.Generic;

namespace DSA._8_5_ReorderList_Medium;

/// <summary>
/// Problem 8.5 (Medium): Reorder List
/// You are given the head of a singly linked-list. The list can be represented as:
/// L0 → L1 → … → Ln - 1 → Ln
/// 
/// Reorder the list to be on the following form:
/// L0 → Ln → L1 → Ln - 1 → L2 → Ln - 2 → …
/// 
/// You may not modify the values in the list's nodes. Only nodes themselves may be changed.
/// 
/// Example:
/// Input: head = [1,2,3,4]
/// Output: [1,4,2,3]
/// 
/// Constraints:
/// - The number of nodes in the list is in the range [1, 5 * 10^4].
/// - 1 <= Node.val <= 1000
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

public class ReorderList
{
    public static void Solution(ListNode? head)
    {
        // TODO: Implement solution
        // Hint: Find middle, reverse second half, merge two halves alternately
        // Time Complexity: O(n)
        // Space Complexity: O(1)
        
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 8.5: Reorder List ===");
        
        var head1 = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4))));
        Solution(head1);
        var values1 = GetValues(head1);
        Console.WriteLine($"Test 1 - Input: [1,2,3,4]");
        Console.WriteLine($"         Output: [{string.Join(",", values1)}], Expected: [1,4,2,3]");
        bool passed1 = values1.Count == 4 && values1[0] == 1 && values1[1] == 4;
        Console.WriteLine($"         {(passed1 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        var head2 = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
        Solution(head2);
        var values2 = GetValues(head2);
        Console.WriteLine($"Test 2 - Input: [1,2,3,4,5]");
        Console.WriteLine($"         Output: [{string.Join(",", values2)}]");
        bool passed2 = values2.Count == 5;
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

