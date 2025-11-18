using System;
using System.Collections.Generic;

namespace DSA._10_10_RightSideView_Medium;

/// <summary>
/// Problem 10.10 (Medium): Binary Tree Right Side View
/// Given the root of a binary tree, imagine yourself standing on the right side of it,
/// return the values of the nodes you can see ordered from top to bottom.
/// 
/// Example:
/// Input: root = [1,2,3,null,5,null,4]
/// Output: [1,3,4]
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

public class RightSideView
{
    public static IList<int> Solution(TreeNode? root)
    {
        // TODO: Implement solution
        // Hint: Use BFS (level order), add last node of each level to result
        // Time Complexity: O(n)
        // Space Complexity: O(n)
        
        return new List<int>();
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 10.10: Right Side View ===");
        
        var root1 = new TreeNode(1, 
            new TreeNode(2, null, new TreeNode(5)), 
            new TreeNode(3, null, new TreeNode(4)));
        var result1 = Solution(root1);
        Console.WriteLine($"Test 1 - Input: [1,2,3,null,5,null,4]");
        Console.WriteLine($"         Output: [{string.Join(",", result1)}], Expected: [1,3,4]");
        bool passed1 = result1.Count == 3 && result1[0] == 1 && result1[2] == 4;
        Console.WriteLine($"         {(passed1 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        var root2 = new TreeNode(1, null, new TreeNode(3));
        var result2 = Solution(root2);
        Console.WriteLine($"Test 2 - Input: [1,null,3]");
        Console.WriteLine($"         Output: [{string.Join(",", result2)}], Expected: [1,3]");
        bool passed2 = result2.Count == 2 && result2[0] == 1 && result2[1] == 3;
        Console.WriteLine($"         {(passed2 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

