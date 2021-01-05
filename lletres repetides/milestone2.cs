using System;
using System.Collections.Generic;
using System.Text;

namespace lletres_repetides
{
    class milestone2
    {
        public static void altura()
        {
            int i, j, altura;

            Console.WriteLine("altura");
            altura = Int32.Parse(Console.ReadLine());

            for (i = 1; i <= altura; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();

                for (i = altura; i >= 1; i--)
                {
                    for (int lado = altura - 1; lado >= i; lado--)
                    {
                        Console.Write(" ");
                    }

                    for ( j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }

                    for (j = i - 1; j >= 0; j--)
                    {
                        Console.Write("*");
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}
