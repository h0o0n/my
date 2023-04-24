package ch17.sec12.exam01;

import java.util.ArrayList;
import java.util.List;
import java.util.Map;
import java.util.stream.Collectors;

public class CollectExample {
	public static void main(String[] args) {
		List<Student> list = new ArrayList<>();
		list.add(new Student("홍길동","남",92));
		list.add(new Student("김수영","여",87));
		list.add(new Student("김자바","남",95));
		list.add(new Student("오해영","여",93));
		
		
		List<Student> maleList = list.stream()
				.filter(s -> s.getSex().startsWith("남"))
				.toList();
		
		maleList.stream()
			.forEach(s -> System.out.println(s.getName()));
		
		
		System.out.println();
		
		
		Map<String, Integer> map = list.stream()
				.collect(
				  Collectors.toMap(
						  s -> s.getName(), 
						  s -> s.getScore()
						  )
				  );
		
		System.out.println(map);
	}

}
