using System;

namespace DSA._10_11_CountGoodNodes_Medium;

/// <summary>
/// Problem 10.11 (Medium): Count Good Nodes in Binary Tree
/// Given a binary tree root, a node X in the tree is named good if in the path from root to X
/// there are no nodes with a value greater than X.
/// 
/// Return the number of good nodes in the binary tree.
/// 
/// Example:
/// Input: root = [3,1,4,3,null,1,5]
/// Output: 4
/// Explanation: Nodes in blue are good.
/// Root Node (3) is always a good node.
/// Node 4 -> (3,4) is the maximum value in the path
/// Node 5 -> (3,4,5) is the maximum value in the path
/// Node 3 -> (3,1,3) is the maximum value in the path.
/// 
/// Constraints:
/// - The number of nodes in the binary tree is in the range [1, 10^5].
/// - Each node's value is between [-10^4, 10^4].
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

public class CountGoodNodes
{
    public static int GoodNodes(TreeNode? root)
    {
        // TODO: Implement solution
        // Hint: DFS, track maximum value seen in path from root
        // Increment count if current node value >= max
        // Time Complexity: O(n)
        // Space Complexity: O(h)
        
        return 0;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 10.11: Count Good Nodes ===");
        
        var root1 = new TreeNode(3, 
            new TreeNode(1, new TreeNode(3), null), 
            new TreeNode(4, new TreeNode(1), new TreeNode(5)));
        int result1 = GoodNodes(root1);
        Console.WriteLine($"Test 1 - Input: [3,1,4,3,null,1,5]");
        Console.WriteLine($"         Output: {result1}, Expected: 4");
        Console.WriteLine($"         {(result1 == 4 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        var root2 = new TreeNode(3, new TreeNode(3, new TreeNode(4), new TreeNode(2)), null);
        int result2 = GoodNodes(root2);
        Console.WriteLine($"Test 2 - Input: [3,3,null,4,2]");
        Console.WriteLine($"         Output: {result2}, Expected: 3");
        Console.WriteLine($"         {(result2 == 3 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

