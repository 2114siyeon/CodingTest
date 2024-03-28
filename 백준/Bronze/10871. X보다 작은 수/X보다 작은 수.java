import java.util.Scanner;
public class Main{
	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		
		int N = sc.nextInt();	//수열 개수
		int X = sc.nextInt();	//
		int[] A = new int[N];	//수열
		int answer[] = new int[N];
		int C = 0;
		
		for(int i = 0; i<N; i++) { 
			A[i] = sc.nextInt();
		
			for(int j = 0; j<N; j++) {
				C = A[i];
			}
					if(X>C) {
						System.out.print(C + " ");
					}
			}
		
	}
}
