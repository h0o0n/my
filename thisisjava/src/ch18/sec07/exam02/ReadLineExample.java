package ch18.sec07.exam02;

import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;

public class ReadLineExample {

	public static void main(String[] args) throws IOException {
		
		String filePath = ("C:/oraclejava/workspace/thisisjava/src/ch18/sec07/exam02/ReadLineExample.java");
		
		FileReader fr2 = new FileReader(filePath);
		BufferedReader br2 = new BufferedReader(fr2);
		
		int line = 1;
		while(true) {
			String str = br2.readLine();
			if(str == null) break;
			System.out.println(line + "\t" + str);
			line++;
		}
		
		br2.close();
		
		/*
		 * BufferedReader br = new BufferedReader( new
		 * FileReader("src/ch18/sec07/exam02/ReadLineExample.java") );
		 * 
		 * 
		 * int lineNo = 1; while(true) { String str = br.readLine(); if(str == null)
		 * break; System.out.println(lineNo + "\t" + str); lineNo++; }
		 * 
		 * br.close();
		 */
	}

}
