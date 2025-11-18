using System;
using System.Collections.Generic;
using System.Linq;

namespace DSA._14_6_MinimumIntervalToIncludeQuery_Hard;

/// <summary>
/// Problem 14.6 (Hard): Minimum Interval to Include Each Query
/// You are given a 2D integer array intervals, where intervals[i] = [lefti, righti] describes
/// the ith interval starting at lefti and ending at righti (inclusive). The size of an interval
/// is defined as the number of integers it contains, or more formally righti - lefti + 1.
/// 
/// You are also given an integer array queries. The answer to the jth query is the size of the
/// smallest interval i such that lefti <= queries[j] <= righti. If no such interval exists, the answer is -1.
/// 
/// Return an array answer of size queries.length where answer[j] is the answer to the jth query.
/// 
/// Example:
/// Input: intervals = [[1,4],[2,4],[3,6],[4,4]], queries = [2,3,4,5]
/// Output: [3,3,1,4]
/// Explanation: The queries are processed as follows:
/// - Query = 2: The interval [2,4] is the smallest interval containing 2. The answer is 4 - 2 + 1 = 3.
/// - Query = 3: The interval [2,4] is the smallest interval containing 3. The answer is 4 - 2 + 1 = 3.
/// - Query = 4: The interval [4,4] is the smallest interval containing 4. The answer is 4 - 4 + 1 = 1.
/// - Query = 5: The interval [3,6] is the smallest interval containing 5. The answer is 6 - 3 + 1 = 4.
/// 
/// Constraints:
/// - 1 <= intervals.length <= 10^5
/// - 1 <= queries.length <= 10^5
/// - intervals[i].length == 2
/// - 1 <= lefti <= righti <= 10^7
/// - 1 <= queries[j] <= 10^7
/// </summary>
public class MinimumIntervalToIncludeQuery
{
    public static int[] MinInterval(int[][] intervals, int[] queries)
    {
        // TODO: Implement solution
        // Hint: Sort intervals and queries, use PriorityQueue to track active intervals
        // For each query, add intervals that start <= query, remove those that end < query
        // Time Complexity: O(n log n + q log q)
        // Space Complexity: O(n + q)
        
        return Array.Empty<int>();
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 14.6: Minimum Interval to Include Query ===");
        
        int[][] test1 = new int[][] { new int[] { 1, 4 }, new int[] { 2, 4 }, new int[] { 3, 6 }, new int[] { 4, 4 } };
        int[] queries1 = { 2, 3, 4, 5 };
        var result1 = MinInterval(test1, queries1);
        Console.WriteLine($"Test 1 - Input: intervals = [[1,4],[2,4],[3,6],[4,4]], queries = [2,3,4,5]");
        Console.WriteLine($"         Output: [{string.Join(",", result1)}], Expected: [3,3,1,4]");
        bool passed1 = result1.Length == 4 && result1[0] == 3 && result1[2] == 1;
        Console.WriteLine($"         {(passed1 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[][] test2 = new int[][] { new int[] { 2, 3 }, new int[] { 2, 5 }, new int[] { 1, 8 }, new int[] { 20, 25 } };
        int[] queries2 = { 2, 19, 5, 22 };
        var result2 = MinInterval(test2, queries2);
        Console.WriteLine($"Test 2 - Input: intervals = [[2,3],[2,5],[1,8],[20,25]], queries = [2,19,5,22]");
        Console.WriteLine($"         Output: [{string.Join(",", result2)}]");
        bool passed2 = result2.Length == 4;
        Console.WriteLine($"         {(passed2 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

