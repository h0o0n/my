package ch16.sec05.test03;

public class Example {
	private static int[] scores = {10, 50, 3};
	
	public static int maxOrMin(Operator operator) {
		int result = scores[0];
		for(int score : scores) {
			result = operator.apply(result, score);
		}
		return result;
	}
	
	public static void main(String[] args) {
		int max = maxOrMin((result,score) ->{
			for(int i=0;i<scores.length ;i++) {
				if(result < scores[i]) {
					result = scores[i];
				}
			}
			return result;
			}
		);
		
		System.out.println(max);
		
		int min = maxOrMin((result,score) ->{
			for(int i=0;i<scores.length ;i++) {
				if(result > scores[i]) {
					result = scores[i];
				}
			}
			return result;
			}
		);
		
		System.out.println(min);
	}
}
