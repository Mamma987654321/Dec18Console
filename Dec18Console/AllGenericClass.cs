using System;
using System.Collections.Generic;// Stronglry Typed(fixed data type) classes
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec18Console
{
    public class AllGenericClass
    {
        public static void ListFuns()
        {
            List<int> list1 = new List<int>(); list1.Add(1);
            List<string> list2 = new List<string>();list2.Add("prassu");
            list2.Add("Jerry"); list2.Add("jacky"); list2.Add("pank");

            foreach(var one in list2 ) { } foreach(string one in list2 ) { }
            int n1 = list2.Capacity; int n2 = list2.Count;//pls check
            list2.Remove("prassu");list2.RemoveAt(1);list2.Clear();
            //int n3 = list2.RemoveAll("hello");

            //Search
            bool b1 = list2.Contains("prassu");
            Console.WriteLine(b1);
            list2.Insert(2, "Kimpy");
            //to view the index
            int n3 = list2.IndexOf("prassu");
            Console.WriteLine(n3);



        }
        public static void SortedListFuns()

        {

            SortedList<int, string> sl1 = new SortedList<int, string>();
            sl1.Add(71, "abc");
            sl1.Add(3, "pqr");
            sl1.Remove(2);
            sl1.Clear();
            int n1 = sl1.Count;
            int n2 = sl1.IndexOfKey(71);
            int n3 = sl1.Capacity; //default how many values
            ICollection<int> c1 = sl1.Keys;
           // ICollection<int> c1 = sl1.Values; //Wrong statement
           ICollection<string> c2 = sl1.Values;
            foreach (string s1 in c2) { }
            foreach(var v1 in c1) { }

          //  here cannot use dictionary entry , bcz it is NonSerializedAttribute generic class
        }
        public static void DictionaryFuns()
        {
            Dictionary<int, int> d1 = new Dictionary<int, int>();
            d1.Add(1, 2);d1.Add(2, 3);d1.Add(5, 7); d1.Add(55, 73);
            // to access
            ICollection<int> c1 = d1.Keys; foreach (var v1 in c1) { }
            ICollection<int> c2 = d1.Values;foreach (var v2 in c2) { }
            //to search 
            bool b1 = d1.ContainsKey(1);
            bool b2 = d1.Remove(1);//d1.Remove(1);
           // d1.Clear();
        }
        public static void StackAndQuequeFuns()
        {
            Stack<int> stack = new Stack<int>();
            stack.Pop();stack.Push(2);
            int n1 = stack.Peek();
            int n2 = stack.Count;

            Queue<int> q = new Queue<int>();
            q.Enqueue(10); q.Dequeue();
            int n = q.Peek();int n3 = q.Count;
            bool b1 = q.Contains(10);

      }
        public static void BothIterators()
        {//List class is Implenting IEnumarator Interface so Method of GetEnumerator()
            //Generic 
            List<int> allYears = new List<int>();
            allYears.Add(1990);
            allYears.Add(2001);

            IEnumerable<int> el = allYears;
            foreach (int x in el) { Console.WriteLine(x); }
            IEnumerator<int> iter = allYears.GetEnumerator();
            while(iter.MoveNext())
            {
                Console.WriteLine(iter.Current.ToString());
            }
        }
    }
}
