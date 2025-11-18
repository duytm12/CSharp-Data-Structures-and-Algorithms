using System;
using System.Collections.Generic;
using System.Linq;

namespace DSA._17_4_ReconstructItinerary_Hard;

/// <summary>
/// Problem 17.4 (Hard): Reconstruct Itinerary
/// You are given a list of airline tickets where tickets[i] = [fromi, toi] represent the departure
/// and the arrival airports of one flight. Reconstruct the itinerary in order and return it.
/// 
/// All of the tickets belong to a man who departs from "JFK", thus, the itinerary must begin with "JFK".
/// If there are multiple valid itineraries, you should return the itinerary that has the smallest
/// lexical order when read as a single string.
/// 
/// Example:
/// Input: tickets = [["MUC","LHR"],["JFK","MUC"],["SFO","SJC"],["LHR","SFO"]]
/// Output: ["JFK","MUC","LHR","SFO","SJC"]
/// 
/// Constraints:
/// - 1 <= tickets.length <= 300
/// - tickets[i].length == 2
/// - fromi.length == 3
/// - toi.length == 3
/// - fromi and toi consist of uppercase English letters.
/// - fromi != toi
/// </summary>
public class ReconstructItinerary
{
    public static IList<string> FindItinerary(IList<IList<string>> tickets)
    {
        // TODO: Implement solution
        // Hint: Hierholzer's algorithm for Eulerian path, use DFS with backtracking
        // Sort destinations lexicographically, use post-order traversal
        // Time Complexity: O(E log E) where E is number of edges
        // Space Complexity: O(E)
        
        return new List<string>();
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 17.4: Reconstruct Itinerary ===");
        
        var tickets1 = new List<IList<string>>
        {
            new List<string> { "MUC", "LHR" },
            new List<string> { "JFK", "MUC" },
            new List<string> { "SFO", "SJC" },
            new List<string> { "LHR", "SFO" }
        };
        var result1 = FindItinerary(tickets1);
        Console.WriteLine($"Test 1 - Input: tickets = [[\"MUC\",\"LHR\"],[\"JFK\",\"MUC\"],[\"SFO\",\"SJC\"],[\"LHR\",\"SFO\"]]");
        Console.WriteLine($"         Output: [{string.Join(",", result1)}]");
        bool passed1 = result1.Count == 5 && result1[0] == "JFK";
        Console.WriteLine($"         {(passed1 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        var tickets2 = new List<IList<string>>
        {
            new List<string> { "JFK", "KUL" },
            new List<string> { "JFK", "NRT" },
            new List<string> { "NRT", "JFK" }
        };
        var result2 = FindItinerary(tickets2);
        Console.WriteLine($"Test 2 - Input: tickets = [[\"JFK\",\"KUL\"],[\"JFK\",\"NRT\"],[\"NRT\",\"JFK\"]]");
        Console.WriteLine($"         Output: [{string.Join(",", result2)}]");
        bool passed2 = result2.Count >= 4 && result2[0] == "JFK";
        Console.WriteLine($"         {(passed2 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

