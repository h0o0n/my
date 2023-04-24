package ch14.sec04;

public class ThreadExample {

	public static void main(String[] args) {
		Thread mainThread = Thread.currentThread();
		System.out.println(mainThread.getName() + "실행");
		
		for(int i=0; i<3; i++) {
			Thread threadA = new Thread() {
				public void run() {
					System.out.println(this.getName() + "실행");
				};
			};
			threadA.start();
		}
		
		Thread chatThread = new Thread() {
			public void run() {
				System.out.println(this.getName()+"실행");
			};
		};
		chatThread.setName("chat-Thread");
		chatThread.start();
	}

}
