package ch15.sec04.exam03;

import java.io.IOException;
import java.util.Properties;

public class PropertiesExample {
	public static void main(String[] args) throws IOException {
		//Properties 컬렉션 생성
		Properties properties = new Properties();
		
		properties.load(PropertiesExample.class.getResourceAsStream("database.properties"));
		
		
		//키에대한 값 읽기
		String driver = properties.getProperty("driver");
		String url = properties.getProperty("url");
		String username = properties.getProperty("username");
		String password = properties.getProperty("password");
		
		System.out.println("driver : " + driver);
		System.out.println("url : " + url);
		System.out.println("username : " + username);
		System.out.println("password : " + password);
	}
}
