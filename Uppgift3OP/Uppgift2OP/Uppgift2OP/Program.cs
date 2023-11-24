using System;
namespace Uppgift2
{
    class Program
    {
        static void Main(string[] args)
        {
            int gånger = 0;
            int n = int.Parse(Console.ReadLine());
            for (int i = n-1; i > 0; i--)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j * (j + 1) * (j + 2))
                    {
                        gånger++;
                    }
                }
            }
            Console.WriteLine(gånger);
        }
    }
}
