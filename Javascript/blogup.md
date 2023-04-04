---
title:  "[JavaScript] 기본"
excerpt: ""
categories:
  - JavaScript
tags:
  - [JavaScript]

toc: true
toc_sticky: true
 
date: 2023-04-04
last_modified_at: 2023-04-04
---


#1 브라우저에 html p 태그와같이 출력하는 기능 
```javascript
document.write("브라우저 출력")
```

  
#2 브라우저에 개발자 모드(F12) 내에 콘솔로 출력하는 기능  
```javascript
console.log("콘솔창 출력")
console.log("확인")
```  

   
#3 브라우저에 경고장을 출력하는 기능 
```javascript
alert("경고장 출력!");
```  


#4 브라우저에 확인 창을 출력하는 기능  
```javascript
confirm("확인창 출력!")
```  


#5 데이터타입
```javascript
//데이터타입 number, string, boolean, undefined, null
var i1 = 10;   //정수
var i2 = 3.14; //실수
console.log(i1+i2);

var str1 = 'hi';
var str2 = "bye";
console.log(str1+str2);
console.log(str1,str2);

var bool1 = true;
var bool2 = false;
console.log(bool1,bool2);

var un;
console.log(un);
console.log(un + 20);

var tag = document.getElementById('good'); 
// 브라우저 상의 문서 객체 값을 얻어서 가져오는 함수 

//typeof - 데이터타입을 확인하는 명령
console.log(typeof i1);
console.log(typeof i2);
console.log(typeof str1);
console.log(typeof bool1);
console.log(typeof boo2);
console.log(typeof tag);
```  
  
#6 연산자




