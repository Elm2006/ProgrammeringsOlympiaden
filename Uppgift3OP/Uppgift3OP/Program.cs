using System;
namespace Uppgift3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            string[] rad = new string[n];
            char[,] rutnät = new char[n, m];
            string ord = "";
            for (int i = 0; i < n; i++)
            {
                rad[i] = Console.ReadLine();
                for (int j = 0; j < rad[i].Length; j++)
                {
                    rutnät[i,j] = rad[i][j];
                    if (rutnät[i, j] != '.')
                    {
                        ord += rutnät[i, j];
                    }
                }
            }
            Console.WriteLine(ord);
        }
    }
}
