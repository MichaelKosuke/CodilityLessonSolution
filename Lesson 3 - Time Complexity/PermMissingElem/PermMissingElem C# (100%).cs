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
        if (A.Length == 0){ //just incase
            return 1; // smallest integer
        } else if (A.Length == 1){
            return (3-A[0]); // either 1 or 2
        }
        for (int i = 0; i < A.Length-1; i++){
            if (A[i+1] - A[i] == 2){
                return A[i]+1;
            }
        }
        // if missing integer in head or tail of the array
        if (A[0] == 2){ // if start without 1
            return 1;
        } else { // must be the last integer missing
            // return A[A.Length-1] + 1;
            return A.Length + 1; // alt
        }
    }
}