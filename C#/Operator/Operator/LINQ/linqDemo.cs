using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator.LINQ
{
    class linqDemo
    {
        public void linqdemo()
        {
            int[] numbers = { 1, 2, 3 };

            int sum = 0;
            for(int i =0; i<numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);
        }
        
        public void linqdemo2()
        {
            int[] number = { 1,2,3 };
            Console.WriteLine(number.Sum()); // Linq 의 기능이다. 배열의 . 을 찍으면 확인 할 수 있는 기능
            Console.WriteLine(number.Max());

            int[] numbers = { 1, 2, 3, 4, 5 };

            Console.WriteLine(numbers.Count());
            Console.WriteLine(numbers.Average());

            List<int> num = numbers.Where(n => n % 2 == 0).ToList(); //람다식으로 표현가능하다.
            foreach(int n in num)
            {
                Console.WriteLine(n);
            }
        }

        public void linqdemo3()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            numbers.Max();
            List<int> num = numbers.Where(n => n % 2 == 0).ToList(); //
            int a = numbers.Where(n => n % 2 == 0).Max();

            Console.WriteLine(a);

            foreach(int n in num)
            {
                Console.WriteLine(n);
            }

        }

        public void linqdemo4()
        {
            List<String> techs = new List<string>();
            techs.Add("C#");
            techs.Add("java");
            techs.Add("vue22");

            techs.OrderByDescending(t => t.Length > 1);
            foreach(string tech in techs)
            {
                Console.WriteLine(tech);
            }
            

        }
    }
}
