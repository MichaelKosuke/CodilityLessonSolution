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
        int result = 0;
        string[] AinStr = A.Select(x=>x.ToString()).ToArray();
        string str = String.Join(",", AinStr);
        
        int noOfOne = str.Count(x => x == '1');
        for (int i=0; i<A.Length; i++){ // str length = 2 * A.Length - 1
            if (str.Substring(2*i, 1) == "0"){
                result += noOfOne;
            } else if (str.Substring(2*i, 1) == "1") {
                noOfOne--;
            }
            if (result > 1000000000){
                return -1;
            }
        }
        return result;
    }
}