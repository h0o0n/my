using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator
{
    class 시프트연산자
    {
        public void 시프트연산()
        {
            Console.WriteLine("C# 시프트 연산자");

            byte x = 0b0000_0010;
            Console.WriteLine($" {nameof(x)}: {Convert.ToString(x,2).PadLeft(8,'0')} -> {x, 3} ");
            Console.WriteLine($" x = x << 1: {Convert.ToString(x, 2).PadLeft(8, '0')} -> {x << 2,3} ");
        }
    }
}
