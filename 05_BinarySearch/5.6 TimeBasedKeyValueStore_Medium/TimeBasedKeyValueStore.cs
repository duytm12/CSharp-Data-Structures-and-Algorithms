using System;
using System.Collections.Generic;

namespace DSA._5_6_TimeBasedKeyValueStore_Medium;

/// <summary>
/// Problem 5.6 (Medium): Time Based Key-Value Store
/// Design a time-based key-value data structure that can store multiple values for the same key
/// at different time stamps and retrieve the key's value at a certain timestamp.
/// 
/// Implement the TimeMap class:
/// - TimeMap() Initializes the object of the data structure.
/// - void Set(string key, string value, int timestamp) Stores the key key with the value value
///   at the given time timestamp.
/// - string Get(string key, int timestamp) Returns a value such that set was called previously,
///   with timestamp_prev <= timestamp. If there are multiple such values, it returns the value
///   associated with the largest timestamp_prev. If no values exist at that timestamp, returns "".
/// 
/// Example:
/// TimeMap timeMap = new TimeMap();
/// timeMap.Set("foo", "bar", 1);  // store the key "foo" and value "bar" along with timestamp = 1.
/// timeMap.Get("foo", 1);         // return "bar"
/// timeMap.Get("foo", 3);         // return "bar", since there is no value corresponding to foo at timestamp 3 and timestamp 2, then the only value is at timestamp 1 is "bar".
/// timeMap.Set("foo", "bar2", 4); // store the key "foo" and value "bar2" along with timestamp = 4.
/// timeMap.Get("foo", 4);         // return "bar2"
/// timeMap.Get("foo", 5);         // return "bar2"
/// 
/// Constraints:
/// - 1 <= key.length, value.length <= 100
/// - key and value consist of lowercase English letters and digits.
/// - 1 <= timestamp <= 10^7
/// - All the timestamps timestamp of set are strictly increasing.
/// - At most 2 * 10^5 calls will be made to set and get.
/// </summary>
public class TimeMap
{
    // TODO: Implement TimeMap using Dictionary and binary search
    // Hint: Dictionary<string, List<(timestamp, value)>>, use binary search for Get
    // Time Complexity: O(1) for Set, O(log n) for Get
    // Space Complexity: O(n)
    
    public TimeMap()
    {
        // Initialize your data structure here
    }
    
    public void Set(string key, string value, int timestamp)
    {
        // TODO: Implement set
    }
    
    public string Get(string key, int timestamp)
    {
        // TODO: Implement get with binary search
        return string.Empty;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 5.6: Time Based Key-Value Store ===");
        
        var timeMap = new TimeMap();
        timeMap.Set("foo", "bar", 1);
        string result1 = timeMap.Get("foo", 1);
        Console.WriteLine($"Test 1 - Set(\"foo\", \"bar\", 1), Get(\"foo\", 1)");
        Console.WriteLine($"         Output: \"{result1}\", Expected: \"bar\"");
        Console.WriteLine($"         {(result1 == "bar" ? "✓ PASSED" : "✗ FAILED")}\n");
        
        string result2 = timeMap.Get("foo", 3);
        timeMap.Set("foo", "bar2", 4);
        string result3 = timeMap.Get("foo", 4);
        Console.WriteLine($"Test 2 - Get(\"foo\", 3), Set(\"foo\", \"bar2\", 4), Get(\"foo\", 4)");
        Console.WriteLine($"         Output: Get(3)=\"{result2}\", Get(4)=\"{result3}\", Expected: \"bar\", \"bar2\"");
        Console.WriteLine($"         {(result2 == "bar" && result3 == "bar2" ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

