using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cstudy
{
    class Const
    {
        public void Constant()
        {
            //[!] 상수(constnat) : 변하지 않는 변수, 읽기 전용 변수
            //[!] 상수 선언과 동시에 초기화
            const double PI = 3.14;

            Console.WriteLine(PI);

            const string SITE_NAME = "네이버";
            Console.WriteLine(SITE_NAME);
        }
    }
}
