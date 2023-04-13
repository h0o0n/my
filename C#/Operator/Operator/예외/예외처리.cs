using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator.예외
{
    class 예외처리
    {
        public void TryCatch()
        {
            try
            {
                int[] arr = new int[2];
                arr[100] = 1234; //예외 에러 발생
            }
            catch(Exception ex) // ex 변수에는 예외에 대한 상세 정보가 담김
            {
                Console.WriteLine($"{ex}에러가 발생했습니다.");
                //Console.WriteLine("에러가 발생했습니다.");
            }
        }

        public void FormatExceptionDemo()
        {
            string inputNumber = "3.14";
            int number = 0;

            try
            {
                number = Convert.ToInt32(inputNumber);
                Console.WriteLine($"입력한 값 : {number }");
            }
            catch(FormatException fe)
            {
                Console.WriteLine($"에러 발생 : {fe.Message}");
                Console.WriteLine($"{inputNumber}은 정수여야 합니다.");
            }
        }

        public void TryCatchFinallyDemo4()
        {
            int x = 5;
            int y = 0;
            int r;

            try // 에러가 발생할 만한 코드를 try 영역안에 작성 
            {
                r = x / y;
                Console.WriteLine($"{x}/ {y} = {r}");
            }
            catch(Exception ex)  //catch 영역에서 에러 발생시 에러 구문 확인
            {
                Console.WriteLine($"예외 발생 : {ex.Message}");
            }
            finally 
            {
                Console.WriteLine("프로그램을 종료합니다.");
            }
        }
    }
}
