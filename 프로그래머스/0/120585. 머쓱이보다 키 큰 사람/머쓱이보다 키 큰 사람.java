class Solution {
    public int solution(int[] array, int height) {
        int answer = 0;
        int a = 0;
        int b = 0;
        
        for(int i=0; i<array.length; i++){
            
                a = array[i];
                if(height < a){
                   answer = ++b;
                }
            
        }
        return answer;
    }
            
}