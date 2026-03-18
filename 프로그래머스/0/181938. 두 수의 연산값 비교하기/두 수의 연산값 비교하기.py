def solution(a, b):
    answer = 0
    
    x = str(a)+str(b)
    x = int(x)
    
    y = 2*a*b
    
    if x>y:
        answer = x
    else:
        answer = y
    
    
    return answer