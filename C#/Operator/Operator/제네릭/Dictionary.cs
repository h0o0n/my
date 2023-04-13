using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator.제네릭
{
    class Dictionary
    {
        public void dictionary()        //키와 값을 쌍으로 관리 HashMap 과 비슷 .
        {
            Dictionary<int, string> todos = new Dictionary<int, string>();
            todos.Add(1, "C#");
            todos.Add(2, "ASP.NET");
            todos.Add(3, "Java");

            String result;

            for(int i=1; i<=todos.Count; i++)
            {
                todos.TryGetValue(i, out result);
                Console.WriteLine(result);

            }
        }
    }
}
