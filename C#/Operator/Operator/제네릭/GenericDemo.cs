using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator.제네릭
{
    class GenericDemo
    {
        public void genericDemo()
        {
            Stack stack = new Stack();                  //Object 타입으로 받고 Integer로 출력   box 에 포장해서 unboxing 하는 개념
            stack.Push(100);
            Console.WriteLine(stack.Pop());

            Stack<int> stacks = new Stack<int>(); //Integer 타입으로 받고 Integer로 출력 100이란 값을 그대로 담아서 출력 -> 속도면에서 이득
            stacks.Push(100);
            Console.WriteLine(stacks.Pop());
        }

        public void listDemo()
        {
            List<int> numbers = new List<int>();
            numbers.Add(100);
            numbers.Add(200);
            numbers.Add(300);

            foreach(int num in numbers)
            {
                Console.WriteLine(num);
            }

        }

        public void stringList()
        {
            List<string> color = new List<string>();
         
            color.Add("red");
            color.Add("green");
            color.Add("green");
            color.AddRange(color);

            foreach(string colors in color)
            {
                Console.WriteLine(colors);
            }
        }
        public void Enum()
        {
            List<int> numbers = new List<int>();

            numbers.AddRange(Enumerable.Range(1, 10)); // 1부터 10까지 저장하는 메서드
            numbers.AddRange(Enumerable.Repeat(1, 10)); // 1을 10번 반복저장하는 메서드
            foreach(int num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
