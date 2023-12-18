using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Dec18Console
{
    public class AllCollections
    {
        //ArrayList
        public static void ArrayListFuns()
        {
            ArrayList arr1 = new ArrayList();
            arr1.Add("iam prasuna");
            arr1.Add(3);
            arr1.Add(3.3);
            
            //why we call collections as non generic Ans....
            //non generic--- does not have any fixed datatype collection classes , It allows values of any datatype in same object(ar1), classs arrayList
            ArrayList arr2 = new ArrayList();
            arr2.Add("hello");
            arr2.Add("Good Morning");
            //to access and display
            //foreach(string onevalue in ar2 {}
            foreach (var item in arr2 ){ Console.WriteLine(item); }
            //to remove
            //arr2.Remove("hello");
            //arr2.RemoveAt(1);// 1 index vumber value will remove
            //arr2.RemoveRange(1, 4);//2,3,4,5 values will gone
            //arr2.Clear();// all gone

            //thesre are properties of collections
            int n1 = arr2.Capacity; Console.WriteLine(n1);
            int n2 = arr2.Count; Console.WriteLine(n2);
            arr2.Insert(1, "pra");//hello pra 
          //  arr2.InsertRange(1,ICollectionObje)
            bool b1 = arr2.Contains("hello");
            int n3 = arr2.IndexOf("pra"); Console.WriteLine(n3);
            //Collection v alues will take dynamic

        }
        public static void HashTableFuns()
        { Hashtable ht1= new Hashtable();
            //ht1.add(key, value)
            ht1.Add(1, "a");ht1.Add(2.4, 8);ht1.Add("k", "k");
            Hashtable ht2= new Hashtable();
            ht2.Add(1, "Prassu");ht2.Add(43, "gnana");
            ht2.Add(22, "tommy");ht2.Add(8, "jim");

            //to access all keys
            ICollection allkeys = ht2.Keys;
            foreach (var oneKey in allkeys) { Console.WriteLine(oneKey); }

            //to access values
            ICollection allvalues = ht2.Values;
            foreach (var oneValue in allkeys) { Console.WriteLine(oneValue); }
            //to access both 
            foreach (DictionaryEntry de in ht2) { Console.WriteLine("Key is " + de.Key); Console.WriteLine("Values is " + de.Value); }
            //to search by key
            bool b1 = ht2.ContainsKey("a"); Console.WriteLine(b1);   // to search by value
            bool b2 = ht2.ContainsValue(2); Console.WriteLine(b2);
            bool b3 = ht2.Contains(25);// pass key as parameter
            int n1 = ht2.Count;// returns number of keys
                               // ht2.CopyTo(array,arrayIndex) from ht2 to array 
            ht2.Remove(99);// by key as parameter 
        }

        public static void SortedListFuns()
        {
            SortedList sl1 = new SortedList();
            sl1.Add(1, "a");
            sl1.Add(44, "abc");
            sl1.Add(9, "xqs");
            // to display sl1 is sorted automatic , that never happens in hashtable
            ICollection c1 = sl1.Keys;
            foreach (var k1 in sl1.Keys) { Console.WriteLine("keys are " +k1); }
            ICollection c2 = sl1.Values;
            foreach (var k2 in c2) { Console.WriteLine("values are " +k2); }
            //to display key and value
            // to display key and value
            foreach (DictionaryEntry de in sl1) { Console.WriteLine(" key is {0} value is {1} ", de.Key, de.Value); }
            // search 
            bool b1 = sl1.Contains(1);//takes key 
            bool b2 = sl1.ContainsValue("abc");
            bool b3 = sl1.ContainsKey(33);
            int n1 = sl1.Capacity;
            int n2 = sl1.Count;
            sl1.RemoveAt(1);
        }

        public static void StackFuns()
        {
           Stack s1 = new Stack();
            s1.Push(1);s1.Push(2);s1.Push(3);
            object obj1 = s1.Pop();//returns value of removed
            object obj2 = s1.Peek();
            bool b1 = s1.Contains(33);
            //s1.CopyTo(array, int index);//from stack to array
           // s1.Clear();//all gone
        }
        public static void QuequeFuns()
        {Queue q1 = new Queue();
            q1.Enqueue(22);q1.Enqueue(23);q1.Enqueue(24);//to add
            //remove
            object obj1 = q1.Dequeue();//removes
            object obj2 = q1.Peek();//Without removing
            bool b1 = q1.Contains(45);
            

        }
    }
}
