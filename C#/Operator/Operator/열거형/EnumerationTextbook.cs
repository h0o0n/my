using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator.열거형
{
    class EnumerationTextbook
    { 
        public void Enumeration()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Red");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine($"Magenta / {nameof(ConsoleColor.White)}");
            Console.ResetColor() ;

            //열거형 이름은 switch 문으로 파악할 수 있다.

        }

        enum Animal { Mouse, Cow, Tiger }
        public void Enum1()
        {
            Animal animal = Animal.Tiger;
            Console.WriteLine(animal);
            Console.WriteLine((int)animal);
            Console.WriteLine(nameof(Animal.Tiger));


            switch (animal)
            {
                case Animal.Mouse:
                    break;
                case Animal.Cow:
                    break;
                case Animal.Tiger:
                    break;
                default:
                    break;
            }
        }
            
     }
    
}
