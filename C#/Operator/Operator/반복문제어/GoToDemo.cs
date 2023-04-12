using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator.반복문제어
{
    class GoToDemo
    {
        //goto문 : 지정한 레이블(책갈피)로 이동하는 구문
        public void GoToDemo1()
        {
            Console.WriteLine("시작");
            Start:
            Console.WriteLine("0, 1, 2 중 하나 입력: _\b");
            int chapter = Convert.ToInt32(Console.ReadLine());
            
            if (chapter == 1)
            {
                goto Chapter1;
            }
            else if(chapter == 2)
            {
                goto Chapter2;
            }
            else
            {
                goto End;
            }

        Chapter1:
            Console.WriteLine("1장입니다");
            goto Start;
        Chapter2:
            Console.WriteLine("2장입니다");
            goto Start;
            End:
            Console.WriteLine("종료");
            
           
        }
    }
}
