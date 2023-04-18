    #define RELEASE

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Reflection;

namespace Operator.특성과리플렉션
{
    public class LuxuryAttribute : Attribute { public LuxuryAttribute() => Console.WriteLine("럭셔리!"); }

    //[LuxuryAttribute]
    [Luxury]
    class Car
    {
        //Annotation 어노테이션
        /*[Obsolete("다음 버전에 제거될 예정이니 Auto()를 사용하세요")]
        public void Manual() => Console.WriteLine("수동 운전");*/
        public void Auto() => Console.WriteLine("자동 운전");
        [Conditional("DEBUG")] public void Test() => Console.WriteLine("테스트 운전");
        [Conditional("RELEASE")] public void Test2() => Console.WriteLine("테스트 운전");


    }
    class AttributeDemo
    {
        public void main()
        {
            Car car = new Car();
            Attribute.GetCustomAttributes(typeof(Car));
            typeof(Car).GetCustomAttributes(false);
            car.Test(); car.Test2();
            car.Auto();
            car.Auto();
            //리플렉션
            var carType = (new Car());
            Type myCar = (new Car()).GetType();
            Console.WriteLine(myCar);
            MethodInfo info = myCar.GetMethod("Auto"); 
            info.Invoke(carType,null);
        }
    }
}
