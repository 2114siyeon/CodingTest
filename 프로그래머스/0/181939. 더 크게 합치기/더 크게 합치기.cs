using System;

public class Solution {
    public int solution(int a, int b) {
        int answer = 0;
        string a_Str = a.ToString();
        string b_Str = b.ToString();
        
        string combinedAB = a_Str + b_Str;
        string combinedBA = b_Str + a_Str;
        
        int resultA = Int32.Parse(combinedAB);
        int resultB = Int32.Parse(combinedBA);
        
        if(resultA > resultB)
            answer = resultA; 
        else
            answer = resultB;
            
        return answer;
    }
}