using System;

namespace DSA._10_7_SameTree_Easy;

/// <summary>
/// Problem 10.7 (Easy): Same Tree
/// Given the roots of two binary trees p and q, write a function to check if they are the same or not.
/// Two binary trees are considered the same if they are structurally identical, and the nodes have the same value.
/// 
/// Example:
/// Input: p = [1,2,3], q = [1,2,3]
/// Output: true
/// 
/// Constraints:
/// - The number of nodes in both trees is in the range [0, 100].
/// - -10^4 <= Node.val <= 10^4
/// </summary>
public class TreeNode
{
    public int val;
    public TreeNode? left;
    public TreeNode? right;
    
    public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class SameTree
{
    public static bool IsSameTree(TreeNode? p, TreeNode? q)
    {
        // TODO: Implement solution
        // Hint: Recursively check if nodes are equal and subtrees are same
        // Time Complexity: O(min(m, n))
        // Space Complexity: O(min(m, n))
        
        return false;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 10.7: Same Tree ===");
        
        var p1 = new TreeNode(1, new TreeNode(2), new TreeNode(3));
        var q1 = new TreeNode(1, new TreeNode(2), new TreeNode(3));
        bool result1 = IsSameTree(p1, q1);
        Console.WriteLine($"Test 1 - Input: p = [1,2,3], q = [1,2,3]");
        Console.WriteLine($"         Output: {result1}, Expected: True");
        Console.WriteLine($"         {(result1 == true ? "✓ PASSED" : "✗ FAILED")}\n");
        
        var p2 = new TreeNode(1, new TreeNode(2), null);
        var q2 = new TreeNode(1, null, new TreeNode(2));
        bool result2 = IsSameTree(p2, q2);
        Console.WriteLine($"Test 2 - Input: p = [1,2], q = [1,null,2]");
        Console.WriteLine($"         Output: {result2}, Expected: False");
        Console.WriteLine($"         {(result2 == false ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

