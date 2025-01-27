using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        
        if((n % 2) != 0) //홀수
        {
            for(int i = 1; i <= n; i++)
            {
                if((i % 2) != 0 )
                    answer += i;
            }
        }        
                
        if((n % 2) == 0) //짝수
        {
            for(int i = 1; i <= n; i++)
            {
                if((i % 2) == 0 )
                    answer += (i*i);
            }
        }
        
        return answer;
    }
}