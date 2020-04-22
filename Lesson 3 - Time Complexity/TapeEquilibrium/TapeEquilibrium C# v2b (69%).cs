using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

// By MichaelKosuke@github
// https://github.com/MichaelKosuke
// Correctness 85% Performance 50% (69%)
// Complexity (timeout errors)

class Solution {
    public int solution(int[] A) {
        int frontIndex = 0;
        int backIndex = A.Length-1;
        int frontSum = A[frontIndex];
        //Console.WriteLine(backIndex);
        int backSum = A[backIndex];
        
        while(backIndex - 1 != frontIndex){
            if (frontSum < backSum){
                if (A[frontIndex+1] >= 0){
                    frontIndex++;
                    frontSum += A[frontIndex];
                } else if (A[backIndex-1] <= 0) {
                    backIndex--;
                    backSum += A[backIndex];
                }
            } else if (frontSum > backSum){
                if (A[backIndex-1] >= 0) {
                    backIndex--;
                    backSum += A[backIndex];
                } else if (A[frontIndex+1] <= 0){
                    frontIndex++;
                    frontSum += A[frontIndex];
                } 
            } else if (frontSum == backSum) {
                if (frontIndex+1 == backIndex-1){
                    frontIndex++;
                    frontSum += A[frontIndex];
                } else {
                    frontIndex++;
                    frontSum += A[frontIndex];
                    backIndex--;
                    backSum += A[backIndex];
                }
            }
            //Console.WriteLine("indexs =" + frontIndex + " " + backIndex);
            //Console.WriteLine("value = " + frontSum + " " + backSum);
        }
        return Math.Abs(frontSum - backSum);
    }
}