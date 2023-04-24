package ch12.exam.fin02;

public class Member {
	private String id;
	private String name;
	
	public Member(String id, String name) {
		this.id = id;
		this.name = name;
	}
	
	//코드 작성
	@Override
	public String toString() {
		
		return id +": " + name;
	}
}
