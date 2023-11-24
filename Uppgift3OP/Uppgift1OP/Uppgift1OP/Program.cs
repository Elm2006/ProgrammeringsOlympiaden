using System;
namespace Uppgift1
{
    class Program
    {
        static void Main(string[] args)
        {
            string ord = Console.ReadLine();
            int gånger = int.Parse(Console.ReadLine());
            for (int i = 0; i < gånger; i++)
            {
                Console.Write(ord);
            }
            Console.WriteLine();
        }
    }
}
