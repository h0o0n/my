package com.jerajin.board.mapper;

import java.util.List;
import java.util.Map;

import com.jerajin.board.vo.ReplyVO;
import com.webjjang.util.PageObject;

public interface ReplyMapper {
	
	
	//Mybatis의 메서드들은 파라메터의 갯수를 한개만 받도록 작성되어 있다.

	//댓글 리스트 - 페이지처리
	//Map 으로 만들어서 해결 
	//Map - "pageObject"; pageObject, "no":no
	public List<ReplyVO> list(Map<String, Object> map) throws Exception;
	//public List<ReplyVO> list(PageObject pageObject) throws Exception;

	//댓글 보기 생략 - 리스트에 표시 됨
	
	//댓글 쓰기
	public int write(ReplyVO vo);
	//댓글 수정
	public int update(ReplyVO vo);
	//댓글 삭제
	public int delete(ReplyVO vo);
	
}
