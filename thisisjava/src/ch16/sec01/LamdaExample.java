package ch16.sec01;

public class LamdaExample {

	public static void main(String[] args) {
		action((x,y) -> {
			int result = x + y;
			System.out.println("result : " + result);
		});
		
		action((x,y) -> {
			int result = x - y;
			System.out.println("result : " + result);
		});
	}

	private static void action(Calculable calculabe) {
		int x = 10;
		int y = 4;
		//데이터 처리
		calculabe.calculate(x, y);
	}

}
