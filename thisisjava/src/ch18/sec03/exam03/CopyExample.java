package ch18.sec03.exam03;

import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.InputStream;
import java.io.OutputStream;

public class CopyExample { // 파일복사예제 is.transferTo(os) Java 9 부터;

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		String originalFileName = "C:/Temp/test.jpg";
		String targetFileName = "C:/Temp/test2_2.jpg";
		
		try {
			InputStream is = new FileInputStream(originalFileName); 
			OutputStream os = new FileOutputStream(targetFileName);
			is.transferTo(os);
		} catch(Exception e) {
			e.printStackTrace();
		}
		
		
		/*
		 * try { InputStream is = new FileInputStream(originalFileName); OutputStream os
		 * = new FileOutputStream(targetFileName);
		 * 
		 * byte[] data = new byte[1024];
		 * 
		 * while(true) { int num = is.read(data); if(num==-1) break;
		 * os.write(data,0,num); }
		 * 
		 * os.flush(); os.close(); is.close();
		 * 
		 * System.out.println("복사가 잘 되었습니다");
		 * 
		 * } catch (IOException e) { // TODO Auto-generated catch block
		 * e.printStackTrace(); }
		 */
		
	}

}
