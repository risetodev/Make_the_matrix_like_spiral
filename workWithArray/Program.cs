﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workWithArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] Mas = new int[9, 9];
            int i = 9 / 2;
            int j = 9 / 2;
            int element = 0;           
            Console.WriteLine();
            int kolEl = 0;
            int kase = 0;
            Mas[i, j] = element++;
            while (i <= 9 || j <= 9)
            {
                switch (kase)
                {
                    case 0:
                        kolEl++;
                        for (int z = 0; z < kolEl; z++)
                            try
                            {
                                Mas[i, j--] = element++;
                            }
                            catch
                            {
                                element--;
                            }
                        kase = 1;
                        break;

                    case 1:                    
                        for (int z = 0; z < kolEl; z++)
                            try
                            {
                                Mas[i++, j] = element++;
                            }
                            catch
                            {
                                element--;
                            }
                        kase = 2;
                        break;

                    case 2:
                        kolEl++;
                        for (int z = 0; z < kolEl; z++)
                            try
                            {
                                Mas[i, j++] = element++;
                            }
                            catch
                            {
                                element--;
                            }
                        kase = 3;
                        break;

                    case 3:                     
                        for (int z = 0; z < kolEl; z++)
                            try
                            {
                                Mas[i--, j] = element++;
                            }
                            catch
                            {
                                element--;
                            }
                        kase = 0;
                        break;
                }
            }
            for (i = 0; i < 9; i++)
            {
                for (j = 0; j < 9; j++)
                {
                    Console.Write("{0,3:0}", Mas[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
