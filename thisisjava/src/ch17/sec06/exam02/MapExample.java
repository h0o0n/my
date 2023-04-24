package ch17.sec06.exam02;

import java.util.Arrays;
import java.util.stream.IntStream;

public class MapExample {
	public static void main(String[] args) {
		int[] Array = {1,2,3,4,5};
		
		IntStream stream = Arrays.stream(Array);

		stream
			.asDoubleStream()
			.forEach(d -> System.out.println(d));
		
		System.out.println();
		
		stream = Arrays.stream(Array);
		stream
			.boxed()
			.forEach(obj -> System.out.println(obj.intValue()));
	}
}
