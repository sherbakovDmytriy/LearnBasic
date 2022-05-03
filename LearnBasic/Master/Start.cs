using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnBasic.Master
{
    internal class Start
    {
        public static void Up()
        {
            ArraySorterExamples();
        }

        private static void ArraySorterExamples()
        {
            ArraySorter arr = new(10);

            arr.FillByRandom();
            Console.WriteLine("Bubble Sort");
            arr.PrintArray();
            arr.BubbleSort();
            Console.WriteLine();
            arr.PrintArray();
            Console.WriteLine("\n");

            arr.FillByRandom();
            Console.WriteLine("Insertion Sort");
            arr.PrintArray();
            arr.InsertionSort();
            Console.WriteLine();
            arr.PrintArray();
            Console.WriteLine("\n");

            arr.FillByRandom();
            Console.WriteLine("Selection Sort");
            arr.PrintArray();
            arr.SelectionSort();
            Console.WriteLine();
            arr.PrintArray();
            Console.WriteLine("\n");
        }
    }
}
