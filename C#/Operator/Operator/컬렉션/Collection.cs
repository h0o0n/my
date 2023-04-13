using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator.컬렉션
{
    class Collection
    {
        public void collection()
        {
            int number = 1_234;
            Console.WriteLine(number);

            //[2]Array
            string[] colors = { "red", "green", "blue" };
            Console.WriteLine(colors[0]);
            Console.WriteLine(colors[1]);
            Console.WriteLine(colors[2]);
            Console.WriteLine(colors[10]); // 인덱스가 배열 범위 벗어난 에러     
            Array.Sort(colors);
            foreach(var color in colors){
                Console.WriteLine(color);
            }

            Array.Reverse(colors);
            foreach(var color in colors)
            {
                Console.WriteLine(color);
            }

        }
        
        public void collectionDemo()
        {
            Stack stack = new Stack();
            stack.Push(100);
            stack.Push(200);
            Console.WriteLine(stack.Pop()); 
            Console.WriteLine(stack.Pop()); 
        }

        public void queueDemo()
        {
            Queue queue = new Queue();
            queue.Enqueue(100);
            queue.Enqueue(200);

            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            
        }
    }
}
