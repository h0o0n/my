package ch12.exam.fin05;

import java.text.SimpleDateFormat;
import java.util.Date;

public class SimpleDateFormatExample {

	public static void main(String[] args) {
		Date now = new Date();
		SimpleDateFormat sdf = new SimpleDateFormat("YYYY년 MM월 dd일 HH시 mm분");
		System.out.println(sdf.format(now));
	}
}
