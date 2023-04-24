package ch12.sec08;

import java.util.Calendar;
import java.util.TimeZone;

public class CaleandarExample {

	public static void main(String[] args) {
		Calendar now = Calendar.getInstance();
		
		System.out.println(now.getTime());
		
		int year = now.get(Calendar.YEAR);
		int month = now.get(Calendar.MONTH) + 1;
		int day = now.get(Calendar.DAY_OF_MONTH);
		
		System.out.println(year + "년" +  month + "월" + day + "일");
		
		
	}
	

}
