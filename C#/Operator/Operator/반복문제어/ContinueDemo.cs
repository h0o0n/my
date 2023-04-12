using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator.반복문제어
{
    class ContinueDemo
    {
        public void ContinueDemo1()
        {
            //continue문 : 반복문에서 아래 실행문을 실행하지 않고 다음 구문(조건절)으로 이동
            // 1~100 정수 중 3의 배수를 제외한 수의 합
          
            int sum = 0;
            for (int i= 1; i<= 100;  i++)
            {
                if(i % 3 == 0)
                {
                    continue;
                }
                    sum += i;
            }
            Console.WriteLine($"1부터 100까지의 합 : {sum}");
        }
    }
}
