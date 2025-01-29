using System;

public class Solution {
    public int solution(int[] num_list) {
        int answer = 0;
        int result1 = 0;
        int result2 = 1;
    
        for(int i = 0; i < num_list.Length; i++)
        {
            result1 += num_list[i];
        }
        result1 *= result1;
        
        for(int j = 0; j < num_list.Length; j++)
        {
            result2 *= num_list[j];
        }
        
        answer = (result1 > result2) ? 1 : 0;
        return answer;
    }
}