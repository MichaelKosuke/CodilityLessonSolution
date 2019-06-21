using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

// By MichaelKosuke@github
// https://github.com/MichaelKosuke
// Correctness 100% "The solution obtained perfect score"
// Complexity -

class Solution {
    public int solution(int N) {
        var converted = Convert.ToString(N, 2);
        int longestGap = 0;
        int tempGap = 0;
        for (int i = 0; i < converted.Length; i++)
        {
            if (converted.Substring(i, 1) == "1")
            {
                longestGap = longestGap >= tempGap ? longestGap : tempGap;
                tempGap = 0;
            }
            else if (converted.Substring(i, 1) == "0")
            {
                tempGap++;   
            }
        }
        return longestGap;
    }
}