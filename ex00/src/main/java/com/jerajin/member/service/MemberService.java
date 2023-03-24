package com.jerajin.member.service;

import javax.inject.Inject;

import org.springframework.stereotype.Service;

import com.jerajin.member.mapper.MemberMapper;
import com.jerajin.member.vo.MemberVO;

@Service
public class MemberService {
	
	@Inject
	private MemberMapper mapper;
	
	
	//1번 join
	public int join(MemberVO vo) throws Exception{
		
		return mapper.join(vo);
		
	}
	
	
	//2번 login
	public MemberVO login(MemberVO vo) throws Exception{
		
		return mapper.login(vo);
	}


}
