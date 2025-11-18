using System;
using System.Collections.Generic;

namespace DSA._8_3_MergeKSortedLists_Hard;

/// <summary>
/// Problem 8.3 (Hard): Merge k Sorted Lists
/// You are given an array of k linked-lists lists, each linked-list is sorted in ascending order.
/// Merge all the linked-lists into one sorted linked-list and return it.
/// 
/// Example:
/// Input: lists = [[1,4,5],[1,3,4],[2,6]]
/// Output: [1,1,2,3,4,4,5,6]
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

public class MergeKSortedLists
{
    public static ListNode? Solution(ListNode?[] lists)
    {
        // TODO: Implement solution
        // Hint: Use priority queue or divide and conquer
        // Time Complexity: O(n log k) where n is total nodes, k is number of lists
        // Space Complexity: O(1) or O(k) depending on approach
        
        return null;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 8.3: Merge K Sorted Lists ===");
        
        var list1 = new ListNode(1, new ListNode(4, new ListNode(5)));
        var list2 = new ListNode(1, new ListNode(3, new ListNode(4)));
        var list3 = new ListNode(2, new ListNode(6));
        var lists = new ListNode?[] { list1, list2, list3 };
        var result1 = Solution(lists);
        var values1 = GetValues(result1);
        Console.WriteLine($"Test 1 - Input: [[1,4,5],[1,3,4],[2,6]]");
        Console.WriteLine($"         Output: [{string.Join(",", values1)}], Expected: [1,1,2,3,4,4,5,6]");
        bool passed1 = values1.Count == 8 && values1[0] == 1 && values1[7] == 6;
        Console.WriteLine($"         {(passed1 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        var lists2 = new ListNode?[] { null };
        var result2 = Solution(lists2);
        Console.WriteLine($"Test 2 - Input: [[]]");
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

