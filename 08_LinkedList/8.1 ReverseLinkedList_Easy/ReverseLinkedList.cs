using System;
using System.Collections.Generic;

namespace DSA._8_1_ReverseLinkedList_Easy;

/// <summary>
/// Problem 8.1 (Easy): Reverse Linked List
/// Given the head of a singly linked list, reverse the list, and return the reversed list.
/// 
/// Example:
/// Input: head = [1,2,3,4,5]
/// Output: [5,4,3,2,1]
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

public class ReverseLinkedList
{
    public static ListNode? Solution(ListNode? head)
    {
        // TODO: Implement solution
        // Hint: Iterative approach with prev, curr, next pointers
        // Time Complexity: O(n)
        // Space Complexity: O(1)
        
        return null;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 8.1: Reverse Linked List ===");
        
        var head1 = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
        var result1 = Solution(head1);
        var values1 = GetValues(result1);
        Console.WriteLine($"Test 1 - Input: [1,2,3,4,5]");
        Console.WriteLine($"         Output: [{string.Join(",", values1)}], Expected: [5,4,3,2,1]");
        bool passed1 = values1.Count == 5 && values1[0] == 5 && values1[4] == 1;
        Console.WriteLine($"         {(passed1 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        var head2 = new ListNode(1);
        var result2 = Solution(head2);
        var values2 = GetValues(result2);
        Console.WriteLine($"Test 2 - Input: [1]");
        Console.WriteLine($"         Output: [{string.Join(",", values2)}], Expected: [1]");
        bool passed2 = values2.Count == 1 && values2[0] == 1;
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

