using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Operator.XML과_JSON
{
    internal class XElementDemo
    {
        public void main()
        {
            XElement category = new XElement("Menus",
                new XElement("Menu", "책"),
                new XElement("Menu", "강의"),
                new XElement("Menu", "컴퓨터")
                );
            Console.WriteLine(category);

            XElement newCategory = new XElement("Menus", 
                from node in category.Elements()
                where node.Value.ToString().Length >= 2
                select node
                );

            Console.WriteLine(newCategory);
        }
    }
}
