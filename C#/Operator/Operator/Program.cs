﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = 1000;
            var number = num + 1234;
            Console.WriteLine(number);

            //연산자(Operator): 더하기,빼기와 같은 연산을 진행하는 키워드
            //식(Expression)
            //구문(Statement)

            var value = 0;
            value = 8;
            Console.WriteLine(value = +value);
            Console.WriteLine(value = -value);
            Console.WriteLine(value = -value);

            var number = 3.14;
            Console.WriteLine(number);

            Console.WriteLine("Hello, "  + "World");
            Console.WriteLine("123"  + "456");
            Console.WriteLine("123" + true);
        }
    }
}