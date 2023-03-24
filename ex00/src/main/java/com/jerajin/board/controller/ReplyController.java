package com.jerajin.board.controller;

import java.util.HashMap;
import java.util.List;
import java.util.Map;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.beans.factory.annotation.Qualifier;
import org.springframework.http.HttpStatus;
import org.springframework.http.MediaType;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PatchMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

import com.jerajin.board.service.ReplyService;
import com.jerajin.board.vo.ReplyVO;
import com.webjjang.util.PageObject;


@RestController
@RequestMapping("/replies")

public class ReplyController {

// 자동 DI
	@Autowired
	@Qualifier("rsi")
	private ReplyService service;
	// 1. 게시판 댓글 리스트 - 검색 / list.do - get -> list.json 불가능 : xml만 서비스

	@GetMapping(value = "/list.do",
			produces = {
					MediaType.APPLICATION_XML_VALUE,
					MediaType.APPLICATION_JSON_UTF8_VALUE
			})

	// ResponseEntity : 실행 상태 코드와 함께 실행결과를 클라이언트에서 전달할때 사용하는 객체

	public ResponseEntity<Map<String, Object>> list(
			// public ResponseEntity<List<ReplyVO>> list(
			@RequestParam(defaultValue = "1") long repPage,
			@RequestParam(defaultValue = "5") long repPerPageNum,
			long no)
			throws Exception {

		Map<String, Object> map = new HashMap<>();
		// 댓글에 대한 페이지 정보
		PageObject replyPageObject = new PageObject(repPage, repPerPageNum);
		map.put("pageObject", replyPageObject);
		map.put("list", service.list(replyPageObject, no));
		return new ResponseEntity<>(map, HttpStatus.OK);
	}

	@PostMapping("/write.do")
	//3-2.write
	public String write(ReplyVO vo) throws Exception{
		service.write(vo);
		return "redirect:list.do";
	}
	
	//4-2. update
	@PatchMapping("/update.do")
	public String update(ReplyVO vo) throws Exception{
		service.update(vo);
		return "redirect:list.do";
	}
	
	//5. delete
	@DeleteMapping("/delete.do")
	public String delete(ReplyVO vo) throws Exception{
		service.delete(vo);
		return "forward:list.do";
	}
	
}
