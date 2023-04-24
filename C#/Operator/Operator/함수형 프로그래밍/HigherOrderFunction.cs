using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace Operator.함수형_프로그래밍
{
    internal class HigherOrderFunction
    {
        

        static void FuncitonParameterWithAction(Action<string> action, string message)
        {
            action(message);
        }

        Action<String> action = message => Console.WriteLine(message);

        
        
        static void FunctionParameterWithFunc(Func<int,int>func, int number)
        {
            int result = func(number);
            Console.WriteLine(  $"{number} * {number} = {result}");
        }

        Func<int,int> func = x => x*x;

        static Action<string> FunctionReturnValueWithAction() =>
            msg => Console.WriteLine($"{msg}" );

        int[] numbers = { 1, 2, 3, 4, 5 };

        public void main()
        {
            FuncitonParameterWithAction(action, "고차함수 : 매개변수");
            FunctionParameterWithFunc(func, 3);
            FunctionReturnValueWithAction();

            //최댓값구하기

            int max = numbers.Aggregate((f, s) => f > s ? f : s);
            Console.WriteLine(max);

            //최소값구하기
            int min = numbers.Aggregate((f, s) => f < s ? f : s);
            Console.WriteLine(min);
        }



    }
}
