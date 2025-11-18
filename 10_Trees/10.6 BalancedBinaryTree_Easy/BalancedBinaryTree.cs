using System;

namespace DSA._10_6_BalancedBinaryTree_Easy;

/// <summary>
/// Problem 10.6 (Easy): Balanced Binary Tree
/// Given a binary tree, determine if it is height-balanced.
/// A height-balanced binary tree is a binary tree in which the left and right subtrees of every
/// node differ in height by no more than 1.
/// 
/// Example:
/// Input: root = [3,9,20,null,null,15,7]
/// Output: true
/// 
/// Constraints:
/// - The number of nodes in the tree is in the range [0, 5000].
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

public class BalancedBinaryTree
{
    public static bool IsBalanced(TreeNode? root)
    {
        // TODO: Implement solution
        // Hint: Check height difference at each node, return -1 if unbalanced
        // Time Complexity: O(n)
        // Space Complexity: O(h)
        
        return false;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 10.6: Balanced Binary Tree ===");
        
        var root1 = new TreeNode(3, 
            new TreeNode(9), 
            new TreeNode(20, new TreeNode(15), new TreeNode(7)));
        bool result1 = IsBalanced(root1);
        Console.WriteLine($"Test 1 - Input: [3,9,20,null,null,15,7]");
        Console.WriteLine($"         Output: {result1}, Expected: True");
        Console.WriteLine($"         {(result1 == true ? "✓ PASSED" : "✗ FAILED")}\n");
        
        var root2 = new TreeNode(1, 
            new TreeNode(2, new TreeNode(3, new TreeNode(4), new TreeNode(4)), new TreeNode(3)), 
            new TreeNode(2));
        bool result2 = IsBalanced(root2);
        Console.WriteLine($"Test 2 - Input: [1,2,2,3,3,null,null,4,4]");
        Console.WriteLine($"         Output: {result2}, Expected: False");
        Console.WriteLine($"         {(result2 == false ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

