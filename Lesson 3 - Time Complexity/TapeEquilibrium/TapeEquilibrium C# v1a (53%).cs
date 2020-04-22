using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

// By MichaelKosuke@github
// https://github.com/MichaelKosuke
// Correctness 100% Performance 0% (53%)
// Complexity O(N*N)

class Solution {
    public int solution(int[] A) {
        int diff = 0;
        int lastIndex = A.Length-1;
        for (int i=1; i<=lastIndex; i++){
            if (i==1){
                diff = findDiff(A, i);
            }
            int tempDiff = findDiff(A, i);
            // Console.WriteLine(i + " = " + tempDiff);
            if (diff > tempDiff){
                diff = tempDiff;
            }
            if (diff == 0){
                break;
            }
        }
        return diff;
    }
    
    public int findDiff(int[] A, int i){
        return Math.Abs(sumSubArray(A, 0, i) - sumSubArray(A, i, A.Length));
    }
    
    public int sumSubArray(int[] A, int start, int end){
        ArraySegment<int> segmentArray = new ArraySegment<int>( A, start, end-start );
        return segmentArray.ToArray().Sum();
        // int sum = 0;
        // for (int i=start; i<end; i++){
        //     sum += A[i]; 
        // }
        // return sum;
    }
}