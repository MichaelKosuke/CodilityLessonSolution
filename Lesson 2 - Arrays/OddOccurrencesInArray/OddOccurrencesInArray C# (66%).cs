using System;
using System.Collections.Generic;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

// By MichaelKosuke@github
// https://github.com/MichaelKosuke
// Correctness 100% Performance 25% (66%)
// Complexity O(N ** 2))

class Solution {
    public int solution(int[] A) {
        if (A.Length <= 1)
            return A[0];
        
        Array.Sort(A);
        var distinct = A.Distinct().ToArray();
        
        for (int i = 0; i < distinct.Length; i++)
        {
            var val = A.Count(x => x == distinct[i]);
            if (val % 2 == 1)
            {
                return distinct[i];
            }
        }
        return A[0];
    }
}