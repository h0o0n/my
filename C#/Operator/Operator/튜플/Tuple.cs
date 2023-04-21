using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator.튜플
{
    //튜플: 괄호 기호의 간단한 구문을 사용하여 하나 이상의 속성을 가지는 개체을 만드는 형식
    class Tuple
    {
        public void main()
        {
            var r = (12, 34, 56);
            Console.WriteLine(r.Item1);

            var fhd = (1920, 1080);
            Console.WriteLine(fhd.Item1);

            var uhd = (Width: 3840, Height: 2160);
            Console.WriteLine(uhd.Height);

            (ushort Width, ushort Height) hd = (1366, 768);
            Console.WriteLine(hd.Width);
            Console.WriteLine(hd.Width.GetType());

            var t1 = Tally1();
            Console.WriteLine($"a: {t1.Item1}, b:{t1.Item2}");
            var t2 = Tally2();
            Console.WriteLine($"Sum:{t2.Sum}, Count:{t2.Count}");

            var boy = (Name: "철수", IsStudent: true, OrderPrice : 1_000);
            Console.WriteLine($"{boy.Name}(초등학생 : {boy.IsStudent}-주문:{boy.OrderPrice:C0})");

            var t = ZeroZero();
            Console.WriteLine($"{t.Item1}.{t.Item2}");

            var (sum, count) = Tally();
            Console.WriteLine($"Sum:{sum},Count:{count}");
        }

        static(int Sum, int Count) Tally()
        {
            var r = (s: 12, c: 3);
            Console.WriteLine($"{r.s},{r.c}");
            return r;

        }

        static (int, int) Tally1()
        {
            var r = (12, 3);
            return r;

        }

        static (int Sum, int Count) Tally2() => (45, 6);

        static (int, int) ZeroZero() => default;
        

    }
}
