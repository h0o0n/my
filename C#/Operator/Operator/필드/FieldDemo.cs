using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator.필드
{
    public class Say
    {
        private string message = "반갑습니다."; // 필드
        public void Hi()
        {
            Console.WriteLine(this.message);
        }

    }
    class FieldDemo
    {
        private static string message = "안녕하세요";
        public static void Hi() => Console.WriteLine(message);
        public void main1() {
            int number = 1_234;
            Console.WriteLine(number);
            Console.WriteLine(message);
            Hi();
            Say say = new Say();
            say.Hi();
        }
        
    }

    public class Person
    {
        private string name = "기훈";
        private const int m_age = 21;
        private readonly string NickName = "DotNet";
        private String[] websties = {"닷넷 코리아", " 비주얼 아카데미 "};

        public void Show() => Console.WriteLine($"이름 : {name} \b 나이: {m_age} \b 별명: {NickName} \b 웹사이트: {string.Join(",",websties)}");
        
    }
}
