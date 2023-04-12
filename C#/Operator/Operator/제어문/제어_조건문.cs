using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator.제어문
{
    class 제어_조건문
    {
        public void 조건문()
        {
            int score = 50;

            if (score >= 60)
            {
                Console.WriteLine("합격");
            }
            else
            {
                Console.WriteLine("불합격");
            }

            //else if 문 
            int scoree = 40;

            if (scoree >= 90)
            {
                Console.WriteLine("A");
            }else if (scoree>=80){
                Console.WriteLine("B");
            }else if (scoree >= 70)
            {
                Console.WriteLine("C");
            }
            else
            {
                Console.WriteLine("F");
            }
        }
    }
}
