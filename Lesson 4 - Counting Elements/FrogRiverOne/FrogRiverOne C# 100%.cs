using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

// By MichaelKosuke@github
// https://github.com/MichaelKosuke
// Correctness 100% Performance 100%
// Complexity O(N)

class Solution {
    public int solution(int X, int[] A) {
        int n = A.Length;
        int[] result = new int[X + 1];
        int maxi = 0; 
        for (int i = 0; i < n; i++)
        {
            result[A[i]] += 1;
            if (result[A[i]] == 1)
            {
                maxi += 1;
            }
            if (maxi == X)
            {
                return i;
            }
        }
        return -1;
    }
}