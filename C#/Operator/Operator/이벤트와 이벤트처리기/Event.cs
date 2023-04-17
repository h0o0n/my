using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator.이벤트와_이벤트처리기
{
    // 게시자(Publisher)
    class Car
    {
        private int _fuelGuage;

        private int FuelGuage
        {
            get { return _fuelGuage; }
            set 
            { 
                _fuelGuage = value;
                OnFuelEmptyReached();
            }
        }

        public Car()
        {
            _fuelGuage = 25;
        }

        public void Go()
        {
            Console.WriteLine("운전");
            FuelGuage -= 5;
        }

        public delegate void FuelEmptyNotification();
        public event FuelEmptyNotification FuelEmptyReached;
        public void OnFuelEmptyReached()
        {
            Console.WriteLine($"연료상태 : {_fuelGuage}%");
            if (_fuelGuage < 20)
            {
                if (FuelEmptyReached != null)
                {
                    FuelEmptyReached?.Invoke();
                }
            }
        }
    }

    // 이벤트 구독자(Subscriber)
    class Event
    {
        public void main() {
            Car car = new Car();
            car.FuelEmptyReached += Car_FuelEmptyReached;
            car.FuelEmptyReached -= Car_FuelEmptyReached;

            car.FuelEmptyReached += () =>
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("연료부족!!!");
                Console.ResetColor();
            }; 
            car.Go();
            car.Go();

            //car.OnFuelEmptyReached();
        }

        // 이벤트 처리기(핸들러 ): Handler
        private void Car_FuelEmptyReached() => Console.WriteLine("연료 부족"); 
    }
}
