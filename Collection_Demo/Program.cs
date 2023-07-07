using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Demo
{
    public class Program
    {
        // Cllectionis is a class that means we can create an object
        //can be create or decleared instace of a class , so we can add a data in collectin
        //collectin types - are designed to store , manage similar data
        //we can used to adding , remove , find and sorting data in collection
        //two types of collection - Generic and Non-Generic 
        //Non-generic - arrayList , Hashtable, sortedlist, stack and Queue
        //Generic - List ,dictionary,Sortedlist,stack and queue
        static void Main(string[] args)
        {
            List_Demo list = new List_Demo();
            list.Adding();
            Console.ReadLine();
        }
    }
}
