using System;

public class Solution {
    public string solution(string my_string, string overwrite_string, int s) {
        string answer = "";
        string result = "";    
         string result2 = "";  
        char[] charArray = my_string.ToCharArray();
        
        for(int i = 0; i < s; i++)
        {
           result +=  charArray [i];
        }
        for(int j =  overwrite_string.Length+s; j<my_string.Length; j++)
        {
            result2 += my_string[j];
        }
        answer = (result + overwrite_string + result2);
        
        return answer;
    }
}