package com.jerajin.board.service;

import java.util.HashMap;
import java.util.List;
import java.util.Map;

import org.springframework.beans.factory.annotation.Qualifier;
import org.springframework.stereotype.Service;
import org.springframework.web.bind.annotation.ResponseBody;

import com.jerajin.board.mapper.ReplyMapper;
import com.jerajin.board.vo.ReplyVO;
import com.webjjang.util.PageObject;

import lombok.AllArgsConstructor;
import lombok.extern.java.Log;
import lombok.extern.log4j.Log4j;

@Service
@AllArgsConstructor //어노테이션을 작성하지않아도 inject가 됨
@Qualifier("rsi")
@Log4j

public class ReplyServiceImpl implements ReplyService {
//impl 전자정부 프레임워크에서 사용해와서 계속 사용
	//Service 클래스에 직접 구현해도 상관 없음
	
	private ReplyMapper mapper;
	
	@Override
	public List<ReplyVO> list(PageObject pageObject, Long no) throws Exception {
		// TODO Auto-generated method stub
		pageObject.setTotalRow(mapper.getTotalRow(no));
		Map<String, Object> map = new HashMap<String, Object>();
		map.put("pageObject", pageObject);
		map.put("no", no);
		
		return mapper.list(map);
	}

	@Override
	public int write(ReplyVO vo) throws Exception {
		// TODO Auto-generated method stub
		System.out.println("write().vo : " + vo);
		return mapper.write(vo);
	}

	@Override
	public int update(ReplyVO vo) throws Exception {
		// TODO Auto-generated method stub
		System.out.println("update().vo : " + vo);
		return mapper.update(vo);
	}

	@Override
	public int del(ReplyVO vo) throws Exception {
		// TODO Auto-generated method stub
		//log.info("delete().vo : " + vo);
		return mapper.del(vo);
	}

}
