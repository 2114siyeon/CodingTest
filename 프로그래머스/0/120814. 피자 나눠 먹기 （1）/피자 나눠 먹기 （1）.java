class Solution {
    public int solution(int n) {
        int answer = 0;
        int pizza = 7; //1판에 7조각
        int k = n/pizza;
        
        if((n%pizza)>=1){
            answer = (k+1);
            
        }else{
            answer = k;
        }
    
        
        
        return answer;
    }
}