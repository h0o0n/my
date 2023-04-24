using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Nine
{
    internal class ChSharpNine
    {
        static void Main()
        {

            int Fib(int i) =>
            i switch
            {
                int when i <= 2 => 1,
                _ => Fib(i - 2) + Fib(i - 1)
            };

            Console.WriteLine(  Fib(7));
        }

    }
}
