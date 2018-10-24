using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

// By MichaelKosuke@github
// https://github.com/MichaelKosuke
// Correctness 100% Performance 100%

class Solution {
    public int solution(int[] A, int start = 0) {
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