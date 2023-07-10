using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Demo
{
    public class Dictionary_Demo
    {
        //its a generic collection it will store key value pair
        //define under system .collection.namespace
        //it is dynamic in nature
        //in dictionary the key can't be null but the value can n=be null
        //the key must be unique . to duplicate key are not allowed
        // we can store same data type of values
        public void Diction()
        {
            Dictionary<string,string> keyValuePairs = new Dictionary<string,string>();
            keyValuePairs.Add("1", "Rohya");

            keyValuePairs.Add("2", "Bike");
            keyValuePairs.Add("3", "Pratu");
            keyValuePairs.Add("4", "Kj");
            keyValuePairs.Add("5", "Rp");
            Console.WriteLine(keyValuePairs["3"]);
            keyValuePairs["2"] = "Dp";
            Console.WriteLine(keyValuePairs["2"]);
            keyValuePairs.Clear();
            Console.WriteLine("======================================");
            foreach (KeyValuePair<string,string> ele in keyValuePairs)
            {
                Console.WriteLine(ele.Key+":"+ ele.Value);

            }
            for(int i = 0; i < keyValuePairs.Count; i++)
            {
                var item = keyValuePairs.ElementAt(i);
                Console.WriteLine(item.Value);
            }

        }
    }
}
