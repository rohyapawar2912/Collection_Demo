using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Demo
{
    // List<T> Class represents the list of object whic can be accessed  with index
    public class List_Demo
    {
        // creating a list of integers
        List<int> list = new List<int>();
        public void Adding()
        {
            list.Add(11);
            list.Add(22);
            list.Add(33);    
            list.Add(44);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Count of list : " + list.Count);
            Console.WriteLine("Capacity of list : " + list.Capacity);
            list.Add(55);
            list.Add(66);
            list.Add(77);
            list.Add(88);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Capacity of list : " + list.Capacity);
            Console.WriteLine("Find Elements " + list.Contains(55));
            Console.WriteLine("Remove Element " + list.Remove(22));
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("==============================================");
            Console.WriteLine("Removing element in perticular position ");
            list.RemoveAt(4);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("================================================");
            Console.WriteLine("Reversing the order of list");
            list.Reverse();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("=================================================");
            Console.WriteLine("sorting the list");
            list.Add(8);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("==================================================");
            Console.WriteLine("list is cleared");
            list.Clear();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("==================================================");



        }

    }
}
