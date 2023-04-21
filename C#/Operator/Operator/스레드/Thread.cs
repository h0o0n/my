using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Operator.스레드
{
    class Thread
    {

        public static void Hi() { Console.WriteLine("Hi"); }
        

        public void main()
        {
            lock (this) 
            {
                Parallel.For(0, 200_000, (i) => { Console.WriteLine(i); });
            }
            
        }
    }
}
