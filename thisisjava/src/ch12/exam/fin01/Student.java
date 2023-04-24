package ch12.exam.fin01;

public class Student {
	private String studentNum;
	
	public Student(String studentNum) {
		this.studentNum = studentNum;
	}
	
	public String getStudentNum() {
		return studentNum;
	}
	
	//코드 작성
	
	@Override
	public int hashCode() {
		int hashCode = studentNum.hashCode();
		return hashCode;
	}
	
	@Override
	public boolean equals(Object obj) {
		
		if(obj instanceof Student target) {
			if(studentNum.equals(target.getStudentNum())) {
				return true;
			}
		}
		return false;
	}
	
}
