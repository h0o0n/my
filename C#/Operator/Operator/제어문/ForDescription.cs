using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator.제어문
{
    class ForDescription
    {
       public void ForSumEven()
        {
            int n = 5;
            int sum = 0;
            for (int i = 1; i <=n; i++)
            {
                if( i% 2 == 0)
                {
                    sum += i; // 짝수 0,2,4, 더하기
                }
            }
            Console.WriteLine($"1부터 {n} 까지 짝수의 합:{sum}");
        }

    }
}
