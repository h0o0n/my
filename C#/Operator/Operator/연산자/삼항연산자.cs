using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator
{
    class 삼항연산자
    {
        public void 삼항연산()
        {
            int number = 2;

            string result = (number % 2 == 0) ? "짝수" : "홀수";
            Console.WriteLine(result);
            Console.WriteLine($"{number} 은(는) {result} 입니다.");
        }
    }
}
