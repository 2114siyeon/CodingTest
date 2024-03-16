import java.util.Scanner;
public class Main{
    public static void main(String args[]){
        Scanner sc = new Scanner(System.in);
//시험 점수를 입력받아 90 ~ 100점은 A, 80 ~ 89점은 B, 70 ~ 79점은 C, 60 ~ 69점은 D, 나머지 점수는 F를 출력
        
        int jumsu = sc.nextInt();
        
        if((jumsu>=90) && (jumsu<=100)){
            System.out.println("A");
        }else if((jumsu>=80) && (jumsu<=89)){
             System.out.println("B");
        }else if((jumsu>=70) && (jumsu<=79)){
             System.out.println("C");
        }else if((jumsu>=60) && (jumsu<=69)){
             System.out.println("D");
        }else{
             System.out.println("F");
        }
        
        
        
    }
}