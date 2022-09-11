using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlogorithmPrograms
{
    internal class BinarySearch
    {
        public static void Binarysearch()
        {
            //Reads from file
            string text = File.ReadAllText(@"D:\BL\LinuxBatch-560\LFP-183-DotNet\AlgorithmProgram\AlgotithamPrograms\AlogorithmPrograms\Countries.txt");
            List<string> list = new List<string>(text.Split(" "));
            list.Sort();
            foreach (string element in list)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("\n\n Enter the word to be found");
            string key = Console.ReadLine();

            bool result = Search(list, 0, list.Count - 1, key);
            if (result == true)
                Console.WriteLine("Found {0}", key);
            else
                Console.WriteLine("Not Found {0}", key);

        }
        //Binary search where elements are compared by finding mid
        public static bool Search(List<string> list, int start, int end, string key)
        {
            bool found = false;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                int res = key.CompareTo(list[mid]);
                if (res == 0)
                    found = true;
                if (res > 0)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }



            return found;
        }

    }
}
