using System;

public class Solution {
    public string solution(string str1, string str2) {
        string answer = "";
        
       Char[] Str1 = str1.ToCharArray();
       Char[] Str2 = str2.ToCharArray();

        for(int i = 0; i<Str1.Length; i++)
        {
            answer += Str1[i];
            answer += Str2[i];
        }
        
        
        return answer;
    }
}