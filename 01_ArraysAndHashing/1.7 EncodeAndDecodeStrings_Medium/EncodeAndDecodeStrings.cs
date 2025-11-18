using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSA._1_7_EncodeAndDecodeStrings_Medium;

/// <summary>
/// Problem 1.7 (Medium): Encode and Decode Strings
/// Design an algorithm to encode a list of strings to a string. The encoded string is then sent
/// over the network and is decoded back to the original list of strings.
/// 
/// Example:
/// Input: ["lint","code","love","you"]
/// Encoded: "4#lint4#code4#love3#you"
/// Output: ["lint","code","love","you"]
/// 
/// Constraints:
/// - 0 <= strs.length <= 100
/// - 0 <= strs[i].length <= 200
/// - strs[i] contains any possible characters out of 256 valid ascii characters.
/// </summary>
public class Codec
{
    // TODO: Implement Encode and Decode methods
    // Hint: Use length prefix with delimiter (e.g., "4#string")
    // Time Complexity: O(n) where n is total characters
    // Space Complexity: O(n)
    
    public string Encode(IList<string> strs)
    {
        return string.Empty;
    }
    
    public IList<string> Decode(string s)
    {
        return new List<string>();
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 1.7: Encode and Decode Strings ===");
        
        // Test Case 1: Basic example
        var codec = new Codec();
        string[] test1 = { "lint", "code", "love", "you" };
        string encoded1 = codec.Encode(test1);
        var decoded1 = codec.Decode(encoded1);
        Console.WriteLine($"Test 1 - Input: [\"lint\", \"code\", \"love\", \"you\"]");
        Console.WriteLine($"         Encoded: \"{encoded1}\"");
        Console.WriteLine($"         Decoded: [{string.Join(", ", decoded1.Select(s => $"\"{s}\""))}]");
        bool passed1 = decoded1.Count == test1.Length && 
                       decoded1[0] == test1[0] && decoded1[1] == test1[1];
        Console.WriteLine($"         {(passed1 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        // Test Case 2: Empty array
        string[] test2 = Array.Empty<string>();
        string encoded2 = codec.Encode(test2);
        var decoded2 = codec.Decode(encoded2);
        Console.WriteLine($"Test 2 - Input: []");
        Console.WriteLine($"         Decoded: [{string.Join(", ", decoded2)}]");
        bool passed2 = decoded2.Count == 0;
        Console.WriteLine($"         {(passed2 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

