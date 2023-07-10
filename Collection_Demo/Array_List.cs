using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Demo
{
    //its a non generic collection 
    // it is same as array except its size increase dynamically
    // it show the element of multiple data type
    public class Array_List
    {
        public void MyArray()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(99);
            arrayList.Add("rohya");
            arrayList.Add('P');
            arrayList.Add(" ");
            arrayList.Insert(0, 20);
            arrayList.Insert(2, "car");
            arrayList.Remove('P');
            arrayList.RemoveAt(0);
            Console.WriteLine(arrayList.Count);
            foreach (var i in arrayList)
            {
                Console.WriteLine(i);
            }
            arrayList.Insert(0, 20);

            //for (var i = 0; i < arrayList.Count; i++)
            //{
            //    Console.WriteLine(i);
            //    Console.WriteLine(arrayList[i]);
            //}
        }
    }
}
