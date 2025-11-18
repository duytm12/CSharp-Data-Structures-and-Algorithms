using System;
using System.Collections.Generic;

namespace DSA._11_3_DesignAddAndSearchWords_Medium;

/// <summary>
/// Problem 11.3 (Medium): Design Add and Search Words Data Structure
/// Design a data structure that supports adding new words and finding if a string matches any
/// previously added string.
/// 
/// Implement the WordDictionary class:
/// - WordDictionary() Initializes the object.
/// - void AddWord(word) Adds word to the data structure, it can be matched later.
/// - bool Search(word) Returns true if there is any string in the data structure that matches
///   word or false otherwise. word may contain dots '.' where dots can be matched with any letter.
/// 
/// Example:
/// WordDictionary wordDictionary = new WordDictionary();
/// wordDictionary.AddWord("bad");
/// wordDictionary.AddWord("dad");
/// wordDictionary.AddWord("mad");
/// wordDictionary.Search("pad"); // return False
/// wordDictionary.Search("bad"); // return True
/// wordDictionary.Search(".ad"); // return True
/// wordDictionary.Search("b.."); // return True
/// 
/// Constraints:
/// - 1 <= word.length <= 25
/// - word in addWord consists of lowercase English letters.
/// - word in search consist of '.' or lowercase English letters.
/// - There will be at most 2 * 10^4 calls to addWord and search.
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

public class WordDictionary
{
    private TrieNode root;
    
    public WordDictionary()
    {
        root = new TrieNode();
    }
    
    public void AddWord(string word)
    {
        // TODO: Implement add word
        // Time Complexity: O(m) where m is word length
        // Space Complexity: O(m)
    }
    
    public bool Search(string word)
    {
        // TODO: Implement search with wildcard support ('.' matches any character)
        // Hint: Use DFS when encountering '.'
        // Time Complexity: O(26^m) worst case with all dots, O(m) best case
        // Space Complexity: O(m) for recursion stack
        
        return false;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 11.2: Design Add and Search Words ===");
        
        var wordDict = new WordDictionary();
        wordDict.AddWord("bad");
        wordDict.AddWord("dad");
        wordDict.AddWord("mad");
        bool result1 = wordDict.Search("pad");
        bool result2 = wordDict.Search("bad");
        bool result3 = wordDict.Search(".ad");
        Console.WriteLine($"Test 1 - AddWord: [\"bad\",\"dad\",\"mad\"], Search(\"pad\") = {result1}, Search(\"bad\") = {result2}, Search(\".ad\") = {result3}");
        Console.WriteLine($"         Expected: False, True, True");
        bool passed1 = result1 == false && result2 == true && result3 == true;
        Console.WriteLine($"         {(passed1 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        bool result4 = wordDict.Search("b..");
        Console.WriteLine($"Test 2 - Search(\"b..\") = {result4}");
        Console.WriteLine($"         Expected: True");
        Console.WriteLine($"         {(result4 == true ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

