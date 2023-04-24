package ch12.exam.fin03;

public class time {
	
	public static void main(String[] args) {
		long time1 = System.nanoTime();
		int[] scores = new int[1000];
		for(int i=0; i<scores.length; i++) {
			scores[i] = i;
		}
		
		int sum = 0;
		for(int score : scores) {
			sum += score;
		}
		double avg = sum / scores.length;
		System.out.println(avg);
		long time2 = System.nanoTime();
		System.out.println( "프로그램 실행에 " + (time2-time1) + " 나노시간이 소요되었습니다.");
	}

}
