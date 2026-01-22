using System;

namespace DSA._15_10_LemonadeChange_Easy;

/// <summary>
/// Problem 15.10 (Easy): 860. Lemonade Change
/// At a lemonade stand, each lemonade costs $5.
/// Customers are standing in a queue to buy from you and order one at a time (in the order specified by bills).
/// Each customer will only buy one lemonade and pay with either a $5, $10, or $20 bill.
/// You must provide the correct change to each customer so that the net transaction is that the customer pays $5.
/// Note that you do not have any change in hand at first.
/// Given an integer array bills where bills[i] is the bill the ith customer pays, 
/// return true if you can provide every customer with the correct change, or false otherwise.
/// 
/// Example 1:
/// Input: bills = [5,5,5,10,20]
/// Output: true
/// Explanation: 
/// - From the first 3 customers, we collect three $5 bills in order.
/// - From the fourth customer, we collect a $10 bill and give back a $5.
/// - From the fifth customer, we collect a $20 bill and give back a $10 and a $5.
/// - Since all customers got correct change, we output true.
/// 
/// Example 2:
/// Input: bills = [5,5,10,10,20]
/// Output: false
/// Explanation: 
/// - From the first two customers in order, we collect two $5 bills.
/// - For the next two customers, we collect a $10 bill and give back a $5 to each.
/// - For the last customer, we cannot give the change of $15 back because we only have two $10 bills.
/// - Since not every customer received correct change, the answer is false.
/// 
/// Constraints:
/// 1 <= bills.length <= 10^5
/// bills[i] is either 5, 10, or 20.
/// </summary>
public class LemonadeChange
{
    public static bool Solution(int[] bills)
    {
        // Greedy approach: Track count of $5 and $10 bills
        // For $5: just collect it
        // For $10: need to give back one $5
        // For $20: prefer $10+$5 over three $5s (greedy choice to preserve $5s for $10 change)
        //          Only use three $5s if $10+$5 is not available

        int count5 = 0;
        int count10 = 0;

        foreach (var b in bills)
        {
            switch (b)
            {
                case 5:
                    count5++;
                    break;

                case 10:
                    if (count5 <= 0) return false;
                    count5--;
                    count10++;
                    break;

                case 20:
                    // Greedy
                    if (count10 > 0 && count5 > 0)
                    {
                        count10--;
                        count5--;
                    }
                    // if we run out of 10s, we'll use 3-5s
                    else if (count5 >= 3)
                    {
                        count5 -= 3;
                    }
                    else
                        return false;
                    break;
            }
        }
    
        return true;
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 15.10: 860. Lemonade Change ===");
        
        int[] test1 = { 5, 5, 5, 10, 20 };
        bool result1 = Solution(test1);
        Console.WriteLine($"Test 1 - Input: [5,5,5,10,20]");
        Console.WriteLine($"         Output: {result1}, Expected: true");
        Console.WriteLine($"         {(result1 == true ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[] test2 = { 5, 5, 10, 10, 20 };
        bool result2 = Solution(test2);
        Console.WriteLine($"Test 2 - Input: [5,5,10,10,20]");
        Console.WriteLine($"         Output: {result2}, Expected: false");
        Console.WriteLine($"         {(result2 == false ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[] test3 = { 5, 5, 5, 5, 10, 20 };
        bool result3 = Solution(test3);
        Console.WriteLine($"Test 3 - Input: [5,5,5,5,10,20]");
        Console.WriteLine($"         Output: {result3}, Expected: true");
        Console.WriteLine($"         {(result3 == true ? "✓ PASSED" : "✗ FAILED")}\n");
        
        int[] test4 = { 10, 10 };
        bool result4 = Solution(test4);
        Console.WriteLine($"Test 4 - Input: [10,10]");
        Console.WriteLine($"         Output: {result4}, Expected: false");
        Console.WriteLine($"         {(result4 == false ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}
