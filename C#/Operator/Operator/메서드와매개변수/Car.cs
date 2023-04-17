using System;
namespace Operator.메서드와매개변수
{
    class Car
    {
        public void Map(params string[] title)
        {
            foreach(var t in title)
            {
                Console.WriteLine(t);
            }
        }

    }
}
