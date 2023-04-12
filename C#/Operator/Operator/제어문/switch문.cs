using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator.제어문
{
    class switch문
    {
        public void 스위치()
        {
            //선택문(switch 문) : switch문 과 case 그리고 default 키워드를 사용하여 다양한 조건 처리
            var number = 2;

            switch (number)
            {
                case 1:
                    Console.WriteLine("1번");
                    break;
                case 2:
                    Console.WriteLine("2번");
                    break;
            }

            
        }

        public void 스위치1()
        {
            Console.WriteLine("정수를 입력하세요");
            int answer = Convert.ToInt32(Console.ReadLine());


            //선택문
            switch (answer)
            {
                case 1:
                    Console.WriteLine("1번");
                    break;
                case 2:
                    Console.WriteLine("2번");
                    break;
                case 3:
                    Console.WriteLine("3번");
                    break;
                default:
                    Console.WriteLine("틀렸습니다.");
                    break;
            }
        }

        enum Color
        {
            Red = 10,
            Green,
            Blue = 20
        }

        public void switchDescription()

        {
            var color = Color.Green;
            switch (color)
            {
                case Color.Red:
                    break;
                case Color.Green:
                    break;
                case Color.Blue:
                    break;
                default:
                    break;
            }
        }
    }
}
