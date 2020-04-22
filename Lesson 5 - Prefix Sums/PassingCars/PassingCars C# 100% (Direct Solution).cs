using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

// By MichaelKosuke@github
// https://github.com/MichaelKosuke
// Correctness 100% Performance 100% (100%)
// Complexity O(N)

class Solution {
    public int solution(int[] A) {
        int result = 0;
        int noOfZero = 0;
        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] == 0)
                noOfZero++;
            else if (A[i] == 1)
                result += noOfZero;
            if (result > 1000000000){
                return -1;
            }
        }
        return result;
    }
}