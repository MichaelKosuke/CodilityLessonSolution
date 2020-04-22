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
        int frontIndex = 0;
        int backIndex = 0;
        int frontSum = 0;
        int backSum = 0;
        int[] Array;
    public int solution(int[] A) {
        frontIndex = 0;
        backIndex = A.Length-1;
        frontSum = A[frontIndex];
        //Console.WriteLine(backIndex);
        backSum = A[backIndex];
        Array = A;
        
        while(backIndex - 1 != frontIndex){
            if (frontSum < backSum){
                if (A[frontIndex+1] >= 0){
                    addFront();
                } else if (A[backIndex-1] <= 0) {
                    addBack();
                }
            } else if (frontSum > backSum){
            // } else {
                if (A[backIndex-1] >= 0) {
                    addBack();
                } else if (A[frontIndex+1] <= 0){
                    addFront();
                } 
            } else if (frontSum == backSum) {
                if (frontIndex+1 == backIndex-1){
                    addFront();
                } else {
                    addFront();
                    addBack();
                }
            }
            //Console.WriteLine("indexs =" + frontIndex + " " + backIndex);
            //Console.WriteLine("value = " + frontSum + " " + backSum);
        }
        return Math.Abs(frontSum - backSum);
    }
    
    public void addFront(){
        frontIndex++;
        frontSum += Array[frontIndex];
    }
    
    public void addBack(){
        backIndex--;
        backSum += Array[backIndex];
    }
}