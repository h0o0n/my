using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator
{
    class 관계형_연산자
    {
        public void 관계형연산자()
        {
            //관계형(비교) 연산자:
            //>, <, >=, <=, ==, !==
            int firstNum = 10;
            int secondNum = 5;
            bool r = false;

            Console.WriteLine(firstNum > secondNum); // true

            r = (firstNum <= secondNum); //false
            Console.WriteLine(r);

            r = (firstNum == secondNum); // C Family : == 로 같은지 확인
            Console.WriteLine(r);              // false

            r = (firstNum != secondNum); // C Family : == 로 같은지 확인
            Console.WriteLine(r);             // true
        }
    }
}
