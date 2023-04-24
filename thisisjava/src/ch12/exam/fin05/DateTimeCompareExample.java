package ch12.exam.fin05;

import java.time.LocalDate;
import java.time.LocalDateTime;
import java.time.temporal.ChronoUnit;

public class DateTimeCompareExample {

	public static void main(String[] args) {
		
		LocalDate startDateTime = LocalDate.now();
		LocalDate endDateTime = LocalDate.of(2023, 12, 31);
		long remainDay = startDateTime.until(endDateTime, ChronoUnit.DAYS);
		System.out.println(remainDay + " 일 남았습니다.");
	}

}
