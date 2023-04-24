package ch16.sec05.test04;

import java.util.ArrayList;
import java.util.List;

import ch16.sec05.test03.Operator;

public class Example {

	
	private static Student[] students = {
			new Student("홍길동", 90, 96),
			new Student("신용권", 95, 93)
	};
	
	
	
	public static double avg(Function<Student> student) {
		int sum = 0;
		for(Student score : students) {
			sum += student.apply(score);
		}
		
		double avg = sum/students.length;

		return avg;
	}
	
	public static String name(Function2<Student> student) {
		List<String> names = new ArrayList<>();
		for(Student n : students) {
			names.add(student.apply(n));
		}
		return names.toString();
	}
	
	
	public static void main(String[] args) {
		double englishAvg = avg( s -> s.getEnglishScore());
		
		System.out.println("영어점수 : " + englishAvg);
		
		double mathAvg = avg( s -> s.getMathScore());
		
		System.out.println("수학점수 : " + mathAvg);
		
		String namestring = name( n -> n.getName());
		System.out.println(namestring);
	}

}
