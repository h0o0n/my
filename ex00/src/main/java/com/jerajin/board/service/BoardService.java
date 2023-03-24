package com.jerajin.board.service;

import java.util.List;

import javax.inject.Inject;

import org.springframework.stereotype.Service;

import com.jerajin.board.mapper.BoardMapper;
import com.jerajin.board.vo.BoardVO;
import com.webjjang.util.PageObject;


//@Controller, @Service, @Repositroy, @Component, @RestController 
//-> root-context.xml, servlet-context.xml scan 패키지 안쪽에 존재
@Service
public class BoardService {
	
	@Inject
	private BoardMapper mapper;
	
	
	//1번 List
	public List<BoardVO> list(PageObject pageObject) throws Exception{
		
		pageObject.setTotalRow(mapper.getTotalRow(pageObject)); // 전체 데이터 개수 가져오기 처리
		System.out.println("BoardService.list().pageObject - " + pageObject);
		return mapper.list(pageObject);
	}
	
	//2번 View
	public BoardVO view (Long no, int inc) throws Exception{
		System.out.println("BoardService.view().no, inc" + no + "," + inc);
		if(inc == 1) mapper.increase(no);
		return mapper.view(no);
		
	}
	
	//3번 write
	public int write(BoardVO vo) throws Exception{
		return mapper.write(vo);
	}
	
	//4번 update
	public int update(BoardVO vo) throws Exception{
		return mapper.update(vo);
	}
	
	//5번 delete
	public int delete(BoardVO vo) throws Exception{
		return mapper.delete(vo);
	}
	
	
}
