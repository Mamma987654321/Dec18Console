using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec18Console
{
    internal class Program
    {
        static void SingleArray()
        {
            int[] array = { 1, 2, 4, 5};
            int avg = 0;
            for(int i =0; i<4; i++)
            {
                avg += array[i];
                avg = avg / 4;
                Console.WriteLine("average of numbers " +avg);
            }
        }
        static void RectangularArray() {
            int t, j;
            int[,] array = new int[3, 4];
            for(t=0; t<3; t++)
            {
                for(j=0; j<4; j++)
                {
                    array[t, j] = (t * 4) + j + 1;
                    Console.Write(array[t, j]);
                }
            }
            
        }
        static void JaggedArray()
        {
            int[][] jaggedArray = {
         new int[] {1, 9, 5},
         new int[] {2, 4},    };
            // print elements of jagged array
            Console.WriteLine("jaggedArray[1][0]: " + jaggedArray[1][0]);
            Console.WriteLine("jaggedArray[1][1]: " + jaggedArray[1][1]);
            Console.WriteLine("jaggedArray[0][2]: " + jaggedArray[0][2]);

            Console.ReadLine();

        }
        static void Main(string[] args)
        {
            //  SingleArray();
            //  RectangularArray();
            //  JaggedArray();
            //  AllCollections.ArrayListFuns();
            //  AllCollections.HashTableFuns();
            // AllCollections.SortedListFuns();
            // AllCollections.StackFuns();
            //  AllCollections.QuequeFuns();

          //  AllGenericClass.ListFuns();
          //  AllGenericClass.SortedListFuns();
          //  AllGenericClass.DictionaryFuns();
          //  AllGenericClass.StackAndQuequeFuns();
          //  AllGenericClass.BothIterators();
            

           
            Console.WriteLine("heloo");
            Console.ReadLine();
        }
    }
}
