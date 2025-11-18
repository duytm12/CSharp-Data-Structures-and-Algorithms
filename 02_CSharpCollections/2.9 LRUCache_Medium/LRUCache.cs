using System;
using System.Collections.Generic;

namespace DSA._2_9_LRUCache_Medium;

/// <summary>
/// Problem 2.9 (Medium): LRU Cache
/// Design a data structure that follows the constraints of a Least Recently Used (LRU) cache.
/// Implement the LRUCache class using Dictionary and LinkedList:
/// - LRUCache(int capacity) Initialize the LRU cache with positive size capacity.
/// - int Get(int key) Return the value of the key if the key exists, otherwise return -1.
/// - void Put(int key, int value) Update the value of the key if the key exists. Otherwise,
///   add the key-value pair to the cache. If the number of keys exceeds the capacity from this
///   operation, evict the least recently used key.
/// 
/// Example:
/// LRUCache lRUCache = new LRUCache(2);
/// lRUCache.Put(1, 1); // cache is {1=1}
/// lRUCache.Put(2, 2); // cache is {1=1, 2=2}
/// lRUCache.Get(1);    // return 1
/// lRUCache.Put(3, 3); // LRU key was 2, evicts key 2, cache is {1=1, 3=3}
/// lRUCache.Get(2);    // returns -1 (not found)
/// 
/// Constraints:
/// - 1 <= capacity <= 3000
/// - 0 <= key <= 10^4
/// - 0 <= value <= 10^5
/// - At most 2 * 10^5 calls will be made to Get and Put.
/// </summary>
public class LRUCache
{
    // TODO: Implement LRU Cache using Dictionary and LinkedList
    // Hint: Use Dictionary for O(1) lookup and LinkedList for O(1) insertion/deletion
    // Time Complexity: O(1) for both Get and Put
    // Space Complexity: O(capacity)
    
    public LRUCache(int capacity)
    {
        // Initialize your data structure here
    }
    
    public int Get(int key)
    {
        // TODO: Implement get and move to front
        return -1;
    }
    
    public void Put(int key, int value)
    {
        // TODO: Implement put, update if exists, add if new, evict if full
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 2.9: LRU Cache ===");
        
        var lRUCache = new LRUCache(2);
        lRUCache.Put(1, 1);
        lRUCache.Put(2, 2);
        int result1 = lRUCache.Get(1);
        Console.WriteLine($"Test 1 - Put(1,1), Put(2,2), Get(1)");
        Console.WriteLine($"         Output: {result1}, Expected: 1");
        Console.WriteLine($"         {(result1 == 1 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        lRUCache.Put(3, 3);
        int result2 = lRUCache.Get(2);
        Console.WriteLine($"Test 2 - Put(3,3), Get(2)");
        Console.WriteLine($"         Output: {result2}, Expected: -1");
        Console.WriteLine($"         {(result2 == -1 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

