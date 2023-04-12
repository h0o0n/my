using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator.제어문
{
    class while문
    {
        public void while_1()
        {
            int count = 0; //초기식
            while(count< 3)
            {
                Console.WriteLine("Hello");
                count++;
            }
        }

        public void while_2()
        {
            int i = 1;
            while (i <= 5)
            {
                Console.WriteLine("카운트: {0}", i);
                i++;
            }
        }

        public void while_3()
        {
            //초기값을 감소시켜서 반복시키기
            int i = 5;  
            while (i >0)
            {
                Console.WriteLine("카운트: {0}", i);
                i--;
            }
        }
        
        public void while_4()
        {
            //while 문을 사용하여 1부터 100까지의 합을 구하는 프로그램
            const int N = 100;
            int i = 1;
            int sum = 0;
            while (i <= 100)
            {
                sum +=  i;
                Console.WriteLine($"0부터 {i} 까지의 합 = {sum}") ;
                i++;
            }
        }

        public void do_while()
        {
            int count = 0;
            do
            {
                Console.WriteLine("안녕하세요.");
                count++;
            } while (count < 3);
        }

        public void do_while2()
        {
            int sum = 0;
            int i = 1;
            do
            {
                sum += i;
                i++;
            } while (i <= 5 );
            Console.WriteLine($"합계 :  {0} ",sum);
        }

        public void do_while3()
        {
            int i = 1; // 초기식
            int sum = 0;
            do
            {
                if (i % 3 == 0 && i % 4 == 0)
                {
                    Console.WriteLine($"3의 배수이고 4의 배수인 수 : {i}");
                    sum += i;
                }
                i++;
            } while (i <= 100);
            Console.WriteLine($"{sum}");
        }

        public void 배열()
        {
            string[] names = { "C#", "ASP.NET" };
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
        }

        public void 배열2()
        {
            string str = "ABC123";
            foreach (char c in str)
            {
                Console.WriteLine(c);
            }
        }
    }
}

