using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator.동적형식
{
    class 동적형식
    {
        public void main()
        {
            dynamic x;
            x = 1_234;
            Console.WriteLine($"{ x }");
            Console.WriteLine($"{x.GetType()}");
            x = "Dynamic Type!";
            Console.WriteLine($"{ x }");
            Console.WriteLine($"{x.GetType()}");
        }
    }
}
