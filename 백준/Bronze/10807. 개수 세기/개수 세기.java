import java.util.Scanner;
public class Main {
	public static void main(String[] args) {
	Scanner sc = new Scanner(System.in);
	
	int a = 0;
	int N = sc.nextInt();	//N개의 정수
		//V값
	int count = 0;	//V값은 몇개인가
	int arr[] = new int[N];	//배열생성
	
	for(int i=0; i<N; i++) {
		arr[i] = sc.nextInt();
	}
		int V = sc.nextInt();
		
		for(int j=0; j<N; j++) {
			a = arr[j];
				if(V==a)
					count++;
	}
	
	System.out.println(count);
	


	}

}