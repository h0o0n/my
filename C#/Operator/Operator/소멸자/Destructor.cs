using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator.소멸자
{

    class Car
    {
        private string _name;
        public Car() : this("기본자동차") { }
        public Car(string name)
        {
            this._name = name;
            Console.WriteLine($"[1] {this._name} 생성, 조립, 시동");
        }
        public void Go() => Console.WriteLine($"[2] {this._name} 달리다.");
        ~Car() // 소멸자
        {
            Console.WriteLine($"[3] {this._name} 소멸");
        }

    }
    class Destructor
    {
        public void main1()
        {
            Car car = new Car();  car.Go();
            Car car2 = new Car("캠핑카"); car2.Go();  //last in first out 
                             // 실행
                             // 소멸
        }
    }
}
