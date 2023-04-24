package ch17.test01;

import java.util.Arrays;
import java.util.List;

public class Example {
	public static void main(String[] args) {
		List<String> list = Arrays.asList(
				"This is a java book",
				"Lamda Expression",
				"Java8 supports lamda expressions");
		list.stream()
		.filter(s->s.toLowerCase().contains("java"))
		.forEach(s -> System.out.println(s));
	}
}
