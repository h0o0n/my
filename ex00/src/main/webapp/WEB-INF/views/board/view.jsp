<%@ page language="java" contentType="text/html; charset=UTF-8"
pageEncoding="UTF-8"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<%@ taglib prefix="fmt" uri="http://java.sun.com/jsp/jstl/fmt" %>
<%@ taglib prefix="pageObject" tagdir="/WEB-INF/tags" %>

<!-- bootstrap 라이브러리 등록 - CDN 방식 : sitemesh에서 decorator.jsp에서 한꺼번에 해결-->

<meta name="viewport" content="width=device-width, initial-scale=1">

<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>

<style type="text/css">
ul.chat{
	list-style:none;
}
</style>

<!--  reply -->
<script type="text/javascript" src="/js/reply.js"></script>
<script>
$(function(){
	
	console.log("==========================================");
	console.log("JS Reply List Test!!");
	
	var no = ${vo.no };
	var repPage = 1;
	var repPerPageNum = 5;
	var replyUL = $(".chat");
	
	showList();
	
	
	function showList(){
	replyService.list(
			//넘겨줄데이터
			{no:no, page:repPage, perPageNum:repPerPageNum},
			//성공했을때의 함수
			function(list){
				//alert(list.list);
				var str = "";
				//데이터가 없을 때의 처리 
				if(!list.list || list.list.length == 0){
					//alert("데이터 없음");
					str += "<li>데이터가 존재하지 않습니다.</li>";
				}else{				
					//alert("데이터 있음");
					for(var i=0; i < list.list.length; i++){
					console.log(list[i]);
						str += "<li class='Left clearfix' data-rno='"+ no +"'>";
						str += "<div>"
						str += "<div class='header'>"
						str += "<strong class='primary-font'>user00</strong>"
						str += "<small calss='pull-right text-muted'>2023-03-24</small>"
						str += "</div>"
						str += "<p><pre>" + list.list[i].reply+ "</pre></p>";
					    str += "</div>"
				        str += "</li>"
					}
				}
				replyUL.html(str);
			}
			
	);}
	
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
	<h1>게시판 글보기</h1>
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
	
	<!-- 댓글의 시작 -->
	<div class="row" style="margin-top: 20px;">
		<div class="col-lg-12">
			<div class ="panel panel-default">
				<div class = "panel-heading">
				<i class ="fa fa-comments" style="font-size:24px"></i>  댓글</div>
				<div class = "panel-body">
					<ul class="chat">
						<!-- 데이터가 있는 만큼 반복 처리 li 태그 -->
						<!-- rno표시하지않고 태그안에 속성으로 숨김 data-xxx -->
						<li class="Left clearfix" data-rno="12">
							<div>
								<div class="header">
									<strong class="primary-font">user00</strong>	
									<small calss="pull-right text-muted">2023-03-24</small>
								</div>
								<p>Good job!</p>
							</div>
						</li>
					</ul>
				</div>
				<div class= "panel-footer">Panel Footer</div>
			</div>
		</div>
	</div>
	<!--  댓글의 끝 -->
	
</div>
</body>
</html>