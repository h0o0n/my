using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{

    //비동기 방식의 메서드

    public class Restaurant
    {
        public void MakeFood()
        {
            Console.WriteLine($"요리 시작");

            Console.WriteLine($"요리 종료");
        }
        
        public async Task<Rice> MakeRiceAsync()
        {
            Console.WriteLine("밥 생성중...");
            await Task.Delay(1001);
            return new Rice();
        }

        public async Task<Soup> MakeSoupAsync()
        {
            Console.WriteLine("국 생성중...");
            await Task.Delay(10);
            return new Soup();
        }

        public class Rice
        {
            public Rice()
            {
                Console.WriteLine("밥 완료");
            }
        }

        public class Soup
        {
            public Soup()
            {
                Console.WriteLine("국 완료");
            }      
        }
    }
    class Program
    {
        static async Task Main()
        {
            
            Restaurant res = new Restaurant();

            res.MakeFood();
            await res.MakeRiceAsync();
            await res.MakeSoupAsync();

        }
    }
}
