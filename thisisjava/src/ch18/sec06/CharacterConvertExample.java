package ch18.sec06;

import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.io.OutputStream;
import java.io.OutputStreamWriter;
import java.io.Reader;
import java.io.Writer;

public class CharacterConvertExample {
	public static void main(String[] args) throws IOException {
		
		
		write("문자 변환 스트림을 사용합니다.");
		String data = read();
		System.out.println(data);
		
		
		
		/*
		 * try { InputStream is = new FileInputStream("C:/Temp/test.txt"); Reader reader
		 * = new InputStreamReader(is);
		 * 
		 * char[] data = new char[100]; int num = reader.read(data); for(int i =0;
		 * i<num; i++) { System.out.print(data[i]); }
		 * 
		 * 
		 * System.out.println(); reader.close(); } catch (IOException e) { // TODO
		 * Auto-generated catch block e.printStackTrace(); }
		 */
	}

	private static String read() throws IOException {
		InputStream is = new FileInputStream("C:/Temp/test.txt");
		Reader reader = new InputStreamReader(is);
		char[] data = new char[100];
		int num = reader.read(data);
		
		reader.close();
		
		String str = new String(data,0,num);
		return str;
	}

	private static void write(String str) throws IOException {
		OutputStream os = new FileOutputStream("C:/Temp/test.txt");
		Writer writer = new OutputStreamWriter(os,"UTF-8");
		writer.write(str);
		writer.close();
		
	}
}
