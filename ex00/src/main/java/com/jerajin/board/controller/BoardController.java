package com.jerajin.board.controller;

import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpSession;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;

import com.jerajin.board.service.BoardService;
import com.jerajin.board.vo.BoardVO;
import com.webjjang.util.PageObject;

@Controller
@RequestMapping("/board")
public class BoardController {
	
	
	//자동 주입(Dependency inject) -> 자동으로 하도록 지정하는 어노테이션 : @Autowired, @Inject
	@Autowired
	private BoardService service;
	
	//1. list
	// 처리 결과를 request에 담아야 하는데 Spring에서는 request가 model에 존재한다. 
	// model에 넣어주면 request에 담기도록 프로그램 되어있다. 파라메터로 모델 객체를 전달 받아서 사용한다.
	
	@GetMapping("/list.do")
	public String list(PageObject pageObject, Model model, HttpServletRequest request) throws Exception {
		
		//페이지가 1보다 작으면 1페이지로 세팅해준다.
		if(pageObject.getPage() < 1) pageObject.setPage(1);
		
		System.out.println("BoardController.list().pageObject - " + pageObject);
		
		//세션 로그인 확인
		HttpSession session = request.getSession();
		String sessionId = (String) session.getAttribute("sessionId");
		
		model.addAttribute("list", service.list(pageObject));
		model.addAttribute("sess", sessionId);
		return "board/list";	
	}
	
	//2. view
	@GetMapping("/view.do")
	public String view(long no, int inc, Model model) throws Exception {
		System.out.println("BoardController.view().no,inc - " + no + "," + inc);
		
		model.addAttribute("vo",service.view(no, inc));
		
		return "board/view";
	}
	//3-1.writeForm
	@GetMapping("/write.do")
	public String writeForm() throws Exception{
		return "board/write";
	}
	
	@PostMapping("/write.do")
	//3-2.write
	public String write(BoardVO vo) throws Exception{
		System.out.println("BoardController.write().vo - " + vo);
		service.write(vo);
		return "redirect:list.do";
	}
	//4-1.updateForm
	@GetMapping("/update.do")
	public String updateForm(long no, Model model) throws Exception{
		model.addAttribute("vo",service.view(no,0));
		return "board/update";
	}
	
	//4-2. update
	@PostMapping("/update.do")
	public String update(BoardVO vo) throws Exception{
		service.update(vo);
		return "redirect:list.do";
	}
	
	//5. delete
	@GetMapping("/delete.do")
	public String delete(BoardVO vo) throws Exception{
		service.delete(vo);
		return "forward:list.do";
	}
	
}
