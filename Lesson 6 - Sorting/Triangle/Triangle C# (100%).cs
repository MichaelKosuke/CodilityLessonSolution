using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

// By MichaelKosuke@github
// https://github.com/MichaelKosuke
// Correctness 100% Performance 100% (100%)
// Complexity O(N*log(N))

class Solution {
    public int solution(int[] A) {
        Array.Sort(A);
        int len = A.Length;
        //Console.WriteLine(len);
        for (int i = 0; i <=len-1-2; i++)
        {
            if (A[i] < 0)
            {
                continue;   
            }
            for (int j = 0; j <= len-1-2-i; j++)
            {
                //Console.WriteLine(i + " " + (i+1) + " " + (len-1-j));
                if ((long)A[i] + (long)A[i+1] > (long)A[len-1-j] && A[i+1] <= A[len-1-j])
                {
                   return 1;
                }
            }
        }
        return 0;
    }
}