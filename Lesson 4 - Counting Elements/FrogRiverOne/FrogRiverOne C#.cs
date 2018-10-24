using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

// By MichaelKosuke@github
// https://github.com/MichaelKosuke
// Correctness 100% Performance 40%
// Complexity O(N ** 2)

class Solution {
    public int solution(int X, int[] A) {
        int result = new Int32();
        int found = new Int32();
        for (int i=1; i<=X; i++) {
            
            found = Array.FindIndex(A, x=> x==i);
            if (found > result){
                result = found;
            }
            if (result == -1 || found == -1){
                result = found;
                break;
            }
        }
        return result;
    }
}