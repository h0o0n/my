package ch17.sec02.exam01;

import java.util.ArrayList;
import java.util.List;
import java.util.stream.Stream;

public class StreamExample {
	public static void main(String[] args) {
		
		//List 컬렉션 생성
		
		List<String> list = new ArrayList<>();
		list.add("홍길동");
		list.add("신용권");
		list.add("김자바");
		list.add("람다식");
		list.add("박병렬");
		
		//병렬처리
		
		Stream<String> parallelStream = list.parallelStream();
		parallelStream.forEach(item ->{
			System.out.println(item + ": " + Thread.currentThread().getName());
		});
	}
}
