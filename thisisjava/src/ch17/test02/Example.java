package ch17.test02;

import java.util.Arrays;
import java.util.List;
import java.util.stream.Collectors;

public class Example {
	public static void main(String[] args) {
		List<Member> list = Arrays.asList(
				new Member("홍길동",30),
				new Member("신용권",40),
				new Member("김자바",26)
				);
				
		double avg = list.stream()
				.collect(
						Collectors.averagingDouble(
								s->s.getAge())
						);
		
		System.out.println("평균나이: " + avg);
	}
}
