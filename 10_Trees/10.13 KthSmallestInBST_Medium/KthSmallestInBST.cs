using System;

namespace DSA._10_13_KthSmallestInBST_Medium;

/// <summary>
/// Problem 10.13 (Medium): Kth Smallest Element in a BST
/// Given the root of a binary search tree, and an integer k, return the kth smallest value
/// (1-indexed) of all the values of the nodes in the tree.
/// 
/// Example:
/// Input: root = [3,1,4,null,2], k = 1
/// Output: 1
/// 
/// Constraints:
/// - The number of nodes in the tree is n.
/// - 1 <= k <= n <= 10^4
/// - 0 <= Node.val <= 10^4
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

public class KthSmallestInBST
{
    public static int KthSmallest(TreeNode? root, int k)
    {
        // TODO: Implement solution
        // Hint: Inorder traversal gives sorted order, count nodes until kth
        // Time Complexity: O(h + k) where h is height
        // Space Complexity: O(h)
        
        return 0;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 10.13: Kth Smallest in BST ===");
        
        var root1 = new TreeNode(3, 
            new TreeNode(1, null, new TreeNode(2)), 
            new TreeNode(4));
        int result1 = KthSmallest(root1, 1);
        Console.WriteLine($"Test 1 - Input: [3,1,4,null,2], k = 1");
        Console.WriteLine($"         Output: {result1}, Expected: 1");
        Console.WriteLine($"         {(result1 == 1 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        var root2 = new TreeNode(5, 
            new TreeNode(3, new TreeNode(2, new TreeNode(1), null), new TreeNode(4)), 
            new TreeNode(6));
        int result2 = KthSmallest(root2, 3);
        Console.WriteLine($"Test 2 - Input: [5,3,6,2,4,null,null,1], k = 3");
        Console.WriteLine($"         Output: {result2}, Expected: 3");
        Console.WriteLine($"         {(result2 == 3 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

