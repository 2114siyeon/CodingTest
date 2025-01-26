using System;

public class Solution {
    public int solution(int a, int b) {
        int answer = 0;
        
        string a_Str = a.ToString();
        string b_Str = b.ToString();
        
        
        string combiAB = a_Str + b_Str; 
        
        int result1 = Int32.Parse(combiAB);
        int result2 = (2 * a * b);
        
        if(result1 > result2)
            answer = result1;
        else if(result1 == result2)
            answer = result1;
        else
            answer = result2;
        
        
        
        
        return answer;
    }
}