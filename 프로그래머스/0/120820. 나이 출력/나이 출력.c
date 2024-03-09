#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>

int solution(int age) {
    int answer = 0;
    int year = 2022;
    if(0<age<=120){
        answer = (year - age)+1;
    }
        
    
    return answer;
}