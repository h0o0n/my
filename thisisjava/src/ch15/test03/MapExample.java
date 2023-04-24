package ch15.test03;

import java.util.HashMap;
import java.util.Iterator;
import java.util.Map;
import java.util.Map.Entry;
import java.util.Set;
import java.util.TreeSet;

public class MapExample {
	public static void main(String[] args) {
		Map<String, Integer> map = new HashMap<>();
		map.put("blue", 96);
		map.put("hong", 86);
		map.put("white", 92);
		
		String name = null;
		int maxScore = 0;
		int totalScore = 0;
		
		//여기에 코드를 작성
		Set<Entry<String, Integer>> keySet = map.entrySet();
		Iterator<Entry<String, Integer>> iterator = keySet.iterator();
		while(iterator.hasNext()) {
			Entry<String, Integer> k = iterator.next();
			Integer v = k.getValue();
			totalScore += v;
			if(v > maxScore) {
				maxScore = v;
				name = k.getKey();
			}
		}
		System.out.println("평균점수 : " + totalScore/map.size());
		System.out.println("최고점수 : " + maxScore);
		System.out.println("최고점수를 받은 아이디 : " + name);
	}
}
