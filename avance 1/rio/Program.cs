﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rio
{
    class rio
    {
        private int[,] mat;

        public void Cargar()
        {
            Console.Write("matrix de 5x100 para el rio");
            string linea;
            linea = Console.ReadLine();
            mat = new int[5, 100];
            for (int f = 0; f < mat.GetLength(0); f++)
            {
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    Random rnd = new Random();
                    int lina = rnd.Next(8,8);
                    mat[f, c] = lina;
                }
            }
        }

        public void Imprimir()
        {
            for (int f = 0; f < mat.GetLength(0); f++)
            {
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    Console.Write(mat[f, c] + "");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            rio ma = new rio();
            ma.Cargar();
            ma.Imprimir();
            Console.ReadKey();
        }
    }
}
