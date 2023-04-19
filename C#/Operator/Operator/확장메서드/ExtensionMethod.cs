using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator.확장메서드
{
    static class StringExtension
    {
        public static string Ten(this String message) => message.Substring(0, 10);

        public static string Five(this String message) => message.Substring(0, 5);
        public static string AddElipsis(this String message) => message+ "...";
        public static string AddElipsis(this String message,string elipsis) => $"{message}{elipsis}";


    }

    class ExtensionMethod
    {
        public void main()
        {
            string message = "안녕하세요. 반갑습니다. 또 만나요. ";
            Console.WriteLine(message.Five());
            Console.WriteLine(message.Ten().Five().AddElipsis("_______"));
        }
    }
}
