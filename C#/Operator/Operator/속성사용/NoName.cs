using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator.속성사용
{
    class NoName
    {
        public void main()
        {
            var person = new { Name = "Red", Age = 21 }; //클래스를 만들지않고 익명형식
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
        }
        

    }
}
