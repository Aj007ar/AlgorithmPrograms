namespace AlogorithmPrograms
{
    internal class Program
    {
		public void select()
        {
            Console.WriteLine("Welcome TO Algorithm Programs");
            Console.WriteLine("Choose your option");
            int option=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n1.Binary Search");
            switch (option)
            {
                case 1:
                    Console.WriteLine("***Binary Search***");
                    BinarySearch.Binarysearch();
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