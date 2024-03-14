class Solution {
    public int solution(int n, int k) {
        int answer = 0;
        
        int np = 12000, 
            kp = 2000;
        int nk = ((n*np)+(k*kp));
        int j;
                
        if((n/10)>=1){   
            j =  ((n/10)*(kp));
           answer = (nk-j);
        }else{
            answer = nk;
        }
        return answer;
    }
}