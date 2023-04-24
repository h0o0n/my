package ch13.example3;

public class UtilExample {
	public static void main(String[] args) {
		Pair<String, Integer> pair = new Pair<>("홍길동",35);
		Integer age = Util.getValue(pair,"홍길동");
		System.out.println(age);
		
		ChildPair<String, Integer> childPair = new ChildPair<>("홍상원", 20);
		Integer childAge = Util.getValue(childPair,"홍삼순");
		System.out.println(childAge);
		
		/*OtherPair<String, Integer> otherPair = new OtherPair<>("홍상원",20);
		int otherAge = Util.getValue(otherPair, "홍상원");
		System.out.println(otherAge);*/
	}
}
