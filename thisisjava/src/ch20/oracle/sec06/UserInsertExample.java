package ch20.oracle.sec06;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;

public class UserInsertExample {
	public static void main(String[] args) {
		Connection conn = null;
		try {
			Class.forName("oracle.jdbc.OracleDriver");
			
			conn = DriverManager.getConnection(
					"jdbc:oracle:thin:@localhost:1521/xe",
					"user2",
					"admin"
					);
			String sql =
					"INSERT INTO USERS (USERID, USERNAME, USERPASSWORD, USERAGE, USEREMAIL)"
					+ " VALUES (?, ?, ?, ?, ?)";
			
			PreparedStatement pstmt = conn.prepareStatement(sql);
			pstmt.setString(1, "winter");
			pstmt.setString(2, "한겨울");
			pstmt.setString(3, "12345");
			pstmt.setInt(4, 25);
			pstmt.setString(5, "winter@mycompany.com");
			
			int rows = pstmt.executeUpdate();
			System.out.println("저장된 행 수 : " + rows);
			
			pstmt.close();
			
		} catch (Exception e) {
			e.printStackTrace();
		} finally { try{if(conn!= null) conn.close();} catch(Exception e) {}}
	}
}
