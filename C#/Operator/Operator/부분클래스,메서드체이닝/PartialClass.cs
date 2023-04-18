using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator.부분클래스_메서드체이닝
{
    class PartialClass
    {

        public void main()
        {
            var hello = new Hello();
            hello.Hi();
            hello.Bye();
        }
    }
}
