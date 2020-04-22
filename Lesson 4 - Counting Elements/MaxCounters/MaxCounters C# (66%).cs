using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

// By MichaelKosuke@github
// https://github.com/MichaelKosuke
// Correctness 100% Performance 40% (66%)
// Complexity O(N*M)

class Solution {
    public int[] solution(int N, int[] A) {
        int[] result = new int[N];
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] <= N)
                {
                    increase(result, A[i]);
                }
                else if (A[i] == N + 1)
                {
                    max(result);
                }
                //Console.WriteLine(string.Join(",",result));
            }
            return result;
    }
    
    public static void increase(int[] arrIncrease, int key)
    {
        arrIncrease[key-1] += 1;
    }

    public static void max(int[] arrMax)
    {
        int max = arrMax.Max();
        //Console.WriteLine(max);
        for (int i = 0; i < arrMax.Length; i++)
        {
            arrMax[i] = max;
        }
    }
}