package ch12.sec07;

import java.util.Arrays;
import java.util.Random;

public class RandomExample {
	public static void main(String[] args) {
		
		
		//선택번호
		int[] selectNumber = new int[6];
		Random random = new Random(3);
		System.out.println("선택 번호 : ");
		for(int i=0; i<selectNumber.length ; i++) {
			selectNumber[i] = random.nextInt(45) + 1;
			System.out.print(selectNumber[i] + " ");
		}
		System.out.println();
		
		//당첨번호
		int[] winningNumber = new int[6];
		random = new Random(3); // 시드값이 같을경우 같은 랜덤만 (현재시간을 이용하여 시드값이 같아도 시간에따라 값 변경가능)
		//random.setSeed(System.currentTimeMillis());
		System.out.println("당첨 번호 : ");
		for(int i=0; i<winningNumber.length ; i++) {
			winningNumber[i] = random.nextInt(45) + 1;
			System.out.print(winningNumber[i] + " ");
		}
		
		//당첨여부
		
		Arrays.sort(selectNumber);
		Arrays.sort(winningNumber);
		
		boolean result = Arrays.equals(selectNumber, winningNumber);
		System.out.println("당첨여부 : ");
		if(result) {
			System.out.println("당첨되었습니다.");
		}else {
			System.out.println("꽝입니다");
		}
	}
}
