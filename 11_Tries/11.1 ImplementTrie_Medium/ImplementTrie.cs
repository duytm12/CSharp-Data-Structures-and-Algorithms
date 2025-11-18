using System;
using System.Collections.Generic;

namespace DSA._11_1_ImplementTrie_Medium;

/// <summary>
/// Problem 11.1 (Medium): Implement Trie (Prefix Tree)
/// Implement a trie with insert, search, and startsWith methods.
/// 
/// Example:
/// Trie trie = new Trie();
/// trie.Insert("apple");
/// trie.Search("apple");   // returns true
/// trie.Search("app");     // returns false
/// trie.StartsWith("app"); // returns true
/// </summary>
public class TrieNode
{
    public Dictionary<char, TrieNode> children;
    public bool isEndOfWord;
    
    public TrieNode()
    {
        children = new Dictionary<char, TrieNode>();
        isEndOfWord = false;
    }
}

public class Trie
{
    private TrieNode root;
    
    public Trie()
    {
        root = new TrieNode();
    }
    
    public void Insert(string word)
    {
        // TODO: Implement insert method
        // Time Complexity: O(m) where m is word length
        // Space Complexity: O(m)
    }
    
    public bool Search(string word)
    {
        // TODO: Implement search method
        // Time Complexity: O(m)
        // Space Complexity: O(1)
        
        return false;
    }
    
    public bool StartsWith(string prefix)
    {
        // TODO: Implement startsWith method
        // Time Complexity: O(m)
        // Space Complexity: O(1)
        
        return false;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 11.1: Implement Trie ===");
        
        var trie = new Trie();
        trie.Insert("apple");
        bool result1 = trie.Search("apple");
        bool result2 = trie.Search("app");
        bool result3 = trie.StartsWith("app");
        Console.WriteLine($"Test 1 - Insert: \"apple\", Search(\"apple\") = {result1}, Search(\"app\") = {result2}, StartsWith(\"app\") = {result3}");
        Console.WriteLine($"         Expected: True, False, True");
        bool passed1 = result1 == true && result2 == false && result3 == true;
        Console.WriteLine($"         {(passed1 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        trie.Insert("app");
        bool result4 = trie.Search("app");
        Console.WriteLine($"Test 2 - Insert: \"app\", Search(\"app\") = {result4}");
        Console.WriteLine($"         Expected: True");
        Console.WriteLine($"         {(result4 == true ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

