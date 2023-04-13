using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator.알고리즘
{
    class 알고리즘
    {
        public void algo()
        {
            int[] data = { 3, 2, 1, 5, 4 };

            data.OrderBy(d => d);
            data.OrderByDescending(x => x);
            
            foreach(int d in data.OrderByDescending(x => x))
            {
                Console.WriteLine(d);
            }

            for(int i = 0; i <data.Length; i++)
            {
                for(int j=i+1; j<data.Length; j++)
                {
                    if(data[j] > data[i])
                    {
                        int temp = data[i];
                        data[i] = data[j];
                        data[j] = temp;
                    }
                }
            }

            foreach(int d in data)
            {
                Console.WriteLine(d);
            }
           
        }
    }
}
