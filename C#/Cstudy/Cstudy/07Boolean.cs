using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cstudy
{
    class Program
    {
        static void Main(string[] args)
        {
            //논리 자료형: 참(True) 또는 거짓(False) 값 저장
            bool bln = true;
            Console.WriteLine(bln);

            bool bln2 = false;
            Console.WriteLine(bln2);

            Boolean isFalse = false;
            Console.WriteLine(isFalse);
            //bool = boolean 내부적으로 같은 의미

            Const con1 = new Const();
            con1.Constant();

        }
    }
}
