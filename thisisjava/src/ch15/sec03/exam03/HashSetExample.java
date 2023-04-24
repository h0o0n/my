package ch15.sec03.exam03;

import java.util.HashSet;
import java.util.Iterator;
import java.util.Set;

public class HashSetExample {
	public static void main(String[] args) {
		//HashSEt 컬렉션 생성
		Set<String> set = new HashSet<>();
		
		//객체 추가
		set.add("JAVA");
		set.add("JDBC");
		set.add("JSP");
		set.add("SPRING");
		
		//객체를 하나씩 가져와서 처리
		Iterator<String> iterator = set.iterator();
		while(iterator.hasNext()) {
			String element = iterator.next();
			System.out.println(element);
			//특정 객체 제거
			if(element.equals("JSP")){
				iterator.remove();
			}
		}
		System.out.println();
		
		//객체 제거
		set.remove("JDBC");
		
		//객체를 하나씩 가져와서 처리
		for(String str : set) {
			System.out.println(str);
		}
	}
}
