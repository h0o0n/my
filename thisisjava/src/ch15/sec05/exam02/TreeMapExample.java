package ch15.sec05.exam02;

import java.util.Map.Entry;
import java.util.NavigableMap;
import java.util.Set;
import java.util.TreeMap;

public class TreeMapExample {

	public static void main(String[] args) {
		//TreeMap 컬렉션 생성
		TreeMap<String, Integer> treeMap = new TreeMap<>();
		
		//엔트리 저장
		treeMap.put("apple", 10);
		treeMap.put("forever", 60);
		treeMap.put("description", 40);
		treeMap.put("ever", 50);
		treeMap.put("zoo", 80);
		treeMap.put("base", 20);
		treeMap.put("guess", 70);
		treeMap.put("cherry", 30);
		
		//정렬된 엔트리 하나씩 가져오기
		Set<Entry<String,Integer>> entrySet = treeMap.entrySet();
		for(Entry<String,Integer> entry : entrySet) {
			System.out.println(entry.getKey() + ": " + entry.getValue());
		}
		System.out.println();
	
		
		//특정 키에대한 값 가져오기
		Entry<String,Integer> entry = null;
		entry = treeMap.firstEntry();
		System.out.println("Entry의 맨 처음 값 = " + entry.getKey() + ": " + entry.getValue());
		entry = treeMap.lastEntry();
		System.out.println("Entry의 맨 마지막 값 = " + entry.getKey() + ": " + entry.getValue());
		entry = treeMap.lowerEntry("ever");
		System.out.println("base키값 바로 앞의 값 = " + entry.getKey() + ": " + entry.getValue());
		
		System.out.println();
		
		//내림차순으로 정렬하기
		NavigableMap<String, Integer> descendingMap = treeMap.descendingMap();
		Set<Entry<String,Integer>> descendingEntrySet = descendingMap.entrySet();
		
		for(Entry<String,Integer> e: descendingEntrySet) {
			System.out.println(e.getKey() + " - " + e.getValue());
		}
		System.out.println();
		
		//범위검색
		System.out.println("[c~h 사이의 단어 검색 ]");
		NavigableMap<String, Integer> rangeMap = treeMap.subMap("c", true, "h", false);
		for(Entry<String,Integer> r : rangeMap.entrySet()) {
			System.out.println(r.getKey() + " - " + r.getValue());
		}
	}

}
