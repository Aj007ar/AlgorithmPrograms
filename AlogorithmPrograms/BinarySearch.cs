using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlogorithmPrograms
{
    internal class BinarySearch
    {
        public void binarySearch()
        {
            int[] arr = new int[100];
            Console.WriteLine("Enter number of element in array");
            string s = Console.ReadLine();
            int x = Int32.Parse(s);
            Console.WriteLine("Enter Elements");
            for(int  i = 0; i < x; i++)
            {
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);
            }
            Console.WriteLine("enter search element");
            string s3 = Console.ReadLine();
            int x2 = Int32.Parse(s3);
            int low = 0;
            int high = x - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (x2 < arr[mid])
                    high = mid - 1;
                else if (x2 > arr[mid])
                    low = mid + 1;
                else if (x2 == arr[mid])
                    Console.WriteLine("Element {0} found at location {1}\n",x2,mid+1);
                return;
            }
            Console.WriteLine("search unsuccessful");
        }
    }
}
