using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailShakerSortAdaptive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 29, 72, 98, 13, 87, 66, 52, 51, 36 };
            int temp = 0;
            bool swap = false;

            Console.WriteLine("The unsorted array...");
            foreach (int a in arr)
                Console.Write(a + "\t");
            Console.WriteLine();

            for (int x = 0; x < (arr.Length / 2) + 1; x++)// number of passes
            {
                for (int y = 0 + x; y < arr.Length - 1 - x; y++) // left to right motion
                {
                    swap = false;
                    if (arr[y] > arr[y + 1])
                    {
                        temp = arr[y];
                        arr[y] = arr[y + 1];
                        arr[y + 1] = temp;
                        swap = true;
                    }

                    Console.ResetColor();
                    Console.WriteLine("Pass {0} Left to Right Pass {1}...", x, y);
                    for (int a = 0; a < arr.Length; a++)
                    {
                        if (a == y)
                            if (swap)
                                Console.ForegroundColor = ConsoleColor.Red;
                            else
                                Console.ForegroundColor = ConsoleColor.Blue;
                        else if (a == y + 1)
                            if (swap)
                                Console.ForegroundColor = ConsoleColor.Blue;
                            else
                                Console.ForegroundColor = ConsoleColor.Red;
                        else
                            Console.ResetColor();
                        Console.Write(arr[a] + "\t");
                    }
                    Console.WriteLine();
                    //Console.ReadKey();
                }

                for (int y = arr.Length - 1 - x; y > 0 + x; y--) // right to left motion
                {

                    swap = false;
                    if (arr[y] < arr[y - 1])
                    {
                        temp = arr[y];
                        arr[y] = arr[y - 1];
                        arr[y - 1] = temp;
                        swap = true;
                    }

                    Console.ResetColor();
                    Console.WriteLine("Pass {0} Right to Left Pass {1}...", x, y);
                    for (int a = 0; a < arr.Length; a++)
                    {
                        if (a == y)
                            if (swap)
                                Console.ForegroundColor = ConsoleColor.Cyan;
                            else
                                Console.ForegroundColor = ConsoleColor.Magenta;
                        else if (a == y - 1)
                            if (swap)
                                Console.ForegroundColor = ConsoleColor.Magenta;
                            else
                                Console.ForegroundColor = ConsoleColor.Cyan;
                        else
                            Console.ResetColor();
                        Console.Write(arr[a] + "\t");
                    }
                    Console.WriteLine();
                    //Console.ReadKey();
                }
            }

            Console.ReadKey();
        }
    }
}
