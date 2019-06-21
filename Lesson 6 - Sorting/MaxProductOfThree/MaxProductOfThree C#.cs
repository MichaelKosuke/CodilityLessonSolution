using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

// By MichaelKosuke@github
// https://github.com/MichaelKosuke
// Correctness 100% Performance 100%
// Complexity O(N * log(N))

class Solution {
    public int solution(int[] A) {
        Array.Sort(A);
        int result = 0;
        result = A[0] * A[1] * A[A.Length-1] > A[A.Length-1] * A[A.Length-2] * A[A.Length-3] ? A[0] * A[1] * A[A.Length-1] : A[A.Length-1] * A[A.Length-2] * A[A.Length-3];
        return result;
    }
}