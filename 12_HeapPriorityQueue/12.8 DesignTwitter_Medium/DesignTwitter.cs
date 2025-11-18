using System;
using System.Collections.Generic;
using System.Linq;

namespace DSA._12_8_DesignTwitter_Medium;

/// <summary>
/// Problem 12.8 (Medium): Design Twitter
/// Design a simplified version of Twitter where users can post tweets, follow/unfollow another user,
/// and is able to see the 10 most recent tweets in the user's news feed.
/// 
/// Implement the Twitter class:
/// - Twitter() Initializes your twitter object.
/// - void PostTweet(int userId, int tweetId) Composes a new tweet with ID tweetId by the user userId.
/// - List&lt;int&gt; GetNewsFeed(int userId) Retrieves the 10 most recent tweet IDs in the user's news feed.
/// - void Follow(int followerId, int followeeId) The user with ID followerId started following the user with ID followeeId.
/// - void Unfollow(int followerId, int followeeId) The user with ID followerId started unfollowing the user with ID followeeId.
/// 
/// Example:
/// Twitter twitter = new Twitter();
/// twitter.PostTweet(1, 5); // User 1 posts a new tweet (id = 5).
/// twitter.GetNewsFeed(1);  // User 1's news feed should return a list with 1 tweet id -> [5]. return [5]
/// twitter.Follow(1, 2);    // User 1 follows user 2.
/// twitter.PostTweet(2, 6); // User 2 posts a new tweet (id = 6).
/// twitter.GetNewsFeed(1);  // User 1's news feed should return a list with 2 tweet ids -> [6, 5]. Tweet id 6 should precede tweet id 5 because it is posted after tweet id 5.
/// twitter.Unfollow(1, 2);  // User 1 unfollows user 2.
/// twitter.GetNewsFeed(1);  // User 1's news feed should return a list with 1 tweet id -> [5], since user 1 is no longer following user 2.
/// 
/// Constraints:
/// - 1 <= userId, followerId, followeeId <= 500
/// - 0 <= tweetId <= 10^4
/// - All the tweets have unique IDs.
/// - At most 3 * 10^4 calls will be made to postTweet, getNewsFeed, follow, and unfollow.
/// </summary>
public class Twitter
{
    // TODO: Implement Twitter using Dictionary and PriorityQueue
    // Hint: Store tweets with timestamps, use PriorityQueue to merge feeds from followed users
    // Time Complexity: O(k log n) for GetNewsFeed where k=10, n is number of users
    // Space Complexity: O(n + m) where n is users, m is tweets
    
    public Twitter()
    {
        // Initialize your data structure here
    }
    
    public void PostTweet(int userId, int tweetId)
    {
        // TODO: Implement post tweet
    }
    
    public IList<int> GetNewsFeed(int userId)
    {
        // TODO: Implement get news feed - merge tweets from user and followed users
        return new List<int>();
    }
    
    public void Follow(int followerId, int followeeId)
    {
        // TODO: Implement follow
    }
    
    public void Unfollow(int followerId, int followeeId)
    {
        // TODO: Implement unfollow
    }
    
    public static void Test()
    {
        Console.WriteLine("\n=== Testing Problem 12.8: Design Twitter ===");
        
        var twitter = new Twitter();
        twitter.PostTweet(1, 5);
        var feed1 = twitter.GetNewsFeed(1);
        Console.WriteLine($"Test 1 - PostTweet(1,5), GetNewsFeed(1) = [{string.Join(",", feed1)}]");
        Console.WriteLine($"         Expected: [5]");
        bool passed1 = feed1.Count == 1 && feed1[0] == 5;
        Console.WriteLine($"         {(passed1 ? "✓ PASSED" : "✗ FAILED")}\n");
        
        twitter.Follow(1, 2);
        twitter.PostTweet(2, 6);
        var feed2 = twitter.GetNewsFeed(1);
        Console.WriteLine($"Test 2 - Follow(1,2), PostTweet(2,6), GetNewsFeed(1) = [{string.Join(",", feed2)}]");
        Console.WriteLine($"         Expected: [6,5]");
        bool passed2 = feed2.Count == 2 && feed2[0] == 6 && feed2[1] == 5;
        Console.WriteLine($"         {(passed2 ? "✓ PASSED" : "✗ FAILED")}\n");
    }
}

