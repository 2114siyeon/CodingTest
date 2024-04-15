import java.util.Arrays;
class Solution {
    public int solution(int[] array) {
        int answer = 0;
       Arrays.sort(array);
        
        for(int k=0; k<array.length; k++){
        answer = array[(k/2)];
        }
        
        
        return answer;
    }
}