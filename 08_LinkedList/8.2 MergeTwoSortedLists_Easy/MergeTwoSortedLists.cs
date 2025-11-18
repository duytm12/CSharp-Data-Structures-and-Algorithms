using System;
using System.Collections.Generic;

namespace DSA._8_2_MergeTwoSortedLists_Easy;

/// <summary>
/// Problem 8.2 (Easy): Merge Two Sorted Lists
/// You are given the heads of two sorted linked lists list1 and list2.
/// Merge the two lists in a one sorted list.
/// 
/// Example:
/// Input: list1 = [1,2,4], list2 = [1,3,4]
/// Output: [1,1,2,3,4,4]
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
        // Hint: Use dummy node, compare and merge
        // Time Complexity: O(n + m)
        // Space Complexity: O(1)
        
        return null;
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

