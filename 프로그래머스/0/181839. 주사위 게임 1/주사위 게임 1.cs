using System;

public class Solution {
    public int solution(int a, int b) {
        int answer = 0;
        
        if((a % 2) != 0 && (b % 2) != 0)
            answer = (a*a) + (b*b);
        
        if(((a % 2) != 0 && (b % 2) == 0) || ((a % 2) == 0 && (b % 2) != 0))
            answer = 2*(a+b);
        
        if((a % 2) == 0 && (b % 2) == 0 )
        {
            answer = (a-b);
            if(answer < 0)
            {
                answer = (answer * -1);
            }
        }
        return answer;
    }
}