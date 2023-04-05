---
title:  "[JavaScript] 기본 문법"
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
```javascript
var num1 = "10";
var num2 = 10;

console.log(num1==num2);  //true(값만을 비교하는 연산자)
console.log(num1!=num2);  //false
console.log(num1===num2); //false(데이터 타입까지 비교하는 연산자)
console.log(num1!==num2); //true(값과 데이터 값이 달라 true)

var a; //undefined
var b = null;

console.log(a, b, a == b); //true
console.log(a, b, a != b); //false
console.log(a, b, a ===b); //false
console.log(a, b, a !==b); //true
```

#7 배열  
```javascript
//배열의 선언.
var arr = [1,2,3];
console.log(arr);
var arr2 = ['park','kim','lee'];
console.log(arr2);

//자바스크립트에서는 배열의 데이터타입을 섞어서 사용할 수 있습니다.
var arr3 = [1, 2, 'kim']
console.log(arr3);

//배열의 선언.
var arr4 = new Array(); 
console.log(arr4);
var arr5 = new Array(1,2,3);
console.log(arr5);

//배열의 사용 
console.log(arr5[0] );
console.log(arr5[1] );
console.log(arr5[2] );

arr5[0] = 100;
arr5[1] = 200;
arr5[2] = 300;

console.log(arr5);

//배열에 관한 기능들 

var arr = new Array('a','b','c', 'd', 'e')
//length
console.log(arr.length)

//push - 마지막에 추가
arr.push(100);
console.log(arr);

//pop - 마지막에 요소 추가
arr.pop();
console.log(arr);

//unshift - 맨 앞 추가
arr.unshift(100);
console.log(arr);

//shift - 맨 앞 요소 제거
arr.shift();
console.log(arr);

//splice - 중간에 추가, 제거 
arr.splice(1,1);                    //splice(x,y)배열의 x번째 부터 y 개의 값을 지우는 기능
console.log(arr);  
arr.splice(1,2);
console.log(arr);
arr.splice(1,0,'park','kim','lee'); //1번째 인덱스에서 0개를 제거하고 제거된 위치에 추가할 수 있음 
console.log(arr);
```



---
title:  "[JavaScript] 함수"
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

자바스크립트는 객체 지향/ 절차지향 과는 다르게 함수지향형 언어이다.  
Java나 C언어에서는 함수를 사용할 때 약속된 형태로 이용하는데 반해
Javascript에서는 자유롭게 사용할 수 있다.   - 1급 최상위 함수 지원  
  
함수 - 코드를 블럭화 하여 재사용을 용이하게 함

#선언적 함수  
 일반적으로 이름을 붙여서 사용하는 함수

```javascript
function name() {

}
```
함수를 호출하여 사용해야 함. 순서는 위에서 아래서 해도 상관 없음
실행 방식 --> name()  
```javascript
<script>
compute();

//사용자 정의함수
function compute(){
    var a = 10;
    console.log(a);
}

function compute2(){
  console.log("선언적 함수 호출");
}

var = compute; //함수를 변수에 저장할 때는 괄호를 붙히지 않음
a();           //호출방식 a() == compute()
compute();

</script>
```  

#익명함수   
익명 함수는 이름이 없는 형태로 함수를 선언해서 통채로 변수에 저장하는 형태로 사용한다  
익명 함수 기법은 익명함수 이전에 호출할 수 없다. 다음에만 호출 가능  

```javascript
<script>
//익명함수 기법 - 변수에 함수를 저장해서 마치 함수를 변수처럼 사용하는 형태
var compute3 = function(){
    console.log("익명함수 호출")
}
compute3(); 
</script>
```


---
title:  "[JavaScript] 매개변수와 리턴"
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

#매개 변수  
-함수가 필요한 값을 전달하는 매개체  
-아무것도 적지 않을 수 있고, 여러개 받을 수 있으며 ,로 연결 가능  
-자바스크립트의 매개 변수는 함수를 호출하는데 영향을 끼치지 않음  
  
#return  
-메서드 실행 결과를 돌려주는 반환 값이다  
-자바스크립트의 return 뒤에 함수 실행 후 돌려 줄 값을 적는다  
-return false를 만나면 함수는 강제종료  

```javascript
<script>
function func1(x) {

    var sum = 0;
    for(var i=1; i<=x; i++){
        sum += i;
    }
    return sum;
}

function func2(x, y){
    return x+y;
}

var func3 = function(x,y,z){
    return x+y+z;
}

console.log (func1(10) );
console.log( func2(10, 20) );
console.log( func3(10, 20, '안녕') );
</script>
```
#함수가변인자
```javascript
<script>
  func1(1,2,3,4,5,"hi");

  //매개변수는 함수의 실행과 관련 없음을 알 수 있다
  //전달되는 매개변수 값은 arguments로 꺼내서 사용 가능

  function func1(a,b) {
    console.log(arguments);
    console.log(arguments[0]);
    console.log(arguments[5]);
    console.log
  }


</script>
```

---
title:  "[JavaScript] 전역변수와 지역변수"
excerpt: ""
categories:
  - JavaScript
tags:
  - [JavaScript]

toc: true
toc_sticky: true
 
date: 2023-04-04
last_modified_at: 2023-04-05
---

#전역변수
페이지 전역에서 사용할 변수는 함수 밖에 선언 하고 전역변수라고 한다.  
#지역 변수 
함수 안에서 사용할 변수는 함수 안에 선언하고 지역변수라고 한다.  
if,for문 안에 선언된 변수는 중괄호 밖에서도 사용 가능하다.

```javascript
<script>


//전역변수 사용
    var num1 = 50;
    if(num1 === 50){
        var num1 = 60;
    }
    console.log(num1);

//전역,지역변수 사용
    var num2 = 50;
    function add(){
        var num2 = 60;
        var num2 = 70;
    }
    add();
    console.log(num2); //50
</script>
```
#클로저  
외부 함수에서 내부의 값에 접근하여 사용할 수 있는 것
```javascript
<script>
  function func1() {
      var a = "안녕";

      return function(){
          return a;
      }   
  }

  var b = func1();
  console.log(b); //실행결과  ƒ (){ return a; } 함수 자체를 호출
  console.log(b() ); //함수를 호출하여 값에 클로저 "안녕" 호출
</script>
```

---
title:  "[JavaScript] 객체(Object)"
excerpt: ""
categories:
  - JavaScript
tags:
  - [JavaScript]

toc: true
toc_sticky: true
 
date: 2023-04-05
last_modified_at: 2023-04-05
---


#객체(Object)

자바스크립트의 객체는 {키:값}로 표기됩니다.  
자바스크립트의 객체는.을 찍어 접근한다.
Java의 Map과 비슷하다  

```javascript
<script>
    //객체 생성
    var person ={name: "홍길동", age: 20, arr:[1,2,3]};

    //객체에 접근하는 첫번째 방법
    console.log(person.name);
    console.log(person.age);
    console.log(person.arr[0]);
    console.log(person);

    //객체에 접근하는 두번째 방법
    console.log(person["name"]);
    console.log(person["arr"][0]);


    var exam = {math:50, eng:70, kor:90};

    var kim = {name:"김길동", exam: exam};
    //위의 kim 객체의 exam key 값에 위 exam 객체가 저장됨
    console.log(kim.name);
    console.log(kim.exam);
    //실행결과 {name: '홍길동', age: 20, arr: Array(3)}
    
    //배열안에 객체
    var arr =[
        {id:1, title:"hi", content:"안녕하세요"},
        {id:2, title:"bye", content:"안녕히가세요"}
    ];

    console.log(arr);
    console.log(arr[0].id);
    console.log(arr[0].title);
    console.log(arr[0].content);
</script>
```

---
title:  "[JavaScript] JSON(Javascript Object Notation)"
excerpt: ""
categories:
  - JavaScript
tags:
  - [JavaScript]

toc: true
toc_sticky: true
 
date: 2023-04-05
last_modified_at: 2023-04-05
---

#JSON  
JSON은 자바스크립트 객체로 구성된 데이터이다  
JSON을 이용하여 원격에 있는 데이터를 주고받을 수 있는데 
'문자열 형'으로만 주고받을 수 있고  
JSON.parse()는 문자열 -> JSON  
JSON.stringfiy()는 JSON -> 문자열 으로 변환한다
