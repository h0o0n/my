package ch20.oracle.sec12;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.Scanner;

public class BoardList {
	Connection conn = null;
	Scanner sc = new Scanner(System.in);
		
	
		public void mainMenu() {
			System.out.println();
			System.out.println("-----------------------------------------------------------------------");
			System.out.println("메인 메뉴: 1.Create | 2.Read | 3.Clear | 4.Exit");
			System.out.print("메뉴 선택: ");
			String menuNo = sc.nextLine();
			System.out.println();
			
			switch(menuNo){
			case "1" -> create();
			case "2" -> list();
			//case "3" -> clear();
			case "4" -> exit();
			}
		}	
	
		private void exit() {
			if(conn!= null) {
				try {
					conn.close();
				} catch (SQLException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
			}
			System.out.println("*********시스템 종료**********");
			System.exit(0);
		}

		public void list() {
			System.out.println();
			System.out.println("[게시물 목록]");
			System.out.println("-----------------------------------------------------------------------");
			System.out.printf("%-6s%-12s%-16s%-40s\n", "no", "writer", "date", "title");
			System.out.println("-----------------------------------------------------------------------");
			try {
				Class.forName("oracle.jdbc.OracleDriver");
				
				conn = DriverManager.getConnection(
						"jdbc:oracle:thin:@localhost:1521/xe", 
						"user2", 
						"admin"
					);
				
				String sql = "" +
						"SELECT bno, btitle, bcontent, bdate, bwriter " +
						"FROM boards ";
				
				PreparedStatement pstmt = conn.prepareStatement(sql);
				
				ResultSet rs = pstmt.executeQuery();
				while(rs.next()) {
					Board board = new Board();
					board.setBno(rs.getInt("bno"));
					board.setBtitle(rs.getString("btitle"));
					board.setBcontent(rs.getString("bcontent"));
					board.setBwriter(rs.getString("bwriter"));
					board.setBdate(rs.getDate("bdate"));
					System.out.printf("%-6s%-12s%-16s%-40s \n", 
							board.getBno(), board.getBwriter(), board.getBdate(), board.getBtitle());
				}
				
				read();
				rs.close();
				pstmt.close();
				
			}catch(Exception e) {
				e.printStackTrace();
			}
		}
		
		public void read() {
			
			System.out.println("[게시물 읽기]" );
			System.out.print("(처음화면 : 99) bno :  ");
			
			int bno = Integer.parseInt(sc.nextLine());
			
			if(bno == 99) {
				mainMenu();
			}
			try {
				Class.forName("oracle.jdbc.OracleDriver");
				
				conn = DriverManager.getConnection(
						"jdbc:oracle:thin:@localhost:1521/xe", 
						"user2", 
						"admin"
					);
				
				String sql = "" +
						"SELECT bno, btitle, bcontent, bdate, bwriter " +
						"FROM boards "+ 
						"WHERE bno = ?";
				
				PreparedStatement pstmt = conn.prepareStatement(sql);
				pstmt.setInt(1, bno);
				
				ResultSet rs = pstmt.executeQuery();
				while(rs.next()) {
					Board board = new Board();
					board.setBno(rs.getInt("bno"));
					board.setBtitle(rs.getString("btitle"));
					board.setBcontent(rs.getString("bcontent"));
					board.setBwriter(rs.getString("bwriter"));
					board.setBdate(rs.getDate("bdate"));
					
					System.out.println("-----------------------------------------------------------------------");
					System.out.println("번호 : " + board.getBno());
					System.out.println("제목 : " + board.getBtitle());
					System.out.println("내용 : " + board.getBcontent());
					System.out.println("날짜 : " + board.getBdate());
					System.out.println("-----------------------------------------------------------------------");

				}
				rs.close();
				pstmt.close();
				
			}catch(Exception e) {
				e.printStackTrace();
			}
			System.out.println("-----------------------------------------------------------------------");
			System.out.println("1.Update | 2.Delete | 3.List");
			
			System.out.print("[번호 입력] : ");
			int no = Integer.parseInt(sc.nextLine());
			
			switch(no){
			case 1 -> update(bno);
			case 2 -> delete(bno);
			case 3 -> list();
			}
			
			

		}
		
		private void delete(int dno) {
			Connection conn = null;
			try {
				//JDBC Driver 등록
				Class.forName("oracle.jdbc.OracleDriver");
				
				//연결하기
				conn = DriverManager.getConnection(
					"jdbc:oracle:thin:@localhost:1521/xe", 
					"user2", 
					"admin"
				);	
				
				//매개변수화된 SQL 문 작성
				String sql = "DELETE FROM boards WHERE bno=?";
				
				//PreparedStatement 얻기 및 값 지정
				PreparedStatement pstmt = conn.prepareStatement(sql);
				pstmt.setInt(1, dno);
				pstmt.executeUpdate();
				pstmt.close();
				
			} catch (Exception e) {
				e.printStackTrace();
			} 
			list();
		}
		

		private void update(int uno) {
			Connection conn = null;
			Board board = new Board();
			
			System.out.println();
			System.out.println("[게시물 수정화면]");
			System.out.print("수정할 제목 : ");
			board.setBtitle(sc.nextLine());
			System.out.print("수정할 내용 : ");
			board.setBcontent(sc.nextLine());
			System.out.print("수정할 작성자 : ");
			board.setBwriter(sc.nextLine());
			
			try {
				//JDBC Driver 등록
				Class.forName("oracle.jdbc.OracleDriver");
				
				//연결하기
				conn = DriverManager.getConnection(
					"jdbc:oracle:thin:@localhost:1521/xe", 
					"user2", 
					"admin"
				);	
				
				//매개변수화된 SQL 문 작성
				String sql = new StringBuilder()
						.append("UPDATE boards SET ")
						.append("btitle=?, ")
						.append("bcontent=?, ")
						.append("bwriter=?, ")
						.append("bdate=SYSDATE " )
						.append("WHERE bno=?")
						.toString();
				
				//PreparedStatement 얻기 및 값 지정
				PreparedStatement pstmt = conn.prepareStatement(sql);
				pstmt.setString(1, board.getBtitle());
				pstmt.setString(2, board.getBcontent());
				pstmt.setString(3, board.getBwriter());
				pstmt.setInt(4, uno);  
				pstmt.executeUpdate();
				pstmt.close();
				
			} catch (Exception e) {
				e.printStackTrace();
			} 
			
			list();
		}

		private void create() {
			
			Board board = new Board();
			
			System.out.println();
			System.out.println("[새 게시물 입력]");
			System.out.print("제목 : ");
			board.setBtitle(sc.nextLine());
			System.out.print("내용 : ");
			board.setBcontent(sc.nextLine());
			System.out.print("작성자 : ");
			board.setBwriter(sc.nextLine());
		
			
			try {
				Class.forName("oracle.jdbc.OracleDriver");
				
				conn = DriverManager.getConnection(
						"jdbc:oracle:thin:@localhost:1521/xe", 
						"user2", 
						"admin"
					);
				
				String sql = "" +
						"INSERT INTO boards (bno, btitle, bcontent, bwriter, bdate) " +
						"VALUES(SEQ_BNO.NEXTVAL, ?, ?, ?, SYSDATE)";
				
				PreparedStatement pstmt = conn.prepareStatement(sql);
				pstmt.setString(1, board.getBtitle());
				pstmt.setString(2, board.getBcontent());
				pstmt.setString(3, board.getBwriter());
				pstmt.executeUpdate();
				pstmt.close();
				
			} catch(Exception e) {
				e.printStackTrace();
			}
			list();
		}

		
		public static void main(String[] args) {
			BoardList boardlist = new BoardList();
			boardlist.mainMenu();
		}


}
