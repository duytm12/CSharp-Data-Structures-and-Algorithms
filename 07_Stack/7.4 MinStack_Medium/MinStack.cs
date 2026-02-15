using System;
using System.Collections.Generic;

namespace DSA._7_4_MinStack_Medium;

/// <summary>
/// Problem 7.4 (Medium): Min Stack
/// Design a stack that supports push, pop, top, and retrieving the minimum element in constant time.
/// 
/// Implement the MinStack class:
/// - MinStack() initializes the stack object.
/// - void Push(int val) pushes the element val onto the stack.
/// - void Pop() removes the element on the top of the stack.
/// - int Top() gets the top element of the stack.
/// - int GetMin() retrieves the minimum element in the stack.
/// 
/// Example:
/// MinStack minStack = new MinStack();
/// minStack.Push(-2);
/// minStack.Push(0);
/// minStack.Push(-3);
/// minStack.GetMin(); // return -3
/// minStack.Pop();
/// minStack.Top();    // return 0
/// minStack.GetMin(); // return -2
/// 
/// Constraints:
/// - -2^31 <= val <= 2^31 - 1
/// - Methods pop, top and getMin operations will always be called on non-empty stacks.
/// - At most 3 * 10^4 calls will be made to push, pop, top, and getMin.
/// </summary>
public class MinStack
{
    // TODO: Implement MinStack
    // Hint: Use two stacks - one for values, one for minimums, OR use a single stack with pairs
    // Time Complexity: O(1) for all operations
    // Space Complexity: O(n)

    public MinStack()
    {
        // Initialize your data structure here
    
    }
    
    public void Push(int val)
    {
        // TODO: Implement push
    }
    
    public void Pop()
    {
        // TODO: Implement pop
    }
    
    public int Top()
    {
        // TODO: Implement top
        return 0;
    }
    
    public int GetMin()
    {
        // TODO: Implement getMin
        return 0;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 7.4: Min Stack ===");
        
        var minStack = new MinStack();
        minStack.Push(-2);
        minStack.Push(0);
        minStack.Push(-3);
        int result1 = minStack.GetMin();
        Console.WriteLine($"Test 1 - Push(-2), Push(0), Push(-3), GetMin()");
        Console.WriteLine($"         Output: {result1}, Expected: -3");
        Console.WriteLine($"         {(result1 == -3 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        minStack.Pop();
        int result2 = minStack.Top();
        int result3 = minStack.GetMin();
        Console.WriteLine($"Test 2 - Pop(), Top(), GetMin()");
        Console.WriteLine($"         Output: Top()={result2}, GetMin()={result3}, Expected: 0, -2");
        Console.WriteLine($"         {(result2 == 0 && result3 == -2 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

