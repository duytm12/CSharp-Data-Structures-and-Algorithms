using System;
using System.Collections.Generic;

namespace DSA._8_2_MergeTwoSortedLists_Easy;

/// <summary>
/// Problem 8.2 (Easy): Merge Two Sorted Lists - LeetCode 21
/// You are given the heads of two sorted linked lists list1 and list2.
/// Merge the two lists into one sorted list. The list should be made by splicing
/// together the nodes of the first two lists.
/// Return the head of the merged linked list.
///
/// Example 1:
/// Input: list1 = [1,2,4], list2 = [1,3,4]
/// Output: [1,1,2,3,4,4]
///
/// Example 2:
/// Input: list1 = [], list2 = []
/// Output: []
///
/// Example 3:
/// Input: list1 = [], list2 = [0]
/// Output: [0]
///
/// Constraints:
/// - The number of nodes in both lists is in the range [0, 50].
/// - -100 <= Node.val <= 100
/// - Both list1 and list2 are sorted in non-decreasing order.
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

public class MergeTwoSortedLists
{
    public static ListNode? Solution(ListNode? list1, ListNode? list2)
    {
        // TODO: Implement solution
        if (list1 is null && list2 is null) return null;
        if (list1 is null) return list2;
        if (list2 is null) return list1;

        var t1 = list1;
        var t2 = list2;
        var dummy = new ListNode();
        var tail = dummy;

        while (t1 is not null && t2 is not null)
        {
            if (t1.val <= t2.val)
            {
                tail.next = t1;
                tail = t1;
                t1 = t1.next;
            }
            else
            {
                tail.next = t2;
                tail = t2;
                t2 = t2.next;
            }
        }

        tail.next = t1 ?? t2;   // append remainder
        return dummy.next;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 8.2: Merge Two Sorted Lists ===");
        
        var list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
        var list2 = new ListNode(1, new ListNode(3, new ListNode(4)));
        var result1 = Solution(list1, list2);
        var values1 = GetValues(result1);
        Console.WriteLine($"Test 1 - Input: list1 = [1,2,4], list2 = [1,3,4]");
        Console.WriteLine($"         Output: [{string.Join(",", values1)}], Expected: [1,1,2,3,4,4]");
        bool passed1 = values1.Count == 6 && values1[0] == 1 && values1[5] == 4;
        Console.WriteLine($"         {(passed1 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        var list3 = new ListNode(2);
        var list4 = new ListNode(1);
        var result2 = Solution(list3, list4);
        var values2 = GetValues(result2);
        Console.WriteLine($"Test 2 - Input: list1 = [2], list2 = [1]");
        Console.WriteLine($"         Output: [{string.Join(",", values2)}], Expected: [1,2]");
        bool passed2 = values2.Count == 2 && values2[0] == 1 && values2[1] == 2;
        Console.WriteLine($"         {(passed2 ? "✓ PASSED" : "✗ FAILED")}\n");

        var result3 = Solution(null, null);
        var values3 = GetValues(result3);
        Console.WriteLine($"Test 3 - Input: list1 = [], list2 = []");
        Console.WriteLine($"         Output: [{string.Join(",", values3)}], Expected: []");
        bool passed3 = values3.Count == 0;
        Console.WriteLine($"         {(passed3 ? "✓ PASSED" : "✗ FAILED")}\n");

        var list5 = new ListNode(0);
        var result4 = Solution(null, list5);
        var values4 = GetValues(result4);
        Console.WriteLine($"Test 4 - Input: list1 = [], list2 = [0]");
        Console.WriteLine($"         Output: [{string.Join(",", values4)}], Expected: [0]");
        bool passed4 = values4.Count == 1 && values4[0] == 0;
        Console.WriteLine($"         {(passed4 ? "✓ PASSED" : "✗ FAILED")}\n");
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

