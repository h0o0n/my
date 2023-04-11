using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cstudy
{
    class Wrapper
    {
        public void wrapper()
        {
            //래퍼 형식: int, string과 같은 기본 형식을 클래스 또는 구조체로 감싼 .NET 형식
            int number1 = 1234; //int 키워드 : 기본 형식
            Int32 number2 = 1234; //System.Int32 구조체 : .NET 형식
            Console.WriteLine($"{number1}, {number2}");


            string str1 = "안녕";
            string str2 = "안녕";
            Console.WriteLine($"{str1}, {str2}");
        }
        

    }
}
