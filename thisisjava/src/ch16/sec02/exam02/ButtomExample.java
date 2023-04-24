package ch16.sec02.exam02;

public class ButtomExample {

	public static void main(String[] args) {
		
		//OK 버튼 객체 생성
		Button btnOk = new Button();
		
		//OK 버튼 객체에 람다식(ClickListener 익명 구현 객체) 주입
		btnOk.setClickListener(()->{
			System.out.println("Ok 버튼을 클릭했습니다");
		});
		
		btnOk.Click();
		
		Button btnCancel = new Button();
		
		btnCancel.setClickListener(() -> System.out.println("Cancel 버튼을 클릭했습니다."));
		
		btnCancel.Click();
	}

}
