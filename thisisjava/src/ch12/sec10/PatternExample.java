package ch12.sec10;

import java.util.regex.Pattern;

public class PatternExample {

	
	/*
	 * 02- 123 -1234
	 * (02|010)-\d
	 * String regExp = "\\w+@\\W+\\.\\+(\\.\\w+)?";
	 * 한개이상의문자 + @ + 한개이상의문자 + . + 한개이상의 문자 + (.한개이상의문자)생략가능
	 * white@naver.com(.net)
	 */
	
	
	public static void main(String[] args) {
		
		//String regExp = "\\w+@\\W+\\.\\+(\\.\\w+)?";
		//String regExp = "[a-zA-Z0-9]+@[a-zA-Z0-9]+\\.[a-zA-Z0-9]+";
		String regExp = "\\w+@\\w+\\.\\w+";
		String data = "white@naver.com";
		boolean result = Pattern.matches(regExp,data);
		
		if(result) {
			System.out.println("일치");
		}else {
			System.out.println("불일치");
		}
	}
}
