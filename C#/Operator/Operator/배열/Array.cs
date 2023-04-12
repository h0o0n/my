using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator.배열
{
    class Array
    {

        //배열(Array): 하나의 이름으로 같은 데이터 형식을 여러 개 보관해 놓는 그릇
        public void ArrayDemo()
        {
            string arr = "C#8";
            for (int i =0; i< arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        public void ArrayDemo2()
        {
            int[] numbers = new int[3];
            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine(numbers[0]);

            int[] numbers2 = new int[3] { 10, 20, 30 };

           
            for(int i = 0; i < numbers2.Length; i++)
            {
                Console.WriteLine(numbers2[i]);
            }
        }

        public void Array2Demo()
        {
            int[,] numbers = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            for(int i =0; i < numbers.GetLength(0); i++)
            {
                Console.WriteLine();
                for(int j=0; j<numbers.GetLength(1); j++)
                {
                    Console.Write($"{numbers[i,j]}\t");
                }
            }
        }
    }
}
