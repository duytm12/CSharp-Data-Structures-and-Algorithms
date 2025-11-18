# Data Structures & Algorithms - C# Practice

A comprehensive C# project structure for learning Data Structures and Algorithms, organized by topic with problems ranging from easy to hard.

## Project Structure

Each problem has its own folder following the format: `X.Y ProblemName_Difficulty`

```
DSA/
├── 01_ArraysAndHashing/              (9 problems)
│   ├── 1.1 ContainsDuplicate_Easy/
│   ├── 1.2 TwoSum_Easy/
│   ├── 1.3 ProductExceptSelf_Medium/
│   └── ... (6 more problems)
├── 02_CSharpCollections/              (9 problems)
│   ├── 2.1 FindMax_Easy/
│   ├── 2.2 CharacterFrequency_Medium/
│   └── ... (7 more problems)
├── 03_TwoPointers/                    (5 problems)
├── 04_StringManipulation/             (3 problems)
├── 05_BinarySearch/                    (7 problems)
├── 06_SlidingWindow/                   (5 problems)
├── 07_Stack/                           (6 problems)
├── 08_LinkedList/                      (10 problems)
├── 09_Recursion/                       (3 problems)
├── 10_Trees/                           (15 problems)
├── 11_Tries/                           (4 problems)
├── 12_HeapPriorityQueue/              (9 problems)
├── 13_Backtracking/                    (10 problems)
├── 14_Intervals/                       (6 problems)
├── 15_Greedy/                          (9 problems)
├── 16_Graphs/                           (13 problems)
├── 17_AdvancedGraphs/                  (8 problems)
├── 18_OneDimensionalDP/                (12 problems)
├── 19_TwoDimensionalDP/                (11 problems)
├── 20_BitManipulation/                 (7 problems)
├── 21_MathAndGeometry/                 (8 problems)
├── Program.cs                          (Main entry point)
├── DSA.csproj                          (Project file)
├── DSA.sln                             (Solution file)
├── DSA_Roadmap.md                      (Learning roadmap)
├── TESTING_GUIDE.md                    (How to test your solutions)
├── roadmap_visual.html                  (Interactive roadmap visualization)
└── README.md                           (This file)
```

## Problem Organization

- **Total: 169 problems** across 21 topics
- Each problem is in its own folder: `X.Y ProblemName_Difficulty`
- Each problem file contains:
  - Problem description with examples
  - Constraints
  - Solution method stub with TODO
  - Hints and complexity notes
  - `Test()` method with 2 test cases (ready to use!)

### Problem Count by Topic

| Topic | Problems | Topic | Problems |
|-------|----------|-------|----------|
| 01. Arrays & Hashing | 9 | 12. Heap / Priority Queue | 9 |
| 02. C# Collections | 9 | 13. Backtracking | 10 |
| 03. Two Pointers | 5 | 14. Intervals | 6 |
| 04. String Manipulation | 3 | 15. Greedy | 9 |
| 05. Binary Search | 7 | 16. Graphs | 13 |
| 06. Sliding Window | 5 | 17. Advanced Graphs | 8 |
| 07. Stack | 6 | 18. 1-D Dynamic Programming | 12 |
| 08. Linked List | 10 | 19. 2-D Dynamic Programming | 11 |
| 09. Recursion | 3 | 20. Bit Manipulation | 7 |
| 10. Trees | 15 | 21. Math & Geometry | 8 |
| 11. Tries | 4 | **Total** | **169** |

## Getting Started

### Prerequisites

- .NET 10.0 SDK or later
- Visual Studio 2022, VS Code, or any C# IDE

### Running the Project

1. **Restore dependencies:**
   ```bash
   dotnet restore
   ```

2. **Build the project:**
   ```bash
   dotnet build
   ```

3. **Run the program:**
   ```bash
   dotnet run
   ```

### How to Practice

1. **Open a problem folder** (e.g., `01_ArraysAndHashing/1.1 ContainsDuplicate_Easy/`)
2. **Open the problem file** (e.g., `ContainsDuplicate.cs`)
3. **Read the problem description** in the XML comments
4. **Implement the solution** in the `Solution` method (replace TODO)
5. **Test your solution** by uncommenting the test in `Program.cs`:
   ```csharp
   using DSA._1_1_ContainsDuplicate_Easy;
   ContainsDuplicate.Test();
   ```
6. **Run** `dotnet run` to see test results with pass/fail indicators

**Note:** All 169 problems already have `Test()` methods with 2 test cases each. See `TESTING_GUIDE.md` for more details.

## Learning Path

Follow the roadmap in `DSA_Roadmap.md` to learn topics in the recommended order:

1. Arrays & Hashing
2. C# Collections
3. Two Pointers
4. String Manipulation
5. Binary Search
6. Sliding Window
7. Stack
8. Linked List
9. Recursion
10. Trees
11. Tries
12. Heap / Priority Queue
13. Backtracking
14. Intervals
15. Greedy
16. Graphs
17. Advanced Graphs
18. 1-D Dynamic Programming
19. 2-D Dynamic Programming
20. Bit Manipulation
21. Math & Geometry

## Tips

- **Start with Easy problems** (X.1) to understand the concept
- **Move to Medium** (X.2) to master the pattern
- **Challenge yourself with Hard** (X.3) to see advanced applications
- **Test edge cases**: empty inputs, single elements, duplicates, null values
- **Analyze time/space complexity** for each solution
- **Review solutions** after a few days to reinforce learning

## Resources

- See `DSA_Roadmap.md` for detailed learning guide and resources
- Practice on LeetCode, HackerRank, or CodeSignal
- Refer to Microsoft Docs for C# collections and language features

## Happy Coding! 🚀

