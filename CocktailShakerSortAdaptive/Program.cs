﻿using System;
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
            int[] visualizerSize = { 29, 120 }; // rows and columns of console
            Random rnd = new Random();
            int[] arr = new int[visualizerSize[1]];
            int[] newDispl = new int[visualizerSize[1]];
            int[] curDispl = new int[visualizerSize[1]];
            
            int temp = 0;
            bool swap = false;

            /*
             * Possible colors:
             * 0 : Reset Color
             * 1 : Blue
             * 2 : Red
             * 3 : Green
             */

            for (int x = 0; x < arr.Length; x++)
            {
                arr[x] = rnd.Next(visualizerSize[0]) + 1;
                newDispl[x] = 0;
                curDispl[x] = 0;
            }

            Console.SetWindowSize(visualizerSize[1], visualizerSize[0] + 3);

            #region Visualizing initial display
            for (int a = visualizerSize[0]; a > 0; a--) // dictate number of rows
            {
                for (int b = 0; b < arr.Length; b++) // dictate number of columns
                {
                    if (arr[b] >= a)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
            }
            Console.Write("To be sorted using bubble sort... Press any key to begin...");
            Console.ReadKey();
            //Console.Clear(); 
            #endregion

            for (int x = 0; x < (arr.Length / 2) + 1; x++)// number of passes
            {
                for (int y = 0 + x; y < arr.Length - 1 - x; y++) // left to right motion
                {
                    swap = false;

                    newDispl[y] = 1;
                    newDispl[y + 1] = 2;

                    #region Visualizing Column Selection
                    for (int a = 0; a < arr.Length; a++)
                    //for (int a = visualizerSize[0]; a > 0; a--) // dictate number of rows
                    {
                        for (int b = visualizerSize[0]; b > 0; b--)
                        //for (int b = 0; b < arr.Length; b++) // dictate number of columns
                        {
                            if (newDispl[a] != curDispl[a])
                            {
                                Console.SetCursorPosition(a, b - 1);
                                switch (newDispl[a])
                                {
                                    case 0:
                                        Console.ResetColor();
                                        break;
                                    case 1:
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        break;
                                    case 2:
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        break;
                                    case 3:
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        break;
                                }

                                if (arr[a] > visualizerSize[0] - b)
                                    Console.Write("*");
                                else
                                    Console.Write(" ");
                            }
                        }

                        curDispl[a] = newDispl[a];
                        newDispl[a] = 0;
                    }
                    Console.SetCursorPosition(0, 29);
                    Console.Write("Pass {0} : Thinking. . .                                               ", x);
                    //Console.ReadKey();
                    //Thread.Sleep(200);
                    //Console.Clear(); 
                    #endregion

                    if (arr[y] > arr[y + 1])
                    {
                        temp = arr[y];
                        arr[y] = arr[y + 1];
                        arr[y + 1] = temp;
                        swap = true;
                    }

                    Console.ResetColor();
                    Console.WriteLine("\t\tPass {0} Left to Right Pass {1}...", x, y);
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
                    }
                    Console.WriteLine();
                    //Console.ReadKey();
                }

                for (int y = arr.Length - 1 - x; y > 0 + x; y--) // right to left motion
                {
                    swap = false;

                    newDispl[y] = 1;
                    newDispl[y - 1] = 2;

                    #region Visualizing Column Selection
                    for (int a = 0; a < arr.Length; a++)
                    //for (int a = visualizerSize[0]; a > 0; a--) // dictate number of rows
                    {
                        for (int b = visualizerSize[0]; b > 0; b--)
                        //for (int b = 0; b < arr.Length; b++) // dictate number of columns
                        {
                            if (newDispl[a] != curDispl[a])
                            {
                                Console.SetCursorPosition(a, b - 1);
                                switch (newDispl[a])
                                {
                                    case 0:
                                        Console.ResetColor();
                                        break;
                                    case 1:
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        break;
                                    case 2:
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        break;
                                    case 3:
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        break;
                                }

                                if (arr[a] > visualizerSize[0] - b)
                                    Console.Write("*");
                                else
                                    Console.Write(" ");
                            }
                        }

                        curDispl[a] = newDispl[a];
                        newDispl[a] = 0;
                    }
                    Console.SetCursorPosition(0, 29);
                    Console.Write("Pass {0} : Thinking. . .                                               ", x);
                    //Console.ReadKey();
                    //Thread.Sleep(200);
                    //Console.Clear(); 
                    #endregion

                    if (arr[y] < arr[y - 1])
                    {
                        temp = arr[y];
                        arr[y] = arr[y - 1];
                        arr[y - 1] = temp;
                        swap = true;
                    }

                    Console.ResetColor();
                    Console.WriteLine("\t\tPass {0} Right to Left Pass {1}...", x, y);
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
                    }
                    Console.WriteLine();
                    //Console.ReadKey();
                }
                #region Visualizing Swap display!
                for (int a = 0; a < arr.Length; a++)
                //for (int a = visualizerSize[0]; a > 0; a--) // dictate number of rows
                {
                    for (int b = visualizerSize[0]; b > 0; b--)
                    //for (int b = 0; b < arr.Length; b++) // dictate number of columns
                    {
                        if (newDispl[a] != curDispl[a])
                        {
                            Console.SetCursorPosition(a, b - 1);
                            switch (newDispl[a])
                            {
                                case 0:
                                    Console.ResetColor();
                                    break;
                                case 1:
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    break;
                                case 2:
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    break;
                                case 3:
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    break;
                            }

                            if (arr[a] > visualizerSize[0] - b)
                                Console.Write("*");
                            else
                                Console.Write(" ");
                        }
                    }

                    curDispl[a] = newDispl[a];
                    newDispl[a] = 0;
                }
                Console.SetCursorPosition(0, 29);
                Console.Write("Pass {0} : Swapping . . .                                             ", x);
                //Console.ReadKey();
                //Thread.Sleep(50);
                //Console.Clear();
                #endregion
            }
            Console.SetCursorPosition(0, 29);
            Console.Write("Done!!!!!!!!!                                              ");
            Console.ReadKey();
        }
    }
}
