using System;
using System.Linq;
using System.Collections.Generic;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

// By MichaelKosuke@github
// https://github.com/MichaelKosuke
// Correctness 100% Performance 0%
// Complexity O(N*M)

class Solution {
    public int[] solution(string S, int[] P, int[] Q)
    {
        int length = P.Length;
        int[] minimalImpact = new int[length];
        S = S.Replace("A", "1,").Replace("C", "2,").Replace("G", "3,").Replace("T", "4,");
        if (S.EndsWith(","))
        {
            S = S.Substring(0, S.Length-1);
        }
        int[] arrayS = S.Split(',').Select(s => Convert.ToInt32(s)).ToArray();
        for (int i = 0; i < length; i++)
        {
            int[] newArrayS = arrayS.Skip(P[i]).Take(Q[i]-P[i]+1).ToArray();
            // Console.WriteLine("Skip " + (P[i]) + " Take " + (Q[i]-P[i]+1) + " " + newArrayS.Length);
            // foreach(int item in newArrayS)
            // {
            //     Console.WriteLine(item);
            // }
            minimalImpact[i] = newArrayS.Min();
        }
        return minimalImpact;
    }
}