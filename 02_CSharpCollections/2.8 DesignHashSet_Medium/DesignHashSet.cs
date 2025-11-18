using System;
using System.Collections.Generic;

namespace DSA._2_8_DesignHashSet_Medium;

/// <summary>
/// Problem 2.8 (Medium): Design HashSet
/// Design a HashSet without using any built-in hash table libraries.
/// Implement MyHashSet class:
/// - void add(key) Inserts the value key into the HashSet.
/// - bool contains(key) Returns whether the value key exists in the HashSet or not.
/// - void remove(key) Removes the value key in the HashSet. If key does not exist, do nothing.
/// 
/// Example:
/// MyHashSet myHashSet = new MyHashSet();
/// myHashSet.add(1);      // set = [1]
/// myHashSet.add(2);      // set = [1, 2]
/// myHashSet.contains(1); // return True
/// myHashSet.contains(3); // return False
/// myHashSet.remove(1);   // set = [2]
/// myHashSet.contains(1); // return False
/// 
/// Constraints:
/// - 0 <= key <= 10^6
/// - At most 10^4 calls will be made to add, remove, and contains.
/// </summary>
public class MyHashSet
{
    // TODO: Implement HashSet using array or List<List<int>> for chaining
    // Hint: Use array with boolean values or implement hash table with chaining
    // Time Complexity: O(1) average for all operations
    // Space Complexity: O(n)
    
    public MyHashSet()
    {
        // Initialize your data structure here
    }
    
    public void Add(int key)
    {
        // TODO: Implement add
    }
    
    public void Remove(int key)
    {
        // TODO: Implement remove
    }
    
    public bool Contains(int key)
    {
        // TODO: Implement contains
        return false;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 2.8: Design HashSet ===");
        
        var myHashSet = new MyHashSet();
        myHashSet.Add(1);
        myHashSet.Add(2);
        bool result1 = myHashSet.Contains(1);
        Console.WriteLine($"Test 1 - Add(1), Add(2), Contains(1)");
        Console.WriteLine($"         Output: {result1}, Expected: True");
        Console.WriteLine($"         {(result1 == true ? "✓ PASSED" : "✗ FAILED")}\n");
        
        bool result2 = myHashSet.Contains(3);
        myHashSet.Remove(1);
        bool result3 = myHashSet.Contains(1);
        Console.WriteLine($"Test 2 - Contains(3), Remove(1), Contains(1)");
        Console.WriteLine($"         Output: Contains(3)={result2}, Contains(1)={result3}, Expected: False, False");
        Console.WriteLine($"         {(result2 == false && result3 == false ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

