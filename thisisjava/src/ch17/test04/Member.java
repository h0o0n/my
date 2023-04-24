package ch17.test04;

public class Member {
	private String name;
	private String job;
	
	public Member(String name, String job) {
		this.name = name;
		this.job = job;
	}
	
	public String getName() {return name;}
	public String getjob() {return job; }
	
	@Override
	public String toString() {
		return "{name:"+ name +", job:" + job + "}";
	}
}
