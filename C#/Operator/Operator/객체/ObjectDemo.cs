using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator.객체
{
    public class Cars
    { 
        public void Go() => Console.WriteLine("차가 출발합니다.");
        public override string ToString() => "My Car";

    }

    public class ObjectTest
    {
        Cars ca = new Cars();
    }
}
