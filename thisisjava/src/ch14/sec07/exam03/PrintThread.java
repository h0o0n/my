package ch14.sec07.exam03;

public class PrintThread extends Thread{
	@Override
	public void run() {

		while(true) {
			System.out.println("실행중");
			if(Thread.interrupted()) {
				break;
			}
		}
	
	}
}
