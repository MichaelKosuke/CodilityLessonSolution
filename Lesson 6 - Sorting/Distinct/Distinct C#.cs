using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

// By MichaelKosuke@github
// https://github.com/MichaelKosuke
// Correctness 100% Performance 100%
// Complexity O(N*log(N)) or O(N)

class Solution {
    public int solution(int[] A) 
    {
        int distinctNumber = 0;
        if (A.Length > 0)
        {
            Array.Sort(A);
            distinctNumber++;
            for (int i=1; i<A.Length; i++)
            {
                if (A[i] != A[i-1])
                    distinctNumber++;
            }
        }
		return distinctNumber;
    }
}