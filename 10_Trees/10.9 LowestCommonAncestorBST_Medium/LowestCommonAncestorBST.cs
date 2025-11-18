using System;

namespace DSA._10_9_LowestCommonAncestorBST_Medium;

/// <summary>
/// Problem 10.9 (Medium): Lowest Common Ancestor of a Binary Search Tree
/// Given a binary search tree (BST), find the lowest common ancestor (LCA) node of two given nodes in the BST.
/// 
/// The lowest common ancestor is defined between two nodes p and q as the lowest node in T that has both
/// p and q as descendants (where we allow a node to be a descendant of itself).
/// 
/// Example:
/// Input: root = [6,2,8,0,4,7,9,null,null,3,5], p = 2, q = 8
/// Output: 6
/// Explanation: The LCA of nodes 2 and 8 is 6.
/// 
/// Constraints:
/// - The number of nodes in the tree is in the range [2, 10^5].
/// - -10^9 <= Node.val <= 10^9
/// - All Node.val are unique.
/// - p != q
/// - p and q will exist in the BST.
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

public class LowestCommonAncestorBST
{
    public static TreeNode? LowestCommonAncestor(TreeNode? root, TreeNode? p, TreeNode? q)
    {
        // TODO: Implement solution
        // Hint: Use BST property - if both nodes are smaller, go left; if both larger, go right
        // Otherwise current node is LCA
        // Time Complexity: O(h)
        // Space Complexity: O(1)
        
        return null;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 10.9: Lowest Common Ancestor BST ===");
        
        var root1 = new TreeNode(6, 
            new TreeNode(2, new TreeNode(0), new TreeNode(4, new TreeNode(3), new TreeNode(5))), 
            new TreeNode(8, new TreeNode(7), new TreeNode(9)));
        var p1 = new TreeNode(2);
        var q1 = new TreeNode(8);
        var result1 = LowestCommonAncestor(root1, p1, q1);
        Console.WriteLine($"Test 1 - Input: root = [6,2,8,0,4,7,9,null,null,3,5], p = 2, q = 8");
        Console.WriteLine($"         Output: {(result1 != null ? result1.val.ToString() : "null")}, Expected: 6");
        Console.WriteLine($"         {(result1 != null && result1.val == 6 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        var p2 = new TreeNode(2);
        var q2 = new TreeNode(4);
        var result2 = LowestCommonAncestor(root1, p2, q2);
        Console.WriteLine($"Test 2 - Input: p = 2, q = 4");
        Console.WriteLine($"         Output: {(result2 != null ? result2.val.ToString() : "null")}, Expected: 2");
        Console.WriteLine($"         {(result2 != null && result2.val == 2 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

