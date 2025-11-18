using System;

namespace DSA._10_5_DiameterOfBinaryTree_Easy;

/// <summary>
/// Problem 10.5 (Easy): Diameter of Binary Tree
/// Given the root of a binary tree, return the length of the diameter of the tree.
/// The diameter of a binary tree is the length of the longest path between any two nodes in a tree.
/// This path may or may not pass through the root.
/// 
/// Example:
/// Input: root = [1,2,3,4,5]
/// Output: 3
/// Explanation: 3 is the length of the path [4,2,1,3] or [5,2,1,3].
/// 
/// Constraints:
/// - The number of nodes in the tree is in the range [1, 10^4].
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

public class DiameterOfBinaryTree
{
    public static int Solution(TreeNode? root)
    {
        // TODO: Implement solution
        // Hint: For each node, calculate diameter passing through it (left height + right height)
        // Track maximum diameter seen
        // Time Complexity: O(n)
        // Space Complexity: O(h)
        
        return 0;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 10.5: Diameter of Binary Tree ===");
        
        var root1 = new TreeNode(1, 
            new TreeNode(2, new TreeNode(4), new TreeNode(5)), 
            new TreeNode(3));
        int result1 = Solution(root1);
        Console.WriteLine($"Test 1 - Input: [1,2,3,4,5]");
        Console.WriteLine($"         Output: {result1}, Expected: 3");
        Console.WriteLine($"         {(result1 == 3 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        var root2 = new TreeNode(1, new TreeNode(2), null);
        int result2 = Solution(root2);
        Console.WriteLine($"Test 2 - Input: [1,2]");
        Console.WriteLine($"         Output: {result2}, Expected: 1");
        Console.WriteLine($"         {(result2 == 1 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

