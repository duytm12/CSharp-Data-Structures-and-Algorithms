using System;

namespace DSA._10_15_BinaryTreeMaximumPathSum_Hard;

/// <summary>
/// Problem 10.15 (Hard): Binary Tree Maximum Path Sum
/// A path in a binary tree is a sequence of nodes where each pair of adjacent nodes in the sequence
/// has an edge connecting them. A node can only appear in the sequence at most once. Note that the
/// path does not need to pass through the root.
/// 
/// The path sum of a path is the sum of the node's values in the path.
/// 
/// Given the root of a binary tree, return the maximum path sum of any non-empty path.
/// 
/// Example:
/// Input: root = [1,2,3]
/// Output: 6
/// Explanation: The optimal path is 2 -> 1 -> 3 with a path sum of 2 + 1 + 3 = 6.
/// 
/// Constraints:
/// - The number of nodes in the tree is in the range [1, 3 * 10^4].
/// - -1000 <= Node.val <= 1000
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

public class BinaryTreeMaximumPathSum
{
    public static int MaxPathSum(TreeNode? root)
    {
        // TODO: Implement solution
        // Hint: For each node, calculate max path sum passing through it
        // Return max path sum that can be extended upward (single branch)
        // Track global maximum path sum
        // Time Complexity: O(n)
        // Space Complexity: O(h)
        
        return 0;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 10.15: Binary Tree Maximum Path Sum ===");
        
        var root1 = new TreeNode(1, new TreeNode(2), new TreeNode(3));
        int result1 = MaxPathSum(root1);
        Console.WriteLine($"Test 1 - Input: [1,2,3]");
        Console.WriteLine($"         Output: {result1}, Expected: 6");
        Console.WriteLine($"         {(result1 == 6 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        var root2 = new TreeNode(-10, new TreeNode(9), new TreeNode(20, new TreeNode(15), new TreeNode(7)));
        int result2 = MaxPathSum(root2);
        Console.WriteLine($"Test 2 - Input: [-10,9,20,null,null,15,7]");
        Console.WriteLine($"         Output: {result2}, Expected: 42");
        Console.WriteLine($"         {(result2 == 42 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

