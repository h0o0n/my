using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator.반복문제어
{
    class BreakDemo
    {
        public void Break()
        {
            //break 문 : for, while, do 구문을 빠져나가는 역할
            for (int i = 0; i< 100; i++)
            {
                if (i == 5)
                {   
                    break; // i ==5 일때 for 문 종료
                }
                Console.WriteLine($"{i+1}번 반복 ");
            }
            Console.WriteLine();

        }
        public void Break2()
        {
            //무한루프이용
            int j = 0;
            while (true)
            {
                if (j == 5)
                {
                    break;
                }
                Console.WriteLine($"{j + 1}번 반복\t");
                j++;
            }
            Console.WriteLine();
        }
    }
}
