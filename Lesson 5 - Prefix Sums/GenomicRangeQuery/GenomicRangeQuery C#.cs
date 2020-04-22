using System;
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
        int[] minimalImpact = new int[P.Length];
        for (int i = 0; i < P.Length; i++
)        {
            string subs = S.Substring(P[i], Q[i]-P[i]+1);
            if (subs.Contains(DnaValue.A.ToString()))
            {
                minimalImpact[i] = (int)DnaValue.A;
            } else if (subs.Contains(DnaValue.C.ToString()))
            {
                minimalImpact[i] = (int)DnaValue.C;
            } else if (subs.Contains(DnaValue.G.ToString()))
            {
                minimalImpact[i] = (int)DnaValue.G;
            } else if (subs.Contains(DnaValue.T.ToString()))
            {
                minimalImpact[i] = (int)DnaValue.T;
            }
        }
        return minimalImpact;
    }
    
    public enum DnaValue{
        A = 1,
        C = 2,
        G = 3, 
        T = 4,
    } 
}