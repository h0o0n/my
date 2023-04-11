using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator
{
    class 논리연산자
    {
        public void 논리연산()
        {
            int i = 3;
            int j = 5;
            bool r = false;

            //&& 연산자 (AND) : 둘다 참일때에만 참, 즉, 하나라도 거짓이면 거짓
            //|| 연산자 (OR) : 하나라도 참이면 참, 즉 ,둘 다 거짓일때에만 거짓

            r = (i == 3) && (j != 3);
            Console.WriteLine(r);

            r = (i == 3) || (j != 3);
            Console.WriteLine(r);

            r = (i >= 5);
            Console.WriteLine("{0}",r);
            Console.WriteLine("{0}", !r); // r = false 였는데 ! 연산자를 통해 true로 변환
        }
    }
}
