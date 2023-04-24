package ch17.sec08.exam01;

import java.util.Arrays;

public class LoopingExample {
	public static void main(String[] args) {
		int[] intArr = {1,2,3,4,5};
		
		//잘못작성한경우
		Arrays.stream(intArr)
			.filter(a -> a%2 == 0)
			.peek(n -> System.out.println(n));
		
		//중간처리 메소드 peek을 이용하여 반복 처리
		int total = Arrays.stream(intArr)
		 .filter(a -> a%2 ==0)
		 .peek(n -> System.out.println(n)) //peek은 중간처리 메소드로 최종처리 메소드가 필요함
		 .sum(); //최종처리메소드
		System.out.println("총합 : " + total + "\n");
		
		//최종처리 메소드 forEach()를 이용해서 처리
		Arrays.stream(intArr)
			.filter(a -> a%2 ==0)
			.forEach(n -> System.out.println(n)); //최종처리가 되었으므로 돌아감
	}
}
