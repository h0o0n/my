package ch12.sec03.exam03;

public class SmartPhone {
	public String company;
	public String os;

	public SmartPhone(String company, String os) {
		this.company = company;
		this.os = os;
	}
	
	@Override
	public String toString() {
		return company + "," + os;
	}
}
