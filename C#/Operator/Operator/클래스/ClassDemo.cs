using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator.클래스
{
    class ClassDemo
    {
        public void classDemo()
        {
            Square square = new Square();
            square.width = 10;
            square.height = 10;

            Console.WriteLine($"사각형의 넓이 : {square.width * square.height}");
            Random ran = new Random();
            int a = ran.Next(1, 6);

            //is  string 인지 확인하는 연산자
            string s = "Foo";
            Console.WriteLine(s is string);

            int i = 1234;
            Console.WriteLine(i is int);

            object x = 1234;
            string s1 = x as string;
            Console.WriteLine(s1);

            object xx = "1234";
            string ss = x as string;
            Console.WriteLine(ss);
        }
    }

    class Square
    {
        public int width;
        public int height;
    }

    

}
