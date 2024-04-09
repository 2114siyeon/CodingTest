class Solution {
    public double solution(int[] arr) {
        double answer = 0;

        int n = 0;
        
        for(int i=0; i<arr.length;i++){
           n += arr[i];
            
        }
        
        answer = (double)n/arr.length;

        return answer;
    }
}