import java.util.Scanner;
public class Main {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		
		int N = sc.nextInt();	//N단의 N을 입력받음
		
		for(int i = N; i <=9; i++) {
			for(int j = 1; j<=9; j++) {
				System.out.println(i + " * " + j + " = " + (i*j));
			}
			break;
		}


	}

}
