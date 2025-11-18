using System;

namespace DSA._10_4_InvertBinaryTree_Easy;

/// <summary>
/// Problem 10.4 (Easy): Invert Binary Tree
/// Given the root of a binary tree, invert the tree, and return its root.
/// 
/// Example:
/// Input: root = [4,2,7,1,3,6,9]
/// Output: [4,7,2,9,6,3,1]
/// 
/// Constraints:
/// - The number of nodes in the tree is in the range [0, 100].
/// - -100 <= Node.val <= 100
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

public class InvertBinaryTree
{
    public static TreeNode? InvertTree(TreeNode? root)
    {
        // TODO: Implement solution
        // Hint: Recursively swap left and right children
        // Time Complexity: O(n)
        // Space Complexity: O(h) where h is height
        
        return null;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 10.4: Invert Binary Tree ===");
        
        var root1 = new TreeNode(4, 
            new TreeNode(2, new TreeNode(1), new TreeNode(3)), 
            new TreeNode(7, new TreeNode(6), new TreeNode(9)));
        var result1 = InvertTree(root1);
        Console.WriteLine($"Test 1 - Input: [4,2,7,1,3,6,9]");
        Console.WriteLine($"         Output: {(result1 != null ? "Tree inverted" : "null")}");
        bool passed1 = result1 != null && result1.left != null && result1.left.val == 7;
        Console.WriteLine($"         {(passed1 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        var root2 = new TreeNode(2, new TreeNode(1), new TreeNode(3));
        var result2 = InvertTree(root2);
        Console.WriteLine($"Test 2 - Input: [2,1,3]");
        Console.WriteLine($"         Output: {(result2 != null ? "Tree inverted" : "null")}");
        bool passed2 = result2 != null;
        Console.WriteLine($"         {(passed2 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

