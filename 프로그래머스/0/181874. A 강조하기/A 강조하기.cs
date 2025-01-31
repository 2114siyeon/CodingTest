using System;

public class Solution {
    public string solution(string myString) {
        string answer = "";

        char[] charArray = myString.ToCharArray();
        
        for(int i = 0; i < charArray.Length; i++)
        {
            if(charArray[i] == 'a')
                charArray[i] = 'A';
            else if(charArray[i] != 'a' && charArray[i] != 'A')
                charArray[i] = char.ToLower(charArray[i]);
        }
        
        answer = new string(charArray);
        
        return answer;
    }
}