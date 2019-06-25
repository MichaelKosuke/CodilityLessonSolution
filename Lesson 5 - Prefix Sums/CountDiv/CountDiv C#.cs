using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

// By MichaelKosuke@github
// https://github.com/MichaelKosuke
// Correctness 100% Performance 100%
// Complexity O(1)

class Solution {
    public int solution(int A, int B, int K) {
        int res = 0;
        if (A == B)
        {
            if (A % K == 0)
            {
                res++;
            }
        } 
        else 
        {
            if (A % K == 0)
            {
                res = (B - A)/K + 1;
            }
            else
            {
                res = (B - A + (A%K)) / K;
            }
        }
        return res;
    }
}