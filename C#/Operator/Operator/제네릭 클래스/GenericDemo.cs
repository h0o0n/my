using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator.제네릭_클래스
{
    class GenericDemo
    {

        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        List<Person> people = new List<Person>
        {
            new Person {Name = "홍유정"},
            new Person {Name = "유정호"},
            new Person {Name = "이유호"}
        };


        class Category
        {
            public int CategoryId { get; set; }
            public string CategoryName { get; set; }
        }

        public class Cup<T>
        {
            public T Content { get; set; }
        }

        class Pair<T, V>
        {
            public T First { get; set; }
            public V Second { get; set; }
            public Pair(T first, V second)
            {
                First = first;
                Second = second;
            }
        }

        public void main()
        {
            List<string> colors = new List<string>() { "Red", "Blue" };
            Console.WriteLine(colors);
            var categories = new List<Category>()
            {
                new Category(){CategoryId = 1, CategoryName ="좋은 책"},
                new Category(){CategoryId = 2, CategoryName ="좋은 강의"},
                new Category(){CategoryId = 3, CategoryName ="좋은 컴퓨터"}
            };

            var text = new Cup<string>();
            text.Content = "안녕하세요";

            Console.WriteLine(text.Content);

           /* foreach (var person in people)
            {
                Console.WriteLine(person.Name);
            };*/

            var person = new Cup<Person>();
            person.Content = new Person { Name = "Hong", Age = 21 };
            Console.WriteLine($"{person.Content.Name} - {person.Content.Age}");
            foreach (var category in categories)
            {
                Console.WriteLine($"{category.CategoryId},{category.CategoryName}");
            }

            //[A] string, bool 2개 형식 받기
            var my = new Pair<string, bool>("나는 ", true);
            Console.WriteLine($"{my.First} : {my.Second}");

            //[B] int, double 2개 형식 받기
            var tuple = new Pair<int, double>(1234, 3.14);
            Console.WriteLine($"{tuple.First}, {tuple.Second}");
        }
    }

       
}
