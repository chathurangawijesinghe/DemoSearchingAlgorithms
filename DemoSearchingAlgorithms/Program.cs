using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSearchingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearch();

            Console.ReadKey();
        }

        static void LinearSearch()
        {
            int[] arr = { 2, 3, 4, 10, 40 };
            int x = 10;

            int result = DemoLinearSearch.Search(arr, x);
            if (result == -1)
            {
                Console.WriteLine("Element is not present in array");
            }
            else
            {
                Console.WriteLine("Element is present at index " + result);
            }
        }

        static void BinarySearch() 
        {
            int[] arr = { 2, 3, 4, 10, 40 };
            int n = arr.Length;
            int x = 10;

            int result = DemoBinarySearch.Search(arr, 0, n - 1, x);

            if (result == -1)
            {
                Console.WriteLine("Element not present");
            }
            else
            {
                Console.WriteLine("Element found at index "
                                 + result);
            }
        }
    }
}
