using System;
using System.Collections.Generic;
using System.Linq;

namespace DSA._12_7_TaskScheduler_Medium;

/// <summary>
/// Problem 12.7 (Medium): Task Scheduler
/// You are given an array of CPU tasks, each represented by letters A to Z, and a cooling time n.
/// Each cycle or interval allows the completion of one task. Tasks can be completed in any order,
/// but there's a constraint: identical tasks must be separated by at least n intervals due to cooling time.
/// 
/// Return the minimum number of intervals required to complete all tasks.
/// 
/// Example:
/// Input: tasks = ["A","A","A","B","B","B"], n = 2
/// Output: 8
/// Explanation: A possible sequence is: A -> B -> idle -> A -> B -> idle -> A -> B.
/// 
/// Constraints:
/// - 1 <= tasks.length <= 10^4
/// - tasks[i] is upper-case English letter.
/// - 0 <= n <= 100
/// </summary>
public class TaskScheduler
{
    public static int LeastInterval(char[] tasks, int n)
    {
        // TODO: Implement solution
        // Hint: Use PriorityQueue to schedule most frequent tasks first
        // Track cooldown periods, use max heap for task frequencies
        // Time Complexity: O(n * m) where m is unique tasks
        // Space Complexity: O(1) - at most 26 tasks
        
        return 0;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 12.7: Task Scheduler ===");
        
        char[] test1 = { 'A', 'A', 'A', 'B', 'B', 'B' };
        int result1 = LeastInterval(test1, 2);
        Console.WriteLine($"Test 1 - Input: tasks = [\"A\",\"A\",\"A\",\"B\",\"B\",\"B\"], n = 2");
        Console.WriteLine($"         Output: {result1}, Expected: 8");
        Console.WriteLine($"         {(result1 == 8 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        char[] test2 = { 'A', 'A', 'A', 'A', 'A', 'A', 'B', 'C', 'D', 'E', 'F', 'G' };
        int result2 = LeastInterval(test2, 2);
        Console.WriteLine($"Test 2 - Input: tasks = [\"A\",\"A\",\"A\",\"A\",\"A\",\"A\",\"B\",\"C\",\"D\",\"E\",\"F\",\"G\"], n = 2");
        Console.WriteLine($"         Output: {result2}, Expected: 16");
        Console.WriteLine($"         {(result2 == 16 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

