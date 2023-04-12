using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator
{
    class 비트연산자
    {
        public void 비트연산()
        {
            //비트 연산자와 시프트 연산자는 2진수 비트 단위로 연산을 수행하는데 사용함

            // &연산자 : 비트 AND 연산자(둘다 1일때만 1)
            byte x = 0b1010;
            byte y = 0b1100;


            Console.WriteLine($"    {Convert.ToString(x, 2) } -> {x}");
            Console.WriteLine($"  &{Convert.ToString(y, 2) } -> {y}");
            Console.WriteLine($"-------");
            Console.WriteLine($"  {Convert.ToString(x & y, 2) } -> {x&y}");


            // | 연산자 : 비트 OR 연산자(하나라도 1이면 1)

            byte x = 0b1010;
            byte y = 0b1100;


            Console.WriteLine($"    {Convert.ToString(x, 2) } -> {x}");
            Console.WriteLine($"   |{Convert.ToString(y, 2) } -> {y}");
            Console.WriteLine($"-------");
            Console.WriteLine($"    {Convert.ToString(x | y, 2) } -> {x | y}");

            // ^ 연산자: 비트 XOR 연산자 (서로 다르면 1 같으면 0)

            byte x = 0b1010;
            byte y = 0b1100;


            Console.WriteLine($"    {Convert.ToString(x, 2) } -> {x}");
            Console.WriteLine($"  ^{Convert.ToString(y, 2) } -> {y}");
            Console.WriteLine($"-------");
            Console.WriteLine($"    {Convert.ToString(x ^ y, 2).PadLeft(4,'0') } -> {x ^ y}");


            // ~ 연산자: 비트 NOT 연산자( 1 <-> 0, 비트 반전 연산자)

            byte x = 0b1010;
            byte y = 0b1100;


            Console.WriteLine($"  ~{Convert.ToString(x, 2) } -> {x}");
            Console.WriteLine($"-------");
            Console.WriteLine($"    {Convert.ToString(~x, 2).PadLeft(8, '0') } -> {~x}");

        }
    }
}
