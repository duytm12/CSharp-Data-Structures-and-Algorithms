# Testing Guide for DSA Problems

**All 169 problems already have `Test()` methods!** 🎉

This guide shows you how to test your solutions quickly and easily.

## Quick Start 🚀

**All problems are ready to test!** Each problem file already contains a `Test()` method with 2 test cases.

### To Test a Problem:

1. **Open `Program.cs`**
2. **Find the problem** you want to test (organized by topic)
3. **Uncomment** the two lines:
   ```csharp
   using DSA._1_1_ContainsDuplicate_Easy;
   ContainsDuplicate.Test();
   ```
4. **Run:** `dotnet run`

That's it! You'll see the test results in the console.

---

## How It Works

### Every Problem Has a `Test()` Method

Each of the 169 problems already includes a `Test()` method with:
- ✅ 2 test cases with expected outputs
- ✅ Clear console output showing results
- ✅ Pass/fail indicators (✓ PASSED / ✗ FAILED)

### Example Test Output

```
=== Testing Problem 1.1: Contains Duplicate ===
Test 1 - Input: [1, 2, 3, 1]
         Output: True, Expected: True
         ✓ PASSED

Test 2 - Input: [1, 2, 3, 4]
         Output: False, Expected: False
         ✓ PASSED
```

---

## Using Program.cs

`Program.cs` contains **all 169 problems** organized by topic:

```csharp
// ============================================
// 01. Arrays & Hashing (9 problems)
// ============================================
// using DSA._1_1_ContainsDuplicate_Easy;
// ContainsDuplicate.Test();

// using DSA._1_2_TwoSum_Easy;
// TwoSum.Test();
// ... etc
```

### Workflow:

1. **Find your problem** in `Program.cs` (organized by topic number)
2. **Uncomment** the `using` statement and `Test()` call
3. **Run** `dotnet run`
4. **See results** in the console

### Testing Multiple Problems:

You can uncomment multiple problems to test them all at once:

```csharp
using DSA._1_1_ContainsDuplicate_Easy;
ContainsDuplicate.Test();

using DSA._1_2_TwoSum_Easy;
TwoSum.Test();
```

---

## Problem Organization in Program.cs

All 169 problems are organized by topic:

- **01. Arrays & Hashing** (9 problems)
- **02. C# Collections** (9 problems)
- **03. Two Pointers** (5 problems)
- **04. String Manipulation** (3 problems)
- **05. Binary Search** (7 problems)
- **06. Sliding Window** (5 problems)
- **07. Stack** (6 problems)
- **08. Linked List** (10 problems)
- **09. Recursion** (3 problems)
- **10. Trees** (15 problems)
- **11. Tries** (4 problems)
- **12. Heap / Priority Queue** (9 problems)
- **13. Backtracking** (10 problems)
- **14. Intervals** (6 problems)
- **15. Greedy** (9 problems)
- **16. Graphs** (13 problems)
- **17. Advanced Graphs** (8 problems)
- **18. 1-D Dynamic Programming** (12 problems)
- **19. 2-D Dynamic Programming** (11 problems)
- **20. Bit Manipulation** (7 problems)
- **21. Math & Geometry** (8 problems)

---

## Tips

- ✅ **Test one problem at a time** while learning
- ✅ **Comment out** problems you're not working on to reduce output
- ✅ **All test methods** are already in the problem files - no need to write them
- ✅ **Each test** includes 2 test cases - enough to verify basic correctness
- ✅ **Add more test cases** to the `Test()` method if you want more coverage

---

## Advanced: Unit Tests (Optional)

xUnit is installed in the project if you want to create proper unit tests later. However, the `Test()` methods in each problem file are perfect for learning and practice!

## Quick Commands

```bash
# Run the program and see test results
dotnet run

# Build only (check for compilation errors)
dotnet build

# Run unit tests (if you create xUnit tests later)
dotnet test
```

---

**Remember:** The goal is to **learn and practice**! All problems are ready to test - just uncomment in `Program.cs` and run! 🚀

