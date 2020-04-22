using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

// By MichaelKosuke@github
// https://github.com/MichaelKosuke
// Correctness 100% Performance 0%
// Complexity O(N**3)

class Solution {
    public int solution(int[] A) {
        int result = 0;
        int len = A.Length;
        decimal[] tempResult = new decimal[len-1];
        for(int i = 0; i < len; i++)
        {
            if (i + 2 <= len)
            {
                decimal[] tempMinAvg = new decimal[len-1-i];
                for(int j = 2; j <= len - i; j++)
                {
                    decimal avgBefore = ((j-3 > -1) ? tempMinAvg[j-3] * (j-1) : A[i+j-2]);
                    tempMinAvg[j-2] = Math.Round((avgBefore + A[i+j-1])/j, 2);
                    //Console.WriteLine($"({avgBefore}) + {A[i+j-1]})/{j} = {tempMinAvg[j-2]}");
                }
                tempResult[i] = tempMinAvg.Min();
                //foreach(decimal item in tempMinAvg)
                //{
                //    Console.WriteLine($"item {item}");
                //}
                //Console.WriteLine($"{i} {tempResult[i]}");
            }
        }
        return Array.IndexOf(tempResult, tempResult.Min());
    }
}