/**
 * 게시판 댓글 처리에 필요한 JS(Jquery)
 */

 //브라우저의 콘솔 탭에 출력한다.
 console.log("Reply Module ......");
 
 // replyService 변수 - 타입은 Object -JSON


 var replyService = (
 	function(){
 		function list(param, callback, error){
 			var no = param.no;
 			var page = param.page || 1;
 			var perPageNum = param.perPageNum || 5;
 			
 			// Ajax를 이용한 데이터 가져오기
 			$.getJSON(
 				// ajax를 호출할 url
 				"/replies/list.do?no=" + no + "&repPage=" + page + "&repPerPageNum=" + perPageNum,
 				function(data){
 					//callback : 데이터를 가져오면 처리하는 함수 
 					console.log(data);
 					if(callback){
 						callback(data);
 					}
 				}
			)
			.fail(
				function(xhr, status, err){
					if(error){
						error();
					}else{
					// {}, [] 구조면 ok
						alert(err);
					}
			}
			); // getSJON 끝단
 		} //list 끝단
 		
 		//write()------------------------------
 		
 		function write(reply, callback, error){
 			console.log("reply write() ---------------------")
 			$.ajax({
 				//전송방법에대한 타입
 				type:"POST",
 				// 요청 URL
 				url:"/replies/write.do",
 				//전송되는 데이터의 타입과 인코딩 방식
 				data: JSON.stringify(reply),
 				//data: reply,
 				contentType:"application/json; charset=UTF-8",
 				// 정상적으로 댓글 쓰기 성공 했을 때의 처리하는 방식
 				success: function(result, status, xhr){
 					if(callback) callback(result);
 					else alert("댓글쓰기 성공");
 				},
 				//처리도중 오류가 난 경우 처리하는 함수
 				error : function(xhr,status,err){
					if(error) error(err);
					else alert("댓글쓰기 실패");				 						
 				}
 			});
 		}
 		
 		//update()-----------------------------
 		
 		function update(reply, callback, error){
			console.log("reply update() ---------------------") 		
			$.ajax({
				type:"patch", // Controller 와 매핑을 맞춰야함
				url: "/replies/update.do",
				data: JSON.stringify(reply),
				contentType:"application/json; charset=UTF-8",
				success: function(result, status, xhr){
					if(callback) callback(result);
					else alert("댓글 수정 성공");
				},
				error: function(xhr,status,err){
					if(error) error(err);
					else alert("댓글 수정 실패");
					}
				});
 		}
 		
 		//delete()------------------------------
 		
 		function del(reply, callback, error){
 			console.log("reply delete() --------------")
 			console.log(reply)
 			$.ajax({
 				type: "delete",
 				url: "/replies/del.do",
 				data: JSON.stringify(reply),
 				contentType:"application/json; charset=UTF-8",
 				success: function(result, status, xhr){
 					if(callback) callback(result);
 					alert("댓글 삭제 성공")
 				},
 				error: function(xhr,status,err){
 					if(error) error(err);
 					else alert("댓글 삭제 실패");
 				}
 			});
 		
 		}
 		
 		return{
 			//replyService.list(param.callback)
 			list : list,
 			write: write,
 			update:update,
 			del: del
 			
 		}
 	}
 )();

 
