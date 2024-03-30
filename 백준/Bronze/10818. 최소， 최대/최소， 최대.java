import java.util.Scanner;
public class Main {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		
		int N = sc.nextInt();
		int[] arr = new int[N];
		int min, max = 0;
		
		
		for(int i=0; i<N; i++) 
		{
			arr[i] = sc.nextInt();	//배열에 값 넣기
		}
		
		min = arr[0];
		for(int k = 1; k<arr.length;k++) 
		{
			if(min>arr[k]) 
			{
				min = arr[k];
			}
		}System.out.print(min + " ");
		
		max = arr[0];
		for(int j = 1; j<arr.length; j++)
		{
			if(max < arr[j]) 	// 최대값
			{
				max = arr[j];
			}
		} System.out.print(max +" ");
		
		
	}
}
