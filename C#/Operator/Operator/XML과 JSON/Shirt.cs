using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Operator.XML과_JSON
{

    public class Shirt
    {
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public List<string> Sizes { get; set; }
    }

    internal class Shirts
    {

        public void main1()
        {
            Shirt shirt1 = new Shirt
            {
                Name = "Hoon Shirt",
                Created = new DateTime(2020, 01, 01),
                Sizes = new List<string> { "Small" }
            };

            string json1 = JsonConvert.SerializeObject(shirt1, Formatting.Indented);
            Console.WriteLine(json1);

            string json2 = @"{
                'Name':'Black Shirt',
                'Created':'2020-12-31T00:00:00',
                'Sizes':['Large','Small']
            }";

            Shirt shirt2 = JsonConvert.DeserializeObject<Shirt>(json2);
            Console.WriteLine(  $"{shirt2.Name}-{shirt2.Created}");
        }
    }

   
    
}
