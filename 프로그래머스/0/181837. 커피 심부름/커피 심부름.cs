using System;

public class Solution {
    public int solution(string[] order) {
        int answer = 0;
        
        for(int i = 0; i < order.Length; i++)
        {
            if(order[i] == "cafelatte" || order[i] == "hotcafelatte"||
               order[i] == "icecafelatte"|| order[i] == "cafelatteice"|| 
               order[i] == "cafelattehot")
            {
                answer += 5000;
            }
           if(order[i] == "americanoice" || order[i] == "iceamericano" ||
              order[i] == "americano" || order[i] == "hotamericano" || 
              order[i] == "americanohot" || order[i] == "anything")
           {
                answer += 4500;
           }
        }
        
        
        return answer;
    }
}