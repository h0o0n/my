package ch15.sec03.exam01;

import java.util.HashSet;
import java.util.Set;

public class HashSetExample {
	public static void main(String[] args) {
		
		//HashSet 컬렉션 생성
		Set<String> set = new HashSet<>();
		
		//객체를 저장
		set.add("JAVA");
		set.add("JDBC");
		set.add("JSP");
		set.add("JAVA");
		set.add("SPRING");
		
		//저장된 객체 수
		int size = set.size();
		System.out.println(size);
	}
}
