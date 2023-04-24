package ch19.sec03.exam02;

import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.InputStream;
import java.io.OutputStream;
import java.net.InetSocketAddress;
import java.net.ServerSocket;
import java.net.Socket;
import java.util.Scanner;

public class EchoServer {
	
	private static ServerSocket serverSocket = null;
	
	public static void main(String[] args) {
		System.out.println("------------------------------------------");
		System.out.println("서버를 종료하려면 q또는 Q를 입력후 Enter  ");
		System.out.println("------------------------------------------");
		
		//TCP 서버 시작
		startServer();
		
		//키보드입력
		Scanner sc = new Scanner(System.in);
		while(true) {
			String key = sc.nextLine();
			if(key.toLowerCase().equals("q")) break;
		}
		sc.close();
		
		//TCP 서버 종료
		stopServer();
		
	}

	private static void stopServer() {
		Thread thread = new Thread() {
			public void run() {
				try {
					//ServerSocket을 닫고 Port언바인딩
					serverSocket.close();
					System.out.println("[서버] 종료됨");
					} catch(Exception e) {
				}
			}
		};
		
		thread.start();
		
	}

	private static void startServer() {
		Thread thread = new Thread() {
			public void run() {
				try {
					//ServerSocket 생성 및 Port바인딩
					serverSocket = new ServerSocket(50001);
					System.out.println("[서버] 시작됨");
					
					while(true) {
						System.out.println("\n[서버] 연결 요청을 기다림\n");
						//연결수락
						Socket socket = serverSocket.accept();
						
						//연결된 클라이언트 정보 얻기
						InetSocketAddress isa =
								(InetSocketAddress) socket.getRemoteSocketAddress();
						System.out.println("[서버]" + isa.getHostName() + "의 연결 요청을 수락함");
						
						/*
						//데이터 받기 1번 방법
						InputStream is = socket.getInputStream();
						byte[] bytes = new byte[1024];
						int readByteCount = is.read(bytes);
						String message = new String(bytes, 0, readByteCount, "UTF-8");
						
						//데이터 보내기 1번 방법
						OutputStream os = socket.getOutputStream();
						bytes = message.getBytes("UTF-8");
						os.write(bytes);
						os.flush();
						System.out.println("[서버] 받은 데이터를 다시 보냄 : " + message);
						*/
						
						//데이터 주고받기 2번 방법
						DataInputStream dis = new DataInputStream(socket.getInputStream());
						String message = dis.readUTF();
						
						DataOutputStream dos = new DataOutputStream(socket.getOutputStream());
						dos.writeUTF(message);
						dos.flush();
						System.out.println("[서버] 받은 데이터를 다시 보냄 : " + message);
						
						//연결 끊기
						socket.close();
						System.out.println("[서버]" + isa.getHostName() + "의 연결을 끊음");
					}
				} catch(Exception e) {
					System.out.println("[서버] : " + e.getMessage());
				}
			}
		};
		thread.start();
	}
}
