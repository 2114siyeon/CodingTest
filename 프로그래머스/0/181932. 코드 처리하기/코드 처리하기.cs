using System;

public class Solution {
    public string solution(string code) {
        string answer = "";
        int mode = 0;  // 0이면 짝수 인덱스, 1이면 홀수 인덱스

        for (int i = 0; i < code.Length; i++) {
            if (code[i] == '1') 
            {
                mode = 1 - mode;  // mode 전환
            } 
            else 
            {
                if (mode == 0 && i % 2 == 0) 
                {
                    answer += code[i];
                } 
                else if (mode == 1 && i % 2 != 0) 
                {
                    answer += code[i];
                
                }
              
            }  
          
        }
  if(answer == "")
                    answer = "EMPTY";
        return answer;
    }
}
