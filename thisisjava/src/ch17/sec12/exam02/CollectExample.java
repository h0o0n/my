package ch17.sec12.exam02;

import java.util.ArrayList;
import java.util.List;
import java.util.Map;
import java.util.stream.Collectors;

public class CollectExample {


	public static void main(String[] args) {
		List<Student> list = new ArrayList<Student>();
		list.add(new Student("홍길동","남", 92));
		list.add(new Student("김수영","여", 87));
		list.add(new Student("김자바","남", 95));
		list.add(new Student("오해영","여", 93));
		
		Map<String,List<Student>> map = list.stream()
				.collect(
					Collectors.groupingBy(s->s.getSex())
					);
		
		List<Student> mlist = map.get("남");
		mlist.stream().forEach(s->System.out.println(s.getName() + " 성적 : " +s.getScore()));
		System.out.println();
		List<Student> flist = map.get("여");
		flist.stream().forEach(s->System.out.println(s.getName()));
				
	}
}
