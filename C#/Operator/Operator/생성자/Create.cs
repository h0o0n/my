using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator.생성자
{
    class Create
    {
        
    }

    public class Car
    {
        public string name;
       
        public Car() : this("기본자동차")                    //생성자 포워딩
        {
            Console.WriteLine("자동차 개체를 생성합니다. 조립, 시동걸기");
        }
        /* public Car(string name)
         {
             this.name = name;
         }*/

        public Car(string name) => this.name = name; //식 본문 생성자 

        public void Go() => Console.WriteLine($"{name}가 출발합니다.");
    }
    class Program
    {
        public void main1()
        {
            (new Car()).Go();
            
            (new Car("장난감자동차")).Go();
        }
    }
}
