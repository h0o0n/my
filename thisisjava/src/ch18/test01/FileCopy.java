package ch18.test01;

import java.io.BufferedInputStream;
import java.io.BufferedOutputStream;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.InputStream;
import java.io.OutputStream;


public class FileCopy {
	public static void main(String[] args) throws IOException {
		
		String origianlFiledir = "C:/Temp/dir1";
		String originalFileName = "C:/Temp/dir1/photo1.jpg";
		String targetFiledir = "C:/Temp/dir2";
		String targetFileName = "C:/Temp/dir2/photo2.jpg";

		
		File dir1 = new File(origianlFiledir);
		File file1 = new File(originalFileName);
		File dir2 = new File(targetFiledir);
		File file2 = new File(targetFileName);
		

		
		  try { 
			  InputStream is = new FileInputStream(originalFileName); 
			  BufferedInputStream bis = new BufferedInputStream(is);
			  
			  OutputStream os= new FileOutputStream(targetFileName);
			  BufferedOutputStream bos = new BufferedOutputStream(os);
		  
		  byte[] data = new byte[1024];
		  
		  while(true) { 
			  int num = bis.read(data); 
			  if(num==-1) break;
		      bos.write(data,0,num); 
		  }
		  
		  bos.flush(); bos.close(); bis.close(); os.close(); is.close();
		  
		  } catch (IOException e) {
			  System.out.println("원본 파일 경로 : " + originalFileName);
			  System.out.println("복사 파일 경로 : " + targetFileName);
			  System.out.println("원본파일이 존재하지않습니다.");
			  
			  if(dir1.exists() == false) { dir1.mkdirs();}
			  if(file1.exists() == false) { file1.createNewFile();}
			  if(dir2.exists() == false) { dir2.mkdirs();}
			  if(file2.exists() == false) { file2.createNewFile();}
			  
			  System.out.println("원본 파일 경로 : " + originalFileName);
			  System.out.println("복사 파일 경로 : " + targetFileName);
			  System.out.println("복사가 성공했습니다.");
		  	}
	}
}
