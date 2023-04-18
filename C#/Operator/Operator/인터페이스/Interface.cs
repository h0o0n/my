using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator.인터페이스
{
    public interface ICarStandard //  인터페이스 클래스는 설계의 개념만
    {
        void Left();
    }
    abstract class KS               //  추상 클래스는 설계/ 구현 개념을 모두 
    {
        public abstract void Back();
        public void Fly() => Console.WriteLine("날다");
    }
    partial class MyCar : KS
    {
        public override void Back() => Console.WriteLine("후진");
    }
    partial class MyCar : KS
    {
        public void Right() => Console.WriteLine("우회전");
    }
    sealed class Car : MyCar, ICarStandard
    {
        public void Left() => Console.WriteLine("좌회전");
        public void Run() => Console.WriteLine("직진");
    }

    //class SpyCar : Car{ }

    class Interface
    {
        public void main() 
        {
            Car car = new Car(); 
            car.Run(); car.Right(); car.Back(); car.Left(); car.Fly();
            //SpyCar spy = new SpyCar(); spy.Run(); //SpyCar는 Car 클래스를 상속받아서 그대로 받아쓰는 개념
        }

    }
}
