package ch19.sec03.exam02;

import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.net.Socket;

public class EchoClient {
	public static void main(String[] args) {
		try {
			//Socket 생성과 동시에 localhost의 50001 포트로 연결 요청;
			Socket socket = new Socket("localhost", 50001);
			
			System.out.println("[클라이언트] 연결 성공");
			
			//데이터보내기
			String sendMessage= "나는자바가좋아";
			DataOutputStream dos = new DataOutputStream(socket.getOutputStream());
			dos.writeUTF(sendMessage);
			dos.flush();
			System.out.println("[클라이언트] 데이터를 보냄 : " + sendMessage);
			
			
			//데이터 받기
			DataInputStream dis = new DataInputStream(socket.getInputStream());
			String receiveMessage = dis.readUTF();
			System.out.println("[클라이언트] 데이터를 받음 : " + receiveMessage);
			
			socket.close();
			System.out.println("[클라이언트] 연결 끊음");
		}catch(Exception e_) {
		}
	}
}