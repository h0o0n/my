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
 		return{
 			//replyService.list(param.callback)
 			list : list
 		}
 	}
 )();

 
