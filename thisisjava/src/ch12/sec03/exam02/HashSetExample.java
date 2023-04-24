package ch12.sec03.exam02;


import java.util.HashSet;

public class HashSetExample {
	
	public static void main(String[] args) {
		HashSet hashset = new HashSet();
		
		Student s1 = new Student(1,"홍길동");
		hashset.add(s1);
		System.out.println("저장된 객체수 : " + hashset.size());
		
		Student s2 = new Student(1,"홍길동");
		hashset.add(s2);
		System.out.println("저장된 객체수 : " + hashset.size());
		
		Student s3 = new Student(2,"홍길동");
		hashset.add(s3);
		System.out.println("저장된 객체수 : " + hashset.size());
		
	}
}
