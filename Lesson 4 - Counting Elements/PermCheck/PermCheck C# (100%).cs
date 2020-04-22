using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

// By MichaelKosuke@github
// https://github.com/MichaelKosuke
// Correctness 100% Performance 100% (100%)
// Complexity O(N) or O(N * log(N))

class Solution {
    public int solution(int[] A) {
        Array.Sort(A);
        
        for (int i=0; i<A.Length; i++){
            if (A[i] != i+1){
                return 0;
            }
        }
        return 1;
    }
}