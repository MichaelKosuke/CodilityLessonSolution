using System;
using System.Linq;
using System.Collections.Generic;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

// By MichaelKosuke@github
// https://github.com/MichaelKosuke
// Correctness 100% Performance 0%
// Complexity O(N**3)

class Solution {
    public int solution(int[] A) {
        decimal tempAvg = A[0];
        int index = 0;
        for (int i = 0; i < A.Length-1; i++)
        {
            for (int j = i+1; j <= A.Length; j++)
            {
                Console.WriteLine("skip " + i + " take " + (j-i+1) + " length " + A.Skip(i).Take(j-i+1).ToArray().Length);
                decimal newAvg = Avg(A.Skip(i).Take(j-i+1).ToArray());
                
                Console.WriteLine(tempAvg + " " + newAvg);
                if ((i == 0 && j == 1) || tempAvg > newAvg)
                {
                    tempAvg = newAvg;
                    index = i;
                }
            }
        }
        return index;
    }
    
    public decimal Avg(int[] B)
    {
        return Math.Round((decimal)B.Sum()/(decimal)B.Length, 10);   
    }
}