using System;

namespace DSA._10_1_MaxDepth_Easy;

/// <summary>
/// Problem 10.1 (Easy): Maximum Depth of Binary Tree
/// Given the root of a binary tree, return its maximum depth.
/// 
/// Example:
/// Input: root = [3,9,20,null,null,15,7]
/// Output: 3
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

public class MaxDepth
{
    /// <summary>
    /// Max depth = 1 + max(left subtree depth, right subtree depth).
    /// Base case: null node has depth 0.
    /// </summary>
    public static int Solution(TreeNode? root)
    {
        if (root == null) return 0;
        int leftDepth = Solution(root.left);
        int rightDepth = Solution(root.right);
        return 1 + Math.Max(leftDepth, rightDepth);
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 10.1: Maximum Depth ===");
        
        var root1 = new TreeNode(3, 
            new TreeNode(9), 
            new TreeNode(20, new TreeNode(15), new TreeNode(7)));
        int result1 = Solution(root1);
        Console.WriteLine($"Test 1 - Input: [3,9,20,null,null,15,7]");
        Console.WriteLine($"         Output: {result1}, Expected: 3");
        Console.WriteLine($"         {(result1 == 3 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        var root2 = new TreeNode(1, null, new TreeNode(2));
        int result2 = Solution(root2);
        Console.WriteLine($"Test 2 - Input: [1,null,2]");
        Console.WriteLine($"         Output: {result2}, Expected: 2");
        Console.WriteLine($"         {(result2 == 2 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

