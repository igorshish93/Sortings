using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortings
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 0, -2, 9, 3, 2, 7, 2, -4 };
            int n = 20;
            int[] array2 = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                array2[i] = random.Next(-100, 100);
            }
           
            Sorting<int> sorting = new Sorting<int>(array2);

            //sorting.array = new int[] { 0,4,-9,0,2,4,4,9,-9,4,2,8,2,33,24,27 };
            sorting.Print();
            Console.WriteLine("-----------------------------------");
            sorting.SortInsertion();
            sorting.Print();
            Console.WriteLine("-----------------------------------");
            sorting.SortBubble();
            sorting.Print();
            Console.WriteLine("-----------------------------------");
            sorting.SortSelection();
            sorting.Print();
            Console.ReadLine();
        }
    }
}
