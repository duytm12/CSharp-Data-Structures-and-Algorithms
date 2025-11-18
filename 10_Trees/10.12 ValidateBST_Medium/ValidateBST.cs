using System;

namespace DSA._10_12_ValidateBST_Medium;

/// <summary>
/// Problem 10.12 (Medium): Validate Binary Search Tree
/// Given the root of a binary tree, determine if it is a valid binary search tree (BST).
/// 
/// A valid BST is defined as follows:
/// - The left subtree of a node contains only nodes with keys less than the node's key.
/// - The right subtree of a node contains only nodes with keys greater than the node's key.
/// - Both the left and right subtrees must also be binary search trees.
/// 
/// Example:
/// Input: root = [2,1,3]
/// Output: true
/// 
/// Constraints:
/// - The number of nodes in the tree is in the range [1, 10^4].
/// - -2^31 <= Node.val <= 2^31 - 1
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

public class ValidateBST
{
    public static bool IsValidBST(TreeNode? root)
    {
        // TODO: Implement solution
        // Hint: Use bounds (min, max) for each node, check if node value is within bounds
        // Time Complexity: O(n)
        // Space Complexity: O(h)
        
        return false;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 10.12: Validate BST ===");
        
        var root1 = new TreeNode(2, new TreeNode(1), new TreeNode(3));
        bool result1 = IsValidBST(root1);
        Console.WriteLine($"Test 1 - Input: [2,1,3]");
        Console.WriteLine($"         Output: {result1}, Expected: True");
        Console.WriteLine($"         {(result1 == true ? "✓ PASSED" : "✗ FAILED")}\n");
        
        var root2 = new TreeNode(5, 
            new TreeNode(1), 
            new TreeNode(4, new TreeNode(3), new TreeNode(6)));
        bool result2 = IsValidBST(root2);
        Console.WriteLine($"Test 2 - Input: [5,1,4,null,null,3,6]");
        Console.WriteLine($"         Output: {result2}, Expected: False");
        Console.WriteLine($"         {(result2 == false ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

