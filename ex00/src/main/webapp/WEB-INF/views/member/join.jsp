<%@ page language="java" contentType="text/html; charset=UTF-8"
pageEncoding="UTF-8"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<%@ taglib prefix="fmt" uri="http://java.sun.com/jsp/jstl/fmt" %>
<%@ taglib prefix="pageObject" tagdir="/WEB-INF/tags" %>

<!-- bootstrap 라이브러리 등록 - CDN 방식 : sitemesh에서 decorator.jsp에서 한꺼번에 해결-->

<meta name="viewport" content="width=device-width, initial-scale=1">
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>

<script>
	function checkId(){
		var id = $("#id").val();// id 값 지정
		
		console.log(id);
		
		var pattern = new RegExp("/^[0-9a-zA-Z]{4,7}$");
		
		
		$.ajax({
			url:'idCheck',
			type:'post',
			data:{id:id},
			dataType:"json",
			success:function(cnt){
				console.log(cnt);
				if(cnt == 0){
					if(pattern.test(id)){
						alert("유효성검사 성공");//유효성검사
					}
					$(".id_ok").css("display","inline-block");
					$(".id_already").css("display","none");
				} else{
					$(".id_already").css("display","inline-block");
					$(".id_ok").css("display","none");
﻿﻿
				}
			},
			error:function(){
				alert("에러발생");
			}
		});
	}	
</script>

<style>
.id_ok{
display: none;
}

.id_already{
display: none;
}
</style>

<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>게시판 회원가입</title>
</head>
<body>
<div class="container">
<form action="join.do" method="post">
<h1>게시판 회원가입</h1>
<div class="form-group">
	<label>아이디</label>
	<input name="id" id="id" class="form-control" oninput="checkId()">
	<span class="id_ok">사용 가능한 아이디입니다.</span>
	<span class="id_already">누군가 이 아이디를 사용하고 있어요.</span>
</div>
<div class="form-group">
	<label>비밀번호</label>
	<input name="pw" id="pw" class="form-control">
</div>
<div class="form-group">
	<label>이름</label>
	<input name="name" id="name" class="form-control">
</div>
<button>회원가입</button>
</form>

</div>
</body>
</html>