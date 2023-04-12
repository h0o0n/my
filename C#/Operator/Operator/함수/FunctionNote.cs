using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator.함수
{
    class FunctionNote
    {
        
        //함수선언
        static void Sum(int first, int second)
        {
            int sum = first + second;
            Console.WriteLine($"합계 : {sum}");
        }

        //호출 방식 메서드에서 바로 호출 할 수도 있음.
        public void functionNote() => Sum(3, 5);
    }

    
    }
