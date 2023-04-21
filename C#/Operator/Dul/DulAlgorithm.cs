using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dul
{
    public class Algorithm
    {
        public static int[] SelectionSort(int[] numbers)
        {
            int N = numbers.Length;

            for (int i = 0; i < N; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        int temp = numbers[i]; numbers[i] = numbers[j]; numbers[j] = temp;
                    }
                }
            }

            return numbers;
        }
    }
}
