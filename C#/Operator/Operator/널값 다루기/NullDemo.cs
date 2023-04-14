using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator.널값_다루기
{
    class NullDemo
    {
        public void nullDemo()
        {
            Nullable<bool> bln = null;
            Console.WriteLine(bln.HasValue);
            bln = true;
            Console.WriteLine(bln.HasValue);

            //Nullable 형식 : null(값이 없음을 의미 ) 이 할당될 수 있는 형식
            //참조형식: null 할당 가능
        }
        public void nullDemo2()
        {
            int? i = null; // 값 타입 뒤에 ? 를 붙이게 되면 null 가능 형식이다. 
            Console.WriteLine(i);

            Nullable<int> ii = null;
            int? ij = null;
            double? dd = null; //? 사용을 권장한다.
            Console.WriteLine(dd);

        }

        public void nullDemo3()
        {
            //?? 연산자 ( 널 병합 연산자 (Null Coalescing Operator))
            string nullValue = null;
            string message = "";

            //[1] if 구문으로 null 값 비교
            nullValue = null;
            if (nullValue == null)
            {
                message = "[1] null 이면 새로운 값으로 초기화 한다.";
            }
            Console.WriteLine($"{message}");

            //[2] ?? 연산자로 null 값 비교 (★권장)
            nullValue = null;
            message = nullValue ?? "[2] null 이면 새로운 값으로 초기화 한다.";
            Console.WriteLine(message);

            nullValue = null;
            message = nullValue ?? "Nothing";
            Console.WriteLine(message);

            int? value = null;
            int defaultValue = value ?? -1; // value 값을 삽입하는데 value 값이 Null 값이면 -1 로 초기화한다.
            Console.WriteLine(defaultValue);

            int? x = null; // null 값을 삽입할 수 
            int y = x ?? 100;
            int z = x ?? default(int); //정수형의 기본값인 0 으로 초기화
            int zz = x ?? default; // 정수형의 기본값인 0으로 초기화 ★권장
            Console.WriteLine(zz);


            // 널 조건부 연산자(Null Conditional)
            double? d = null;
            Console.WriteLine(d);

            double? dd = 1.0;
            Console.WriteLine(dd?.ToString()); // d가 null이 아니면 ToString을 사용해서 변환해라 라는 의미이다.
            Console.WriteLine(dd?.ToString("#.00")); // 원하는 format으로 출력도 가능하다. 
        }

        public void NullConditional()
        {
            int? len;
            string message;
            message = null;
            len = message?.Length;
            Console.WriteLine(len);
            message = "안녕";
            len = message?.Length;
            Console.WriteLine(len);

            //?.연산자 : 컬렉션이 null 이면 null, 그렇지 않으면 뒤에 오는 속성 값 반환
            List<string> list = null;
            int? numberOfList;

            numberOfList = list?.Count;
            Console.WriteLine(numberOfList);

            list = new List<String>();
            list.Add("안녕하세요");
            list.Add("반갑습니다.");

            numberOfList = list?.Count;
            Console.WriteLine(numberOfList);


        }

        public void nullDemo4()
        {
            //널 병합 연산자와 널 조건부 연산자와 함께 사용하기

            int num;
            List<string> list;
            list = null;
            num = list?.Count ?? 0; //가장 많이 보이는 코드 null이면 0을 반환, 즉 오른쪽 값 사용
            Console.WriteLine(num);

            //[2] 컬렉션 리스트가 null이 아니면 Count 속성의 값을 사용
            list = new List<string>();
            list.Add("또 만나요.");
            num = list?.Count ?? 0; // null 값이 0이 아니라서 왼쪽 값을 사용
            Console.WriteLine(num);

        }
    }
}
