using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Foo;

namespace Foo
{
    public class Car
    {
        public void Go() => Console.WriteLine("Foo.Car 자동차가 달립니다.");
    }
}
namespace Operator.네임스페이스
{
    class NameSpace
    {   
        //클래스 이름 충돌 방지 목적
        public void NameSpaceDemo()
        {
            Console.WriteLine("네임스페이스");
            Car car = new Car();
            car.Go();
        }
    }
}
