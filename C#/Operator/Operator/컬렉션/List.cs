using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Operator.컬렉션
{
    class List
    {
        public void arrayList()
        {
            ArrayList list = new ArrayList();
            list.Add(100);
            list.Add(100);
            list.RemoveAt(1);
            list.Add(200);
            Console.WriteLine(list[0]);
            Console.WriteLine(list[1]);
            list.Insert(0, 50);

            foreach(int li in list)
            {
                Console.WriteLine(li);
            }

        }

        public void hashTable()
        {
            Hashtable hashtable = new Hashtable();
            hashtable[0] = "DotNetKorea";
            hashtable["NickName"] = "RedPlus";

            Console.WriteLine(hashtable[0]);
            Console.WriteLine(hashtable["NickName"]);
        }
    }
}
