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

<script type="text/javascript">
	$(function(){
		$("#cancelBtn").click(function(){
			history.back();
		});

		$("#deleteBtn").click(function(){			
			location = "delete.do?no=" + ${vo.no };
		});
	});
</script>


<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>게시판 글쓰기 폼</title>
</head>
<body>
<div class="container">
<form action="update.do" method="post">
<h1>게시판 글수정</h1>
<div class="form-group">
	<label>번호</label>
	<input name="no" id="no" class="form-control" value="${vo.no }" readonly="readonly">
</div>
<div class="form-group">

	<label>제목</label>
	<input name="title" id="title" class="form-control" value="${vo.title }">
</div>
<div class="form-group">
	<label>내용</label>
	<textarea name="content" id="content" class="form-control" rows="7">${vo.content }</textarea>
</div>
<div class="form-group">
	<label>작성자</label>
	<input name="writer" id="writer" class="form-control" value="${vo.writer }">
</div>
<button>수정</button>
<button type="reset">새로입력</button>
<button type="button" id="cancelBtn">취소</button>
<button type="button" id="deleteBtn">삭제</button>
</form>

</div>
</body>
</html>