using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSearchingAlgorithms
{
    public class DemoBinarySearch
    {
        public static int Search(int[] arr, int start, int end, int x)
        {
            if (end >= start)
            {
                var middle = (start + end) / 2;
                if (arr[middle] == x)
                {
                    return middle;
                }

                if (arr[middle] > x)
                {
                    return Search(arr, start, middle - 1, x);
                }
                else
                {
                    return Search(arr, middle + 1, end, x);
                }
            }

            return -1;
        }
    }
}
