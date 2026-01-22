using System;
using System.Collections.Generic;
using System.Linq;

namespace DSA._8_11_RemoveDuplicatesFromSortedList_Easy;

/// <summary>
/// Problem 8.11 (Easy): Remove Duplicates from Sorted List
/// Given the head of a sorted linked list, delete all duplicates such that each element appears only once. 
/// Return the linked list sorted as well.
/// 
/// Example 1:
/// Input: head = [1,1,2]
/// Output: [1,2]
/// 
/// Example 2:
/// Input: head = [1,1,2,3,3]
/// Output: [1,2,3]
/// 
/// Constraints:
/// - The number of nodes in the list is in the range [0, 300].
/// - -100 <= Node.val <= 100
/// - The list is guaranteed to be sorted in ascending order.
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

public class RemoveDuplicatesFromSortedList
{
    public static ListNode? DeleteDuplicates(ListNode? head)
    {
        // TODO: Implement solution
        // Hint: Since the list is sorted, duplicates will be adjacent
        // Use a single pointer to traverse and skip duplicates
        // Time Complexity: O(n)
        // Space Complexity: O(1)
        if (head is null) return null;

        if (head.next is null) return head;

        ListNode? current = head;

        while (current.next is not null)
        {
            if (current.val == current.next.val)
            {
                current.next = current.next.next;
            }
            else
            {
                current = current.next;
            }
        }
        
        return head;
    }
    
    // Helper method to create linked list from array
    private static ListNode? CreateList(int[] values)
    {
        if (values == null || values.Length == 0) return null;
        
        ListNode head = new ListNode(values[0]);
        ListNode current = head;
        
        for (int i = 1; i < values.Length; i++)
        {
            current.next = new ListNode(values[i]);
            current = current.next;
        }
        
        return head;
    }
    
    // Helper method to convert linked list to array
    private static int[] ListToArray(ListNode? head)
    {
        if (head == null) return Array.Empty<int>();
        
        List<int> result = new List<int>();
        ListNode? current = head;
        
        while (current != null)
        {
            result.Add(current.val);
            current = current.next;
        }
        
        return result.ToArray();
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 8.11: Remove Duplicates from Sorted List ===");
        
        // Test 1: [1,1,2] -> [1,2]
        int[] test1 = { 1, 1, 2 };
        ListNode? head1 = CreateList(test1);
        ListNode? result1 = DeleteDuplicates(head1);
        int[] expected1 = { 1, 2 };
        int[] actual1 = ListToArray(result1);
        Console.WriteLine($"Test 1 - Input: [1,1,2]");
        Console.WriteLine($"         Output: [{string.Join(",", actual1)}], Expected: [{string.Join(",", expected1)}]");
        Console.WriteLine($"         {(actual1.SequenceEqual(expected1) ? "✓ PASSED" : "✗ FAILED")}\n");
        
        // Test 2: [1,1,2,3,3] -> [1,2,3]
        int[] test2 = { 1, 1, 2, 3, 3 };
        ListNode? head2 = CreateList(test2);
        ListNode? result2 = DeleteDuplicates(head2);
        int[] expected2 = { 1, 2, 3 };
        int[] actual2 = ListToArray(result2);
        Console.WriteLine($"Test 2 - Input: [1,1,2,3,3]");
        Console.WriteLine($"         Output: [{string.Join(",", actual2)}], Expected: [{string.Join(",", expected2)}]");
        Console.WriteLine($"         {(actual2.SequenceEqual(expected2) ? "✓ PASSED" : "✗ FAILED")}\n");
        
        // Test 3: Empty list
        ListNode? head3 = null;
        ListNode? result3 = DeleteDuplicates(head3);
        Console.WriteLine($"Test 3 - Input: []");
        Console.WriteLine($"         Output: null, Expected: null");
        Console.WriteLine($"         {(result3 == null ? "✓ PASSED" : "✗ FAILED")}\n");
        
        // Test 4: Single node [1] -> [1]
        int[] test4 = { 1 };
        ListNode? head4 = CreateList(test4);
        ListNode? result4 = DeleteDuplicates(head4);
        int[] expected4 = { 1 };
        int[] actual4 = ListToArray(result4);
        Console.WriteLine($"Test 4 - Input: [1]");
        Console.WriteLine($"         Output: [{string.Join(",", actual4)}], Expected: [{string.Join(",", expected4)}]");
        Console.WriteLine($"         {(actual4.SequenceEqual(expected4) ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}
