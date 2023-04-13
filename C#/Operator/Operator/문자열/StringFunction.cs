using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator.문자열
{
    class StringFunction
    {
        public void stringFunction()
        {
            string message = "hello World";

            Console.WriteLine(message.ToUpper()); //대문자변환
            Console.WriteLine(message.ToLower()); //소문자변환

            Console.WriteLine(message.Replace("hello", "안녕하세요, ").Replace("World", "자바입니다."));
        }

        public void stringClass()
        {
            String s1 = "안녕하세요."; //String 클래스
            string s2 = "반갑습니다."; //string 키워드

            Console.WriteLine($"{s1} {s2}");
        }

        public void StringConcat()
        {
            string s1 = "안녕" + "하세요";
            string s2 = String.Concat("반갑", "습니다.");
            Console.WriteLine($"{s1} {s2}");
        }

        public void StringLength() //문자열 길이 확인하기
        {
            string s1 = "Hello";
            string s2 = "안녕하세요";
            Console.WriteLine($"{s1.Length} {s2.Length}");
        }

        public void ToCharArray() //메서드로 문자열을 문자 배열로 변환하기
        {
            string s = "안녕하세요";
            char[] ch = s.ToCharArray();
            for (int i = 0; i < ch.Length; i++)
            {
                Console.WriteLine(ch[i]);
            }
            Console.WriteLine(ch);
        }

        public void StringDisplay() // 문자열 묶는 3가지 표현 방법 정리
        {
            var DisplayName = "";
            var firstName = "자바";
            var lastName = "김";

            DisplayName = "이름 : " + lastName + firstName;
            Console.WriteLine(DisplayName) ;

            DisplayName = string.Format("이름 : {0}{1}",lastName, firstName);
            Console.WriteLine(DisplayName);

            //추천하는 방법
            DisplayName = $"이름 : {lastName}{firstName}";
            Console.WriteLine(DisplayName);
        }

        //[?] 문자열 비교하는 2가지 방법 정리
        public void StringEquals()
        {
            string userName = "RedPlus";
            string userNameInput = "redplus";

            if (userName.ToLower() == userNameInput)
            {
                Console.WriteLine("같습니다.");
            }

            if(string.Equals(userName, userNameInput,
                StringComparison.InvariantCultureIgnoreCase)) // 대소문자 구분하지 않는 방법 중 하나 
            {
                Console.WriteLine("같습니다.");
            }
        }

        //[?] 문자열 값 비교 : 대소문자 비교
        public void StringEqual()
        {
            string s1 = "Gilbut";
            string s2 = "gilbut";
            if (s1 == s2)
            {
                Console.WriteLine("같습니다.");
            }
            
        }
    }
}
