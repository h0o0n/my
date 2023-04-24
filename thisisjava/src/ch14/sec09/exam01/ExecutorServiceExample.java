package ch14.sec09.exam01;

import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;

public class ExecutorServiceExample {
	public static void main(String[] args) {
		//스레드풀생성
		ExecutorService executorService = Executors.newFixedThreadPool(5);
		//작업생성과 처리요청
		
		//스레드풀 종료
		executorService.shutdownNow();
	}
}
 