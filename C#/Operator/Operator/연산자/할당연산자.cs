using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator
{
    class 할당연산자
    {  
        public void 할당연산()
        {
            var name = "C#";
            var version = 8.0;
            Console.WriteLine($"{name}, {version}");

            //변수값 바꾸기
            var i = 100;
            var j = 200;
            Console.WriteLine($"처음 : {i}, {j}");

            var temp = i;
            i = j;
            j = temp;
            Console.WriteLine($"변경 : {i}, {j}");

            //변수 값을 1 증가. 감소시키기
            int num = 10;
            num = num + 1;
            Console.WriteLine(num);

            //변수 값을 1 감소시킬 수도 있습니다.
            int numb = 10;
            numb = numb - 1;
            Console.WriteLine(num);

            //위의 축약 형태
            int x = 3;
            int y = 3;
            x = x + 2;
            y += 2;
            Console.WriteLine($"x: {x}, y: {y}");

            //증감 연산자
            int numx = 100;
            Console.WriteLine(++numx);

            Console.WriteLine(--numx);
        }
    }
}
