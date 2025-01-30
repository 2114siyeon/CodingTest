using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] num_list) {
        int[] answer = new int[] {};
         List<int> result = new List<int>(num_list);
        
        int last = num_list[num_list.Length-1];
        int second = num_list[num_list.Length-2];
        
        if(last > second)
            result.Add(last-second);
        else
            result.Add(last*2);
        
        answer = result.ToArray();
        
        return answer;
    }
}