using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator.오버라이드
{
    class Parent
    {
        protected void Say() => Console.WriteLine("부모_안녕하세요.");
        protected void Run() => Console.WriteLine("부모_달리다.");
        public virtual void Walk() => Console.WriteLine("부모_걷다.");
        public virtual void Work() => Console.WriteLine("부모_프로그래머"); // 자식 클래스에서도 부모 메서드 그대로 사용가능 virtual
    }

    class Child : Parent
    {
        //오버라이드 자식에서 재정의 가능
        public new void Say() => Console.WriteLine("자식_안녕하세요.");
        public new void Run() => Console.WriteLine("자식_달리다");

        public override void Walk() => base.Walk(); //부모를 따라서 씀
        public override void Work() => Console.WriteLine("자식_프로그래머");



    }
    class OverrideDemo  
    {
        public void main()
        {
            //Parent parent = new Parent(); parent.Say();
            Child child = new Child(); 
            child.Say();
            child.Run();
            child.Walk();
            child.Work();
        }
    }
}
