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


<!--  reply -->
<script type="text/javascript" src="/js/reply.js"></script>
<script>
$(function(){
	
	console.log("==========================================");
	console.log("JS Reply List Test!!");
	
	var no = ${vo.no };
	var repPage = 1;
	var repPerPageNum = 5;
	
	console.log("JS Reply List no : " + no);
	console.log("JS Reply List repPage : " + repPage);
	console.log("JS Reply List repPerPageNum : " + repPerPageNum);
	
	replyService.list(
			
			//넘겨줄데이터
			{no:no, page:repPage, perPageNum:repPerPageNum},
			//성공했을때의 함수
			function(list){
				for(var i=0; i < list.length; i++){
					console.log(list[i]);
				}
			}
			
	);
});

</script>

<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>게시판 글보기</title>
</head>
<body>
<div class="container">
	<table class="table">
		<tr>
			<th>번호</th>
			<td>${vo.no }
		</tr>
		<tr>
			<th>제목</th>
			<td>${vo.title }
		</tr>
		<tr>
			<th>내용</th>
			<td>${vo.content }
		</tr>
		<tr>
			<th>작성자</th>
			<td>${vo.writer }
		</tr>
		<tr>
			<th>작성일</th>
			<td><fmt:formatDate value="${vo.writeDate }" pattern="yyyy-MM-dd"/></td>
		</tr>
		<tr>
			<th>조회수</th>
			<td>${vo.hit }
		</tr>
		<tr>
			<td colspan="2">
				<a href="update.do?no=${vo.no }&inc=0" class="btn btn-default">수정</a>
				<a href="delete.do?no=${vo.no }" class="btn btn-default">삭제</a>
				<a href="list.do" class="btn btn-default">리스트</a>
		</tr>
	</table>
	
	
</div>
</body>
</html>