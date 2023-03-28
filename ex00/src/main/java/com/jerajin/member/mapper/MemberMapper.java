package com.jerajin.member.mapper;

import com.jerajin.member.vo.MemberVO;

public interface MemberMapper {
	
	//회원가입
	public int join(MemberVO vo);
	
	//로그인처리
	public MemberVO login(MemberVO vo);

	public int checkId(String id);
}
