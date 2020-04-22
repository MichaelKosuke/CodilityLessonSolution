using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

// By MichaelKosuke@github
// https://github.com/MichaelKosuke
// Correctness 100% (100%)
// Complexity -

class Solution {
    public int[] solution(int[] A, int K) {
        var length = A.Length;
        if (K == length)
            return A;
            
        var shiftTimes = K % length;
        int[] firstHalf = A.Skip(length - shiftTimes).Take(shiftTimes).ToArray();
        
        int[] secondHalf = A.Skip(0).Take(length - shiftTimes).ToArray();
        
        int[] result = firstHalf.Concat(secondHalf).ToArray();
        return result;
    }
}
