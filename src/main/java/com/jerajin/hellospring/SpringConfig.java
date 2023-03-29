package com.jerajin.hellospring;

import com.jerajin.hellospring.repository.MemberRepository;
import com.jerajin.hellospring.repository.MemoryMemberRepository;
import com.jerajin.hellospring.service.MemberService;
import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;

@Configuration
public class SpringConfig {

    @Bean
    public MemberService memberService() {
        return new MemberService(memberRepository());
    }

    @Bean
    public MemberRepository memberRepository() {
        return new MemoryMemberRepository();
    }

}
