using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator.상속
{

    public enum CarType { 전기, 내연기관 }

    public abstract class CarBase
    {       
        public abstract void Left(); // 매개변수도 없고 반환도없음 => 표준 으로 구현해야함(강제성) => 인터페이스 
        public void Back() => Console.WriteLine("후진하다.");
        protected string LeftMessage { get; private set; } = "좌회전하다.";
    }
    public class Car : CarBase
    {
        public CarType Style { get; private set; }
        public void Go() => Console.WriteLine("가다");

        public override void Left()
        {
            Console.WriteLine(base.LeftMessage);
        }
        public Car(CarType carType)
        {
            this.Style = carType;
        }
    }

    public class Benz : Car // Sub: Base
    {
        public Benz() : this(CarType.내연기관) { }
        public Benz(CarType carType) : base(carType) { }
    }

    public class Tesla : Car // Child: Parent, Child extends Parent
    {
        public Tesla() : this(CarType.전기)
        {

        }
        public Tesla(CarType carType) : base(carType)
        {

        }
    }

    public class Future : Car
    {
        public Future() : this(CarType.전기)
        {

        }
        public Future(CarType carType) : base(carType) { }
        public new void Go()
        {
            base.Go(); Console.WriteLine("날다.");
        }
    }

    public class InheritanceNote
    {
        public void main()
        {
            Benz benz = new Benz(); benz.Go(); Console.WriteLine($"{benz.Style}");
            Tesla tesla = new Tesla(); tesla.Go(); tesla.Left(); Console.WriteLine($"{tesla.Style}");
            Future future = new Future(); future.Go();
        }
    }
}
