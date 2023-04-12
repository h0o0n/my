using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator.구조체
{
    struct Point
    {
        public int x;   //public (공용) 외부에서사용가능
        public int y;

        private int z;  //private (전용) Class내에서만 사용가능
    }
    class StructureType
    {
        public void Structure()
        {
            //구조체란?
            //여러 개의 데이터 형식을 하나로 묶어서 관리하는 개념 - 하나 이상의 변수 또는 배열을 묶어서 관리
            //하나의 이름으로 여러 데이터 형을 보관
            //클래스 구조보다 접근이 빠름(스택사용)
            //상속 불가능
            Point point;

            point.x = 100;
            point.y = 200;
            Console.WriteLine($"x: {point.x}, y: {point.y}");

            Console.WriteLine(Char.ToUpper('a'));
            Console.WriteLine(Char.IsWhiteSpace(' '));
            Console.WriteLine(Char.IsWhiteSpace('A'));
            Console.WriteLine(Char.IsDigit('1'));
            Console.WriteLine(Char.IsDigit('b'));

            String gu = Guid.NewGuid().ToString();          //Guid 구조체 Guid.NewGuid(); Global로 유일한 아이디 값을 만들어줌
            Console.WriteLine(gu);
        }
    }
}
