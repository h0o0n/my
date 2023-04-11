// 자리 표시자(개체 틀)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldFrameWorkWithVisualStudio._09_PlaceHolder
{
    class PlaceHolder
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0}", "Hello, C#");
            Console.WriteLine("{0},{0}", "Hello, C#");
            Console.WriteLine("{1},{0}", "Hello", "C#");

        }
    }
}
