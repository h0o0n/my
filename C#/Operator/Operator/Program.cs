using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Operator.제어문;
using Operator.반복문제어;
using Operator.함수;
using Operator.구조체;
using Operator.열거형;
using Operator.클래스;
using Operator.알고리즘;
using Operator.객체;
using Operator.생성자;
using Operator.메서드와매개변수;
using Operator.속성사용;
using Operator.대리자;
using Operator.이벤트와_이벤트처리기;
using Operator.상속;

namespace Operator
{
    class Program
    {
        public void ada(){
            Operator.객체.Cars ar = new Cars();
            ar.Go();
          }

        static void Main(string[] args)
        {
            /*var num = 1000;
            var number = num + 1234;
            Console.WriteLine(number);

            //연산자(Operator): 더하기,빼기와 같은 연산을 진행하는 키워드
            //식(Expression)
            //구문(Statement)

            var value = 0;
            value = 8;
            Console.WriteLine(value = +value);
            Console.WriteLine(value = -value);
            Console.WriteLine(value = -value);

            var number = 3.14;
            Console.WriteLine(number);

            Console.WriteLine("Hello, "  + "World");
            Console.WriteLine("123"  + "456");
            Console.WriteLine("123" + true);*/

            /*switch문 sh = new switch문();
            sh.스위치1();*/

            /*ForDescription fd = new ForDescription();
            fd.ForSumEven();*/

            /*BreakDemo bd = new BreakDemo();
            bd.Break();*/

            /*GoToDemo gtd = new GoToDemo();
            gtd.GoToDemo1();*/

            /*FunctionNote nt = new FunctionNote();
            nt.functionNote();*/

            /*StructureType st = new StructureType();
            st.Structure();*/

            /*EnumerationTextbook etb = new EnumerationTextbook();
            *//*  etb.Enumeration();*//*
            etb.Enum1();
*/
            /*ClassDemo cd = new ClassDemo();
            cd.classDemo();*/

            /*Operator.알고리즘.알고리즘 ag = new Operator.알고리즘.알고리즘();
            ag.algo();*/

            Operator.객체.Cars obj = new Operator.객체.Cars();
            /*Console.WriteLine(obj);
            obj.Go();*/

            /* Operator.소멸자.Destructor des = new 소멸자.Destructor();
             des.main1();*/

            /*Operator.메서드와매개변수.MethodAndParameter map = new MethodAndParameter();
            map.main();*/

            /*Operator.속성사용.Property pro = new Property();
            pro.main();*/

            /*Operator.대리자.Delegate dg = new Operator.대리자.Delegate();
            dg.main();*/

            /*Operator.이벤트와_이벤트처리기.Event events = new Operator.이벤트와_이벤트처리기.Event();
            events.main();*/

            /*Operator.상속.InheritanceNote IN = new InheritanceNote();
            IN.main();*/

            /*Operator.오버라이드.OverrideDemo od = new 오버라이드.OverrideDemo();
            od.main();*/

            /*Operator.인터페이스.Interface it = new 인터페이스.Interface();
            it.main();*/

            /*Operator.특성과리플렉션.AttributeDemo abd = new 특성과리플렉션.AttributeDemo();
            abd.main();*/

            /*Operator.제네릭_클래스.GenericDemo gd = new 제네릭_클래스.GenericDemo();
            gd.main();*/

            Operator.확장메서드.ExtensionMethod em = new 확장메서드.ExtensionMethod();
            em.main();
        }
        
    }
}
