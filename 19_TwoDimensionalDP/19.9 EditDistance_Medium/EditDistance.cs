using System;

namespace DSA._19_9_EditDistance_Medium;

/// <summary>
/// Problem 19.9 (Medium): Edit Distance
/// Given two strings word1 and word2, return the minimum number of operations required to
/// convert word1 to word2.
/// 
/// You have the following three operations permitted on a word:
/// - Insert a character
/// - Delete a character
/// - Replace a character
/// 
/// Example:
/// Input: word1 = "horse", word2 = "ros"
/// Output: 3
/// Explanation:
/// horse -> rorse (replace 'h' with 'r')
/// rorse -> rose (remove 'r')
/// rose -> ros (remove 'e')
/// 
/// Constraints:
/// - 0 <= word1.length, word2.length <= 500
/// - word1 and word2 consist of lowercase English letters.
/// </summary>
public class EditDistance
{
    public static int MinDistance(string word1, string word2)
    {
        // TODO: Implement solution
        // Hint: DP[i][j] = min operations to convert word1[0..i-1] to word2[0..j-1]
        // If word1[i-1] == word2[j-1]: DP[i][j] = DP[i-1][j-1]
        // Else: DP[i][j] = 1 + min(DP[i-1][j], DP[i][j-1], DP[i-1][j-1])
        // Time Complexity: O(m * n)
        // Space Complexity: O(m * n) or O(min(m,n)) optimized
        
        return 0;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 19.9: Edit Distance ===");
        
        int result1 = MinDistance("horse", "ros");
        Console.WriteLine($"Test 1 - Input: word1 = \"horse\", word2 = \"ros\"");
        Console.WriteLine($"         Output: {result1}, Expected: 3");
        Console.WriteLine($"         {(result1 == 3 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int result2 = MinDistance("intention", "execution");
        Console.WriteLine($"Test 2 - Input: word1 = \"intention\", word2 = \"execution\"");
        Console.WriteLine($"         Output: {result2}, Expected: 5");
        Console.WriteLine($"         {(result2 == 5 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

