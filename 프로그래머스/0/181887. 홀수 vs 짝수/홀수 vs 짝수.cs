using System;

public class Solution {
    public int solution(int[] num_list) {
        int answer = 0;
        int a = 0; //짝수
        int b = 0; //홀수
        for(int i = 0; i < num_list.Length; i++)
        {
          if(i % 2 == 0) //짝수번째
                a += num_list[i]; 
        } 
        for(int i = 0; i < num_list.Length; i++)
        {
          if(i % 2 != 0) //홀수번째
                b += num_list[i]; 
        }

        if(a > b)
            answer = a;
        else
            answer = b;
        return answer;
    }
}