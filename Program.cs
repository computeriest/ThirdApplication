// See https://aka.ms/new-console-template for more information
using System;

public class Sekiller
{
    public static void Main(string[] args)
    {
        for (int i = 0; i < 5; i++)
        {
            for (int v = 0; v < 5; v++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("--------------------");

        int kenar = 5;
        for (int i = 0; i < kenar; i++)
        {
            for (int v = 0; v < kenar; v++)
            {
                if (i == 0 || i == kenar - 1 || v == 0 || v == kenar - 1)
                {
                    Console.Write("* ");
                }
                else
                {
                    Console.Write("  ");
                }
            }
            Console.WriteLine();
        }

        Console.WriteLine("--------------------");

        int kenar2 = 5;
        for (int i = 0; i < kenar2; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                if (j == 0 || i == kenar2 - 1 || j == i)
                {
                    Console.Write("* ");
                }
                else
                {
                    Console.Write("  ");
                }
            }
            Console.WriteLine();
        }

        Console.WriteLine("--------------------");
        int kenarK = 5;
        for (int i = 0; i < kenarK; i++)
        {
            for (int j = 0; j < kenarK; j++)
            {
                if (i == 0 || j == kenarK - 1 || j == kenarK - 1 || i == j)
                {
                    Console.Write("* ");
                }
                else
                {
                    Console.Write("  ");
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine("--------------------");
        int kenart = 5;
        for (int i = 0; i < kenart; i++)
        {
            for (int j = i; j < kenart; j++)
            {
                if (i == 0 || i == kenart - 1 || j == 0 || j == kenart - 1 || j == i)
                {
                    Console.Write("* ");
                }
                else
                {
                    Console.Write("  ");
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine("--------------------");

        int kenar4 = 5;

        for (int i = 0; i < kenar4; i++)
        {
            for (int j = 0; j < kenar4 - i - 1; j++)
            {
                Console.Write("  ");
            }

            for (int k = 0; k <= i; k++)
            {
                if (k == 0 || i == kenar4 - 1 || k == i)
                {
                    Console.Write("* ");
                }
                else
                {
                    Console.Write("  ");
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine("--------------------");



        int kenar5 = 5;
        for (int i = 0; i < kenar5; i++)
        {
            for (int j = 0; j < kenar5 - i - 1; j++)
            {
                Console.Write(" ");
            }

            for (int k = 0; k < (i * 2) + 1; k++)
            {
                if (k == 0 || k == i * 2 || i == kenar5 || k % 2 == 0)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }

            Console.WriteLine();
        }
        Console.WriteLine("--------------------");

        int kenar6 = 5;
        for (int i = 0; i < kenar6; i++)
        {
            for (int j = 0; j < kenar6 - i - 1; j++)
            {
                Console.Write(" ");
            }

            for (int k = 0; k < (i * 2) + 1; k++)
            {
                if (k == 0 || k == (i * 2) || i == kenar6 - 1)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }

        Console.WriteLine("--------------------");

        int kenarz = 5;

        for (int i = 0; i < kenarz-1 ; i++)
        {
            for (int j = 0; j < kenarz - i; j++)
            {
                Console.Write(" ");
            }

            for (int k = 0; k < 2 * i + 1; k++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }

        for (int i = kenarz - 1; i >= 0; i--)
        {
            for (int j = 0; j < kenarz - i; j++)
            {
                Console.Write(" ");
            }

            for (int k = 0; k < 2 * i + 1; k++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
        Console.WriteLine("--------------------");

        int kenarg = 5;
        for (int i = 0; i < kenarg; i++)
        {
            for (int j = 0; j < kenarg - i - 1; j++)
            {
                Console.Write(" ");
            }

            for (int j = 0; j < 2 * i + 1; j++)
            {
                if (j == 0 || j == 2 * i)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }

            Console.WriteLine();
        }

        for (int i = kenarg - 2; i >= 0; i--)
        {
            for (int j = 0; j < kenarg - i - 1; j++)
            {
                Console.Write(" ");
            }

            for (int j = 0; j < 2 * i + 1; j++)
            {
                if (j == 0 || j == 2 * i)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }

            Console.WriteLine();
        }
        Console.WriteLine("--------------------");
    }
}




