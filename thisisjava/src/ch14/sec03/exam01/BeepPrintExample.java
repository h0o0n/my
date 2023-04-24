package ch14.sec03.exam01;

import java.awt.Toolkit;

public class BeepPrintExample {
	
	//멀티쓰레드 확인
	
	public static void main(String[] args) {
		
		//작업 1
		Thread thread = new Thread(new Runnable() {
			@Override
			public void run() {
				Toolkit toolkit = Toolkit.getDefaultToolkit();
				for(int i=0;i<5; i++) {
					toolkit.beep();
					try { 
						Thread.sleep(500);
					}catch(Exception e) {
						e.printStackTrace();
					}
				}
			}
		});
		thread.start();
		
	

/*		//작업 2
		for(int i=0;i<5; i++) {
			System.out.println("띵");
			try { 
				Thread.sleep(500);
			}catch(Exception e) {
				e.printStackTrace();
			}
		}
	}*/
	
	Runnable pt = new PrintThread();
	Thread thread2 = new Thread(pt);
	thread2.start();

	}
	
}
