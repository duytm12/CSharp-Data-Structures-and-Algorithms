using System;
using System.Collections.Generic;

namespace DSA._10_2_LevelOrderTraversal_Medium;

/// <summary>
/// Problem 10.2 (Medium): Binary Tree Level Order Traversal
/// Given the root of a binary tree, return the level order traversal of its nodes' values.
/// 
/// Example:
/// Input: root = [3,9,20,null,null,15,7]
/// Output: [[3],[9,20],[15,7]]
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

public class LevelOrderTraversal
{
    public static IList<IList<int>> Solution(TreeNode? root)
    {
        // TODO: Implement solution
        // Hint: Use BFS with queue, process level by level
        // Time Complexity: O(n)
        // Space Complexity: O(n)
        
        return new List<IList<int>>();
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 10.2: Level Order Traversal ===");
        
        var root1 = new TreeNode(3, 
            new TreeNode(9), 
            new TreeNode(20, new TreeNode(15), new TreeNode(7)));
        var result1 = Solution(root1);
        Console.WriteLine($"Test 1 - Input: [3,9,20,null,null,15,7]");
        Console.WriteLine($"         Output: {result1.Count} levels, Expected: 3 levels");
        bool passed1 = result1.Count == 3;
        Console.WriteLine($"         {(passed1 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        var root2 = new TreeNode(1);
        var result2 = Solution(root2);
        Console.WriteLine($"Test 2 - Input: [1]");
        Console.WriteLine($"         Output: {result2.Count} levels, Expected: 1 level");
        bool passed2 = result2.Count == 1;
        Console.WriteLine($"         {(passed2 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

