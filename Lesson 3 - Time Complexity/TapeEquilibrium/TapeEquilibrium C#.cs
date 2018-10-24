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
    public int solution(int[] A) {
        int front = A[0];
        int back = A.Sum()-front;
        int smallestDiff = Math.Abs(front - back);
        
        for (int i=1; i<A.Length-1; i++)
        {
            front += A[i];
            back -= A[i];
            int newDiff = Math.Abs(front-back);
            if (newDiff < smallestDiff){
                smallestDiff = newDiff;
            }
            if (smallestDiff == 0){
                break;
            }
        }
        return smallestDiff;
    }
}