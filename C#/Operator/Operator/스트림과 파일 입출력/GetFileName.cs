using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Operator.스트림과_파일_입출력
{
    internal class GetFileName
    {
        public void main()
        {
            string dir = "C:\\my\\C#\\basket.txt";
            string fullName = String.Empty;
            string name = "";
            string ext = name;

            fullName = dir.Substring(dir.LastIndexOf('\\') + 1);
            name = fullName.Substring(fullName.LastIndexOf("."));
            ext = fullName.Substring(fullName.LastIndexOf(".") + 1);

            Console.WriteLine(  $"전체파일 이름: {fullName}");
            Console.WriteLine(  $"파일 이름: {name}");
            Console.WriteLine(  $"확장자:{ext}");
        }

        public void main2()
        {
            string data =
                "안녕하세요\r\n반갑습니다." + Environment.NewLine + "또 만나요.";

            StreamWriter sw = new StreamWriter("C:\\Temp\\Test.txt");

            sw.WriteLine( data );

            sw.Close();

            sw.Dispose();
        }

        public void main3()
        {
            string dir = "C:\\";

            if (Directory.Exists(dir))
            {
                Console.WriteLine("[1] C 드라이브의 모든 폴더 목록 출력");
                foreach(string folder in Directory.GetDirectories(dir))
                {
                    Console.WriteLine(  $"{folder}");
                }
            }

        }

        //텍스트 데이터를 컬렉션 데이터로 가져오기
        public class Record
        {
            public string name { get; set; }
            public string PhoneNumber { get; set; }
            public string BirthDate { get; set; }
            public string AuthCode { get; set; }
        }

        public void main4()
        {
            string[] lines = 
            System.IO.File.ReadAllLines(
                @"C:\Temp\test.txt",Encoding.UTF8);

            foreach(var line in lines)
            {
                Console.WriteLine(  $"{line}");
            }

            List<Record> records = new List<Record>();
            foreach(var line in lines)
            {
                string[] splitData = line.Split(',');
                records.Add(
                    new Record
                {
                    name = splitData[0],
                    PhoneNumber = splitData[1],
                    BirthDate = splitData[2],
                    AuthCode = splitData[3]
                });

            }

            Console.WriteLine(records[0].name ?? "데이터가 없습니다.");
        }
    }
}
