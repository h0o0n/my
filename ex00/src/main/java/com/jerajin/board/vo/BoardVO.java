package com.jerajin.board.vo;

import java.util.Date;

import lombok.Data;

// lombok 라이브러리 사용 
// #### lombok - setter(), getter(), 생성자, toString()를 자동으로 만들어 주는 라이브러리
//1. lombok 라이브러리인 jar 다운로드 -> https://projectlombok.org/download
//2. 사용할 IDE 통합개발 툴에 인식시키기 -> 명령프롬프트에서 다운로드 받은 폴더로 이동 후 -> java -jar lombok.jar
//3. pom.xml에서 dependency 등록

@Data
public class BoardVO {

	private long no;
	private String title, content, writer;
	private Date writeDate;
	private long inc;
	private long hit;
	private long replyCnt;
	private String pw;
	
}