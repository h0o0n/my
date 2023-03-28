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

ul.chat > li{
	margin-bottom: 5px;
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
				//alert(list);
				var str = "";
				//데이터가 없을 때의 처리 
				if(!list || list.list.length == 0){
					//alert("데이터 없음");
					str += "<li>데이터가 존재하지 않습니다.</li>";
				}else{				
					//alert("데이터 있음");
					for(var i=0; i < list.list.length; i++){
					console.log(list[i]);
						str += "<li class='Left clearfix' data-rno='"+ list.list[i].rno +"'>";
						str += "<div>"
						str += "<div class='header'>"
						str += "<strong class='primary-font replyerData'>" + list.list[i].replyer+ "</strong>"
						str += "<small calss='pull-right text-muted'>" + list.list[i].replyDate+ "</small>"
						str += "</div>"
						str += "<p><pre style='background:none;' class='replyData'>" + list.list[i].reply+ "</pre></p>";
						str += "<div class='text-right'>"
						str += "<button type='button' class='btn btn-default btn-xs replyUpdateBtn' id='replyUpdateBtn'>수정</button>"
						str += "<button type='button' class='btn btn-default btn-xs replyDeleteBtn'>삭제</button>"
						str += "</div>"
					    str += "</div>"
				        str += "</li>"
					}
				}
				replyUL.html(str);
			}
			
	);} //showList()의 끝 댓글보기끝
	
	
	
	//댓글 모달창의 전역변수
	
	var replyModal = $("#replyModal");
	
	// 댓글 등록 버튼 이벤트 처리 : 댓글의 모달 정보 조정과 창 보이기 -------------------
	$("#replyWriteBtn").click(function(){
		//reply > Form input 데이터 지우기
		replyModal.find("input, textarea").not('#replyNo').val("");
		//replyModal에 있는 입력 항목을 다 보이게
		//no도 포함해야함
		replyModal.find("div.form-control").show();
		//rno 사용하지 않음 보이지 않게
		//replyModal.find("#rnoDiv").hide();
		//replyModal.find("#noDiv").hide();
		//Modal 보이게
		replyModal.modal("show");
		$(".modal-footer").find("#replyModalUpdateBtn").hide();
		$(".modal-footer").find("#replyModalDeleteBtn").hide();
	});
	
	//댓글 모달창의 등록 버튼에 대한 이벤트 처리 - 입력된 데이터를 가져와서 JSON 데이터 만들기 - 서버에 전송
	$("#replyModalWriteBtn").click(function(){
		var reply = {};
		reply.no = no;
		reply.reply = $("#reply").val();
		reply.replyer = $("#replyer").val();
		reply.perPageNum = repPerPageNum;
		//alert(reply);
		alert(JSON.stringify(reply));
		replyService.write(reply, 
				//성공 했을 때의 처리 함수
				function(result){
					alert(result);
					replyModal.modal("hide");
					$(".modal-footer").find("#replyModalUpdateBtn").show();
					$(".modal-footer").find("#replyModalDeleteBtn").show();
					showList();
				}
		);
	});
	
	//댓글 수정폼 // ajax가 1번 html -> 2번 javascript 실행 -> ajax로 통신한것은 불가능
							//on event handler 사용하여 이벤트를 상속해서 사용해야한다
	$(".chat").on("click",".replyUpdateBtn",(function(){
		//alert("댓글 수정 클릭");
		
		//모달창 제목 바꾸기
		$(".modal-title").text("댓글 수정");
		//작업할 데이터 입력란을 안보이게
		replyModal.modal("show");
		//replyModal.find("#rnoDiv").hide();
		//replyModal.find("#noDiv").hide();
		$(".modal-footer").find("#replyModalWriteBtn").hide();
		$(".modal-footer").find("#replyModalDeleteBtn").hide();
		//데이터수집
		
		var li = $(this).closest("li");
		
		var rno= li.data("rno");
		//var rno= $(".Left clearfix").data("rno");
		var reply = li.find(".replyData").text();	
		var replyer = li.find(".replyerData").text();
		
		//데이터세팅
		$("#rno").val(rno);
		$("#reply").val(reply);
		$("#replyer").val(replyer);
		
		
	}));
	
	$("#replyModalUpdateBtn").click(function(){
		
		//alert("수정처리");
 		var reply = {};
		reply.rno = $("#rno").val();
		reply.reply = $("#reply").val();
		reply.replyer = $("#replyer").val();
		//reply.perPageNum = repPerPageNum;
		//reply.test = "test용도로 넘김";
		//alert(reply);
		//alert(JSON.stringify(reply));
		replyService.update(reply, 
				//성공 했을 때의 처리 함수
				function(result){
					alert(result);
					replyModal.modal("hide");
					$(".modal-footer").find("#replyModalWriteBtn").show();
					$(".modal-footer").find("#replyModalDeleteBtn").show();
					showList();
				}
		);
	});
	
	//댓글 삭제
	$(".chat").on("click",".replyDeleteBtn",(function(){
		alert("댓글 삭제 클릭");
		
		var li = $(this).closest("li");
		var reply = {};
		reply.rno = li.data("rno");
		console.log(reply);
		replyService.del(reply,
				function(result){
					alert(result);
					showList();
				}
		);
/* 		$(".modal-footer").find("#replyModalWriteBtn").hide();
		$(".modal-footer").find("#replyModalUPdateBtn").hide();
		replyModal.modal("show");
		replyModal.find("#rnoDiv").hide();
		replyModal.find("#noDiv").hide(); */
	}));
	
	
	
	// 댓글의 페이지 번호 클릭 이벤트 - 태그가 나중에 나온다. on() 필요
	$("#reply_nav").on("click", ".reply_nav_li", 
			function(){
				alert("댓글 페이지네이션 클릭");
			}
	);
});


</script>

<!DOCTYPE html>
<html>
<%@ include file="/resources/html/navbar.html" %>
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
					<i class ="fa fa-comments" style="font-size:24px"></i> 
					댓글
					<button class="btn btn-primary btn-xs pull-right"
						    id="replyWriteBtn"">작성하기</button>
				</div>
				<div class = "panel-body">
					<ul class="chat">
						<!-- 데이터가 있는 만큼 반복 처리 li 태그 -->
						<!-- rno표시하지않고 태그안에 속성으로 숨김 data-xxx -->
						<li class="Left clearfix" id="rnodata" data-rno="12">
							<div>
								<div class="header">
									<strong class="primary-font">user00</strong>	
									<small calss="pull-right text-muted">2023-03-24</small>
								</div>
								<p>Good job!</p>
								<div class="text-right">
									<button type="button" class="btn btn-default btn-xs replyUpdateBtn">수정</button>
									<button type="button" class="btn btn-default btn-xs replyDeleteBtn">삭제</button>
								</div>
							</div>
						</li>
					</ul>
				</div>
				<div class= "panel-footer">
					<pageObject:pageNav listURI="replies/list.do"  pageObject="${pageObject }" />
				</div>
			</div>
			<!-- 댓글 Panel의 끝 -->
		</div>
	</div>
	<!--  댓글의 끝 -->
	
	<!-- 댓글 작성/삭제/수정을 위한 modal 창 -->
	<div id="replyModal" class="modal fade" role="dialog">
		<div class="modal-dialog">
    <!-- Modal content-->
		    <div class="modal-content">
		      <div class="modal-header">
		        <button type="button" class="close" data-dismiss="modal">&times;</button>
		        <h4 class="modal-title"><i class ="fa fa-comments" style="font-size:24px"></i>
		        댓글 작성</h4>
		      </div>
		      <div class="modal-body">
		      	<form>
		      		<div class="form-group" id="rnoDiv">
		      			<label for="replyRno">댓글번호:</label>
		      			<input name="rno" type="text" class="form-control" id="rno">
		      		</div>
		      		<div class="form-group" id="noDiv">
		      			<label for="replyNo">글번호</label>
		      			<input name="replyNo" type="text" class="form-control" value="${vo.no }" id="replyNo" readonly="readonly">
		      		</div>
		      		<div class="form-group" id="replyDiv">
		      			<label for="reply">내용:</label>
		      			<textarea name="reply" class="form-control" rows="5" id="reply"></textarea>
		      		</div>
		      		<div class="form-group" id="replyerDiv">
		      			<label for="replyer">작성자:</label>
		      			<input name="replyer" type="text" class="form-control" id="replyer">
		      		</div>
		      	</form>
		      </div>
		      <div class="modal-footer">
		        <button type="button" class="btn btn-default" id="replyModalWriteBtn">등록</button>
		        <button type="button" class="btn btn-default" id="replyModalUpdateBtn">수정</button>
		        <button type="button" class="btn btn-default" id="replyModalDeleteBtn">삭제</button>
		        <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
		      </div>
		    </div>
  		</div>
	</div>
	<!-- modal의 끝 -->
	
	
</div> <!-- container의 끝 -->
</body>
</html>