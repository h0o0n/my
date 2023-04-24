package ch15.test02;

public class Student {
	public int studentNum;
	public String name;
	
	public Student (int studentNum, String name) {
		this.studentNum = studentNum;
		this.name = name;
	}
	
	//코드작성
	
	
	@Override
	public int hashCode() {
		return studentNum;
	}
	
	@Override
	public boolean equals(Object obj) {
		if(obj instanceof Student target) {
			return target.studentNum == studentNum;
		}
		return false;
	}
}
