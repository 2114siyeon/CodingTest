using System;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
        
        foreach(char c in my_string)
        {
            answer += char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c);
        }
        
        return answer;
    }
}