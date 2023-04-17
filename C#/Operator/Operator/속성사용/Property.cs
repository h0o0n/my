using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator.속성사용
{
    class Property
    {
        public void main()
        {
            Car car = new Car();
            car.Name = "장난감 자동차";
            Console.WriteLine(car.Name);

            Car car2 = new Car() { Name = "장난감 자동차2" }; //선언과 동시에  초기화 시켜줄 수 있다.
            Console.WriteLine(car2.Name);

            Console.WriteLine($"{nameof(car.Name)} : {car.Name}");
            Console.WriteLine($"{nameof(car2.Name)} : {car2.Name}");

        }
    }

    class Car
    {
 
        public string Name
        {
            get; set;
        }
    }


}
