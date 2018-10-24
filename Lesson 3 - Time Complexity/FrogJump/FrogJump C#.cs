using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

// By MichaelKosuke@github
// https://github.com/MichaelKosuke
// Correctness 100% Performance 100%

class Solution {
    public int solution(int X, int Y, int D) {
        int distance = (Y-X);
        if (distance == 0) {
            return 0;
        } else if (distance <= D){
            return 1;
        } else if ((distance)%D == 0) {
            return (distance-(distance%D))/D;
        } else {
            return (distance-(distance%D))/D+1;
        }
    }
}