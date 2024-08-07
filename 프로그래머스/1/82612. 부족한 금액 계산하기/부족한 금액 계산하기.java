class Solution {
    public long solution(int price, int money, int count) {
        long answer = 0;

        long sum = 0;
            
        for(int i=1; i<=count; i++){
            sum += i*price;
        }
        
        if((money-sum) < 0)
            answer = (money - sum)*(-1);
        
        if((money-sum) >= 0) 
            answer = 0;
        
        return answer;
    }
}