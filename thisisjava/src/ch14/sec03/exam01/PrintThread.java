package ch14.sec03.exam01;


public class PrintThread implements Runnable{

	@Override
	public void run() {
		for(int i=0;i<5; i++) {
			System.out.println("띵");
			try { 
				Thread.sleep(500);
			}catch(Exception e) {
				e.printStackTrace();
			}
		}
	}
}
