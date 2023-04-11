using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadLineNote
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("이름:_______\b\b\b\b\b\b");
            string name = Console.ReadLine();
            Console.WriteLine($"{name} 님 안녕하세요 ");
           

            //정수형 반환
            int x = Console.Read();                     //A 입력 
            Console.WriteLine(x);                       //아스키코드 예) A : 65
            Console.WriteLine(Convert.ToChar(x)); //실제문자출력 A 

            int i = 1234;
            Console.WriteLine(i.GetType());

            double d = 3.14;
            Console.WriteLine(d.GetType());

            char c = 'a';
            Console.WriteLine(c.GetType());

            object o = new object();
            Console.WriteLine(o);
            Console.WriteLine(o.GetType());
            */

            ReadLineDemo rld = new ReadLineDemo();
            rld.readLineDemo();

        }
    }
    class ReadLineDemo
    {
        public void readLineDemo()
        {
            Console.WriteLine("정수");
            String num = Console.ReadLine();
            int number = Convert.ToInt32(num);
            Console.WriteLine(number + number);
        }
    }

    class Calc
    {
        public void calc()
        {
            int number = 10;
            Console.WriteLine(Convert.ToString(number, 2).PadLeft(8,'0'));  //2진수로 표현하는데 앞을 0으로 채워준다.
            Console.WriteLine(Convert.ToString(10, 2));
            Console.WriteLine(Convert.ToInt32("1010",2));
        }
    }

    class Keyword
    {
        public void keyword()
        {
            var name = "RedPlus";           //var 키워드 : 암시적으로 형식화된 로컬 변수
            Console.WriteLine($"{name}");
            //var age = 21; == int age=21;
            var age = 21;
            Console.WriteLine(age.GetType());
            var version = 8.0;
            Console.WriteLine(version.GetType());
            var name1 = "Test";
            Console.WriteLine(name1.GetType());
        }
    }
}
