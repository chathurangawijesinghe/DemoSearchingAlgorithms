using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSearchingAlgorithms
{
    public class DemoLinearSearch
    {
        public static int Search(int[] arr, int x)
        {
            for (var i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
