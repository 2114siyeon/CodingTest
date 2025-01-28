using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] num_list) {
        int answer = 0;
        String even_str = "";
        String odd_str = "";
        
        for(int i = 0; i < num_list.Length; i++)
        {
            if((num_list[i] % 2) == 0)//짝수
                even_str += num_list[i].ToString();
            else//홀수
                odd_str += num_list[i].ToString();
        }
        
        answer = Int32.Parse(even_str) + Int32.Parse(odd_str);
        
        
        return answer;
    }
}