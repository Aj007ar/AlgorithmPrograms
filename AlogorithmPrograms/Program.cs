﻿namespace AlogorithmPrograms
{
    internal class Program
    {
        
		public void select()
        {
            Console.WriteLine("\nWelcome TO Algorithm Programs");
            Console.WriteLine("\n1.Binary Search\n2.Insertion Sort");
            Console.WriteLine("0.Exit");
            Console.WriteLine("Choose your option");
            int option=Convert.ToInt32(Console.ReadLine());
           
            switch (option)
            {
                case 1:
                    Console.WriteLine("***Binary Search***");
                    BinarySearch.Binarysearch();
                    select();
                    break;
                case 2:
                    Console.WriteLine("***Insertion Sort***");
                    InsertionSort<int>.InsertionSortOperation();
                    select();
                    break;
            }
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.select();
        }
	}
}