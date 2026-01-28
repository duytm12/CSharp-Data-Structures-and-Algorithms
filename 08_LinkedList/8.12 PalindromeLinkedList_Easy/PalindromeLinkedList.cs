using System;
using System.Collections.Generic;

namespace DSA._8_12_PalindromeLinkedList_Easy;

/// <summary>
/// Problem 8.12 (Easy): Palindrome Linked List
/// Given the head of a singly linked list, return true if it is a palindrome or false otherwise.
///
/// Example 1:
/// Input: head = [1,2,2,1]
/// Output: true
///
/// Example 2:
/// Input: head = [1,2]
/// Output: false
///
/// Constraints:
/// - The number of nodes in the list is in the range [1, 10^5].
/// - 0 <= Node.val <= 9
///
/// Follow up: Could you do it in O(n) time and O(1) space?
/// This solution runs in O(n) time and O(1) extra space.
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

public class PalindromeLinkedList
{
    public static bool IsPalindrome(ListNode head)
    {
        if (head.next is null) return true;

        ListNode slow = head;
        ListNode fast = head;

        while (fast is not null && fast.next is not null)
        {
            slow = slow.next!;
            fast = fast.next.next!;
        }

        ListNode? secondHalfStart = (fast != null) ? slow.next : slow;
        ListNode? secondHalfReverse = Reverse(secondHalfStart);

        ListNode? p1 = head;
        ListNode? p2 = secondHalfReverse;

        while (secondHalfReverse is not null)
        {
            if (p1.val != p2.val) return false;
            p1 = p1.next;
            p2 = p2.next;
        }

        return true;
    }

    private static ListNode? Reverse(ListNode? head)
    {
        ListNode? prev = null;
        ListNode? curr = head;
        ListNode? next = null;

        while (curr is not null)
        {
            next = curr.next;
            curr.next = prev;
            prev = curr;
            curr = next;
        }

        return prev;
    }

    // Helper to create a list from array for testing
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

    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 8.12: Palindrome Linked List ===");

        // Test 1: [1,2,2,1] -> true
        int[] test1 = { 1, 2, 2, 1 };
        ListNode? head1 = CreateList(test1);
        bool result1 = IsPalindrome(head1);
        Console.WriteLine("Test 1 - Input: [1,2,2,1]");
        Console.WriteLine($"         Output: {result1}, Expected: True");
        Console.WriteLine($"         {(result1 == true ? "✓ PASSED" : "✗ FAILED")}\n");

        // Test 2: [1,2] -> false
        int[] test2 = { 1, 2 };
        ListNode? head2 = CreateList(test2);
        bool result2 = IsPalindrome(head2);
        Console.WriteLine("Test 2 - Input: [1,2]");
        Console.WriteLine($"         Output: {result2}, Expected: False");
        Console.WriteLine($"         {(result2 == false ? "✓ PASSED" : "✗ FAILED")}\n");

        // Test 3: [1,2,3,2,1] -> true (odd length)
        int[] test3 = { 1, 2, 3, 2, 1 };
        ListNode? head3 = CreateList(test3);
        bool result3 = IsPalindrome(head3);
        Console.WriteLine("Test 3 - Input: [1,2,3,2,1]");
        Console.WriteLine($"         Output: {result3}, Expected: True");
        Console.WriteLine($"         {(result3 == true ? "✓ PASSED" : "✗ FAILED")}\n");

        // Test 4: [1] -> true (single node)
        int[] test4 = { 1 };
        ListNode? head4 = CreateList(test4);
        bool result4 = IsPalindrome(head4);
        Console.WriteLine("Test 4 - Input: [1]");
        Console.WriteLine($"         Output: {result4}, Expected: True");
        Console.WriteLine($"         {(result4 == true ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

