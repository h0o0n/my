using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator.대리자
{
    class Delegate
    {
        static void GoForward() => Console.WriteLine("직진");
        static void GoLeft() => Console.WriteLine("좌회전");
/*        static void GoRight() => Console.WriteLine("우회전");*/

        static void GoFast() => Console.WriteLine("과속");

        delegate void CarDriver(); // 대리자 형식 생성

        public void main()
        {
            GoForward();    //[1] 내가 직접 운전 
            CarDriver goHome = new CarDriver(GoForward); //[2] 대리자delegate 사용 대리 

            goHome += GoLeft;  goHome += GoFast; goHome -= GoFast;
            goHome += delegate () { Console.WriteLine("우회전"); }; //[3] 무명 메서드 / 익명 함수 이름이 없음
            goHome += () => Console.WriteLine("후진"); // [4] 람다식으로 대체 가능 
            goHome();

            //내장된 대리자 형식을 통해서 직접 대리자 개체 생성 : Func<T>, Action<T>, Predicate<T>. ...
            Action driver = GoForward;
            driver += GoLeft;
            driver += () => Console.WriteLine("후진");
            driver();

            Action go = () => Console.WriteLine("운전");
            go();

            RunLamda(() => Console.WriteLine("매개 변수로 람다식(함수이름, 함수메서드) 전달"));
/*
            goHome.Invoke();
            goHome();*/
        }
        static void RunLamda(Action action) => action();
    }
}
