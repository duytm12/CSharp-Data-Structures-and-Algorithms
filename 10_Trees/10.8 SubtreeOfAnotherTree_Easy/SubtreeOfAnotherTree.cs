using System;

namespace DSA._10_8_SubtreeOfAnotherTree_Easy;

/// <summary>
/// Problem 10.8 (Easy): Subtree of Another Tree
/// Given the roots of two binary trees root and subRoot, return true if there is a subtree of root
/// with the same structure and node values of subRoot and false otherwise.
/// 
/// A subtree of a binary tree tree is a tree that consists of a node in tree and all of this node's
/// descendants. The tree tree could also be considered as a subtree of itself.
/// 
/// Example:
/// Input: root = [3,4,5,1,2], subRoot = [4,1,2]
/// Output: true
/// 
/// Constraints:
/// - The number of nodes in the root tree is in the range [1, 2000].
/// - The number of nodes in the subRoot tree is in the range [1, 1000].
/// - -10^4 <= root.val <= 10^4
/// - -10^4 <= subRoot.val <= 10^4
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

public class SubtreeOfAnotherTree
{
    public static bool IsSubtree(TreeNode? root, TreeNode? subRoot)
    {
        // TODO: Implement solution
        // Hint: For each node, check if subtree starting from that node matches subRoot
        // Use helper function to check if two trees are identical
        // Time Complexity: O(m * n) where m and n are sizes of trees
        // Space Complexity: O(h)
        
        return false;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 10.8: Subtree of Another Tree ===");
        
        var root1 = new TreeNode(3, 
            new TreeNode(4, new TreeNode(1), new TreeNode(2)), 
            new TreeNode(5));
        var subRoot1 = new TreeNode(4, new TreeNode(1), new TreeNode(2));
        bool result1 = IsSubtree(root1, subRoot1);
        Console.WriteLine($"Test 1 - Input: root = [3,4,5,1,2], subRoot = [4,1,2]");
        Console.WriteLine($"         Output: {result1}, Expected: True");
        Console.WriteLine($"         {(result1 == true ? "✓ PASSED" : "✗ FAILED")}\n");
        
        var root2 = new TreeNode(3, 
            new TreeNode(4, new TreeNode(1), new TreeNode(2, new TreeNode(0), null)), 
            new TreeNode(5));
        var subRoot2 = new TreeNode(4, new TreeNode(1), new TreeNode(2));
        bool result2 = IsSubtree(root2, subRoot2);
        Console.WriteLine($"Test 2 - Input: root = [3,4,5,1,2,null,null,null,null,0], subRoot = [4,1,2]");
        Console.WriteLine($"         Output: {result2}, Expected: False");
        Console.WriteLine($"         {(result2 == false ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

