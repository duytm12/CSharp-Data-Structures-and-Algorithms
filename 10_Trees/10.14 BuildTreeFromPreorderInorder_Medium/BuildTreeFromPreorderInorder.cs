using System;
using System.Collections.Generic;

namespace DSA._10_14_BuildTreeFromPreorderInorder_Medium;

/// <summary>
/// Problem 10.14 (Medium): Construct Binary Tree from Preorder and Inorder Traversal
/// Given two integer arrays preorder and inorder where preorder is the preorder traversal of a
/// binary tree and inorder is the inorder traversal of the same tree, construct and return the binary tree.
/// 
/// Example:
/// Input: preorder = [3,9,20,15,7], inorder = [9,3,15,20,7]
/// Output: [3,9,20,null,null,15,7]
/// 
/// Constraints:
/// - 1 <= preorder.length <= 3000
/// - inorder.length == preorder.length
/// - -3000 <= preorder[i], inorder[i] <= 3000
/// - preorder and inorder consist of unique values.
/// - Each value of inorder also appears in preorder.
/// - preorder is guaranteed to be the preorder traversal of the tree.
/// - inorder is guaranteed to be the inorder traversal of the tree.
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

public class BuildTreeFromPreorderInorder
{
    public static TreeNode? BuildTree(int[] preorder, int[] inorder)
    {
        // TODO: Implement solution
        // Hint: First element of preorder is root, find root in inorder to split left/right subtrees
        // Recursively build left and right subtrees
        // Time Complexity: O(n)
        // Space Complexity: O(n)
        
        return null;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 10.14: Build Tree from Preorder and Inorder ===");
        
        int[] preorder1 = { 3, 9, 20, 15, 7 };
        int[] inorder1 = { 9, 3, 15, 20, 7 };
        var result1 = BuildTree(preorder1, inorder1);
        Console.WriteLine($"Test 1 - Input: preorder = [3,9,20,15,7], inorder = [9,3,15,20,7]");
        Console.WriteLine($"         Output: {(result1 != null ? "Tree built" : "null")}");
        bool passed1 = result1 != null && result1.val == 3;
        Console.WriteLine($"         {(passed1 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[] preorder2 = { -1 };
        int[] inorder2 = { -1 };
        var result2 = BuildTree(preorder2, inorder2);
        Console.WriteLine($"Test 2 - Input: preorder = [-1], inorder = [-1]");
        Console.WriteLine($"         Output: {(result2 != null ? "Tree built" : "null")}");
        bool passed2 = result2 != null && result2.val == -1;
        Console.WriteLine($"         {(passed2 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

