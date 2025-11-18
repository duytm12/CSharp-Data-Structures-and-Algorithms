using System;
using System.Collections.Generic;

namespace DSA._10_3_SerializeDeserialize_Hard;

/// <summary>
/// Problem 10.3 (Hard): Serialize and Deserialize Binary Tree
/// Design an algorithm to serialize and deserialize a binary tree.
/// 
/// Example:
/// Input: root = [1,2,3,null,null,4,5]
/// Serialize: "1,2,3,null,null,4,5"
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

public class Codec
{
    // TODO: Implement Serialize and Deserialize methods
    // Hint: Use preorder traversal with null markers
    // Time Complexity: O(n) for both
    // Space Complexity: O(n) for both
    
    public string Serialize(TreeNode? root)
    {
        return string.Empty;
    }
    
    public TreeNode? Deserialize(string data)
    {
        return null;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 10.3: Serialize and Deserialize ===");
        
        var codec = new Codec();
        var root1 = new TreeNode(1, 
            new TreeNode(2), 
            new TreeNode(3, new TreeNode(4), new TreeNode(5)));
        string serialized1 = codec.Serialize(root1);
        var deserialized1 = codec.Deserialize(serialized1);
        Console.WriteLine($"Test 1 - Input: [1,2,3,null,null,4,5]");
        Console.WriteLine($"         Serialized: \"{serialized1}\"");
        Console.WriteLine($"         Deserialized: {(deserialized1 != null ? "Tree created" : "null")}");
        bool passed1 = deserialized1 != null && deserialized1.val == 1;
        Console.WriteLine($"         {(passed1 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        var deserialized2 = codec.Deserialize("");
        Console.WriteLine($"Test 2 - Input: null");
        Console.WriteLine($"         Deserialized: {(deserialized2 == null ? "null" : "not null")}, Expected: null");
        Console.WriteLine($"         {(deserialized2 == null ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

