#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>

int solution(int num1, int num2) {
    int answer = 0;
    double result = (double)num1/num2;
    answer = result*1000;
    return answer;
}