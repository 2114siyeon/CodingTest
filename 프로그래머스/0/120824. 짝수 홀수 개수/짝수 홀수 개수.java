class Solution {
    public int[] solution(int[] num_list) {
        int[] answer = {};
        int[] result = new int[2];
        
        int even = 0; //짝수
        int odd = 0;    //홀수
        
        for(int i=0; i<num_list.length; i++){
            if((num_list[i]%2) == 0){
                even++;
            }else{
                odd++;
            }
            
        }
       result[0]= even;
        result[1] = odd;
        
        answer = result;
        
        return answer;
    }
}