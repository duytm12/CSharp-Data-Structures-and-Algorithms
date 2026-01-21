using System;

namespace DSA._8_4_LinkedListCycle_Easy;

/// <summary>
/// Problem 8.4 (Easy): Linked List Cycle
/// Given head, the head of a linked list, determine if the linked list has a cycle in it.
/// 
/// There is a cycle in a linked list if there is some node in the list that can be reached again
/// by continuously following the next pointer. Internally, pos is used to denote the index of the
/// node that tail's next pointer is connected to. Note that pos is not passed as a parameter.
/// 
/// Return true if there is a cycle in the linked list. Otherwise, return false.
/// 
/// Example:
/// Input: head = [3,2,0,-4], pos = 1
/// Output: true
/// Explanation: There is a cycle in the linked list, where the tail connects to the 1st node (0-indexed).
/// 
/// Constraints:
/// - The number of the nodes in the list is in the range [0, 10^4].
/// - -10^5 <= Node.val <= 10^5
/// - pos is -1 or a valid index in the linked-list.
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

public class LinkedListCycle
{
    public static bool HasCycle(ListNode? head)
    {
        // TODO: Implement solution
        // Hint: Use Floyd's cycle detection (fast and slow pointers)
        // If there's a cycle, fast pointer will eventually meet slow pointer
        // Time Complexity: O(n)
        // Space Complexity: O(1)
        if (head is null && head.next is null) return false;

        ListNode slow = head;
        ListNode fast = head;

        while (fast is not null && fast.next is not null)
        {
            slow = slow.next!;
            fast = fast.next.next!;

            if (slow == fast) return true;
         }
        return false;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 8.4: Linked List Cycle ===");
        
        var node1 = new ListNode(3);
        var node2 = new ListNode(2);
        var node3 = new ListNode(0);
        var node4 = new ListNode(-4);
        node1.next = node2;
        node2.next = node3;
        node3.next = node4;
        node4.next = node2; // Creates cycle
        bool result1 = HasCycle(node1);
        Console.WriteLine($"Test 1 - Input: [3,2,0,-4] with cycle at pos 1");
        Console.WriteLine($"         Output: {result1}, Expected: True");
        Console.WriteLine($"         {(result1 == true ? "✓ PASSED" : "✗ FAILED")}\n");
        
        var node5 = new ListNode(1);
        var node6 = new ListNode(2);
        node5.next = node6;
        node6.next = null; // No cycle
        bool result2 = HasCycle(node5);
        Console.WriteLine($"Test 2 - Input: [1,2] with no cycle");
        Console.WriteLine($"         Output: {result2}, Expected: False");
        Console.WriteLine($"         {(result2 == false ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

