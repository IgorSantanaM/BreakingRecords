# HackerRank Problem: Breaking the Records

## Problem Description

Maria plays college basketball and wants to go pro. Each season she maintains a record of her play. She tabulates the number of times she breaks her season record for most points and least points in a game. Points scored in the first game establish her record for the season, and she begins counting from there.

### Example

Scores are in the same order as the games played. She tabulates her results as follows:

| Game | Score | Minimum | Maximum | Min | Max |
|------|-------|---------|---------|-----|-----|
| 0    | 12    | 12      | 12      | 0   | 0   |
| 1    | 24    | 12      | 24      | 0   | 1   |
| 2    | 10    | 10      | 24      | 1   | 1   |
| 3    | 24    | 10      | 24      | 1   | 1   |

Given the scores for a season, determine the number of times Maria breaks her records for most and least points scored during the season.

### Function Description

Complete the `breakingRecords` function in the editor below.

`breakingRecords` has the following parameter(s):

- `int scores[n]`: points scored per game

### Returns

- `int[2]`: An array with the numbers of times she broke her records. Index 0 is for breaking most points records, and index 1 is for breaking least points records.

### Input Format

The first line contains an integer `n`, the number of games. The second line contains `n` space-separated integers describing the respective values of `scores`.

### Constraints

- `1 <= n <= 1000`
- `0 <= scores[i] <= 10^8`

### Sample Input 0

```shell
9
10 5 20 20 4 5 2 25 1
```
### Sample Output 0 
```shell
2 4
```
### Explanation 0

She broke her best record twice (after games 2 and 7) and her worst record four times (after games 1, 4, 6, and 8), so we print `2 4` as our answer. Note that she did not break her record for best score during game 3, as her score during that game was not strictly greater than her best record at the time.
### Code

```csharp
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
```
### How to Run
1. Ensure you have .NET Core installed on your machine.
2. Create a new console application and replace the contents of Program.cs with the code above.
3. Run the application and follow the prompts to input the number of games and the scores.
4. The program will output the number of times the records for most and least points were broken.

  
