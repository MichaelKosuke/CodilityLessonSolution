using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

// By MichaelKosuke@github
// https://github.com/MichaelKosuke
// Correctness 100% Performance 0%
// Complexity O(N ** 2)

class Solution {
    public int solution(int[] A) {
        int result = 0;
        for (int i=0; i<A.Length; i++){
            int tempCount = 0;
            for (int j=i+1; j<A.Length; j++){
                if (A[j] > A[i]){
                    tempCount++;
                }
                // Console.WriteLine(A[i] + " " + A[j] + " " + tempCount + " " + result);
            }
            result += tempCount;
            if (result > 1000000000){
                return -1;
            }
        }
        return result;
    }
}