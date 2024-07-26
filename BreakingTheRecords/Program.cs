using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Result
{
    public static List<int> breakingRecords(List<int> scores)
    {
        int minCount = 0;
        int maxCount = 0;
        int min = scores[0];
        int max = scores[0];

        foreach (int score in scores)
        {
            if (score > max)
            {
                max = score;
                maxCount++;
            }
            else if (score < min)
            {
                min = score;
                minCount++;
            }
        }

        return new List<int> { maxCount, minCount };
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of games:");
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        Console.WriteLine("Enter the scores separated by spaces:");
        List<int> scores = Console.ReadLine().TrimEnd().Split(' ').Select(int.Parse).ToList();

        List<int> result = Result.breakingRecords(scores);

        Console.WriteLine(String.Join(" ", result));
    }
}
