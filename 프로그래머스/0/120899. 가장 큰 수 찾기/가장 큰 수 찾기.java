class Solution {
    public int[] solution(int[] array) {
        int[] answer = {0,0};
        int temp = 0;
        
        for(int i=0; i<array.length; i++){
            if(temp < array[i]){
                temp = array[i];
                
                answer[0] = temp;
                answer[1] = i;
        }
           
        }
        
        
        
        return answer;
    }
}