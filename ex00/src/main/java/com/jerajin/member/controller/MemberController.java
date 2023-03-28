package com.jerajin.member.controller;

import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpSession;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.ResponseBody;

import com.jerajin.member.service.MemberService;
import com.jerajin.member.vo.MemberVO;

@Controller
@RequestMapping("/member")
public class MemberController {
	
	
	@Autowired
	private MemberService service;
	
	//회원가입 페이지
	@GetMapping("/join.do")
	public String join() throws Exception{
		return "member/join";
	}
	
	@PostMapping("/join.do")
	public String join(MemberVO vo) throws Exception{
		service.join(vo);
		return "redirect:/board/list.do";
	}
	
	//로그인 페이지
	@GetMapping("/login.do")
	public String login() throws Exception{
		return "member/login";
	}
	
	@PostMapping("login.do")
	public String login(MemberVO vo, HttpServletRequest request) throws Exception{
		
		
		if(vo.getId() == null) {
			return "redirect:/";
		}
	
		service.login(vo);
		
		//세션 로그인 확인
		HttpSession session = request.getSession();
		session.setAttribute("sessionId", vo.getId());
		
		return "redirect:/board/list.do";
	}
	
	@PostMapping("/idCheck")
	@ResponseBody
	public int idCheck(@RequestParam("id") String id) {
		
		int cnt = service.idCheck(id);
		//System.out.println("idcheck :" + cnt); 데이터 넘어오는지 확인
		return cnt;
	}
}
