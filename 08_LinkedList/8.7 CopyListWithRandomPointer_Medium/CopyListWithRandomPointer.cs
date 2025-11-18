using System;
using System.Collections.Generic;

namespace DSA._8_7_CopyListWithRandomPointer_Medium;

/// <summary>
/// Problem 8.7 (Medium): Copy List with Random Pointer
/// A linked list of length n is given such that each node contains an additional random pointer,
/// which could point to any node in the list, or null.
/// 
/// Construct a deep copy of the list. The deep copy should consist of exactly n brand new nodes,
/// where each new node has its value set to the value of its corresponding original node. Both
/// the next and random pointer of the new nodes should point to new nodes in the copied list such
/// that the pointers in the original list and copied list represent the same list state. None of
/// the pointers in the new list should point to nodes in the original list.
/// 
/// Example:
/// Input: head = [[7,null],[13,0],[11,4],[10,2],[1,0]]
/// Output: [[7,null],[13,0],[11,4],[10,2],[1,0]]
/// 
/// Constraints:
/// - 0 <= n <= 1000
/// - -10^4 <= Node.val <= 10^4
/// - Node.random is null or is pointing to some node in the linked list.
/// </summary>
public class Node
{
    public int val;
    public Node? next;
    public Node? random;
    
    public Node(int _val)
    {
        val = _val;
        next = null;
        random = null;
    }
}

public class CopyListWithRandomPointer
{
    public static Node? CopyRandomList(Node? head)
    {
        // TODO: Implement solution
        // Hint: Use Dictionary to map original nodes to copied nodes
        // Two passes: first create all nodes, second set next and random pointers
        // Time Complexity: O(n)
        // Space Complexity: O(n)
        
        return null;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 8.7: Copy List with Random Pointer ===");
        
        var node1 = new Node(7);
        var node2 = new Node(13);
        var node3 = new Node(11);
        var node4 = new Node(10);
        var node5 = new Node(1);
        node1.next = node2;
        node2.next = node3;
        node3.next = node4;
        node4.next = node5;
        node2.random = node1;
        node3.random = node5;
        node4.random = node3;
        node5.random = node1;
        
        var result1 = CopyRandomList(node1);
        Console.WriteLine($"Test 1 - Input: [[7,null],[13,0],[11,4],[10,2],[1,0]]");
        Console.WriteLine($"         Output: {(result1 != null ? "Copied list created" : "null")}");
        bool passed1 = result1 != null && result1.val == 7 && result1.next != null && result1.next.val == 13;
        Console.WriteLine($"         {(passed1 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        var result2 = CopyRandomList(null);
        Console.WriteLine($"Test 2 - Input: null");
        Console.WriteLine($"         Output: {(result2 == null ? "null" : "not null")}, Expected: null");
        Console.WriteLine($"         {(result2 == null ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

