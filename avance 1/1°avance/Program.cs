using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace terreno
{
    class terreno
    {
        private int[,] mat;

        public void Cargar()
        {
            Console.Write("matrix de 100x100 para el terreno");
            string linea;
            linea = Console.ReadLine();
            mat = new int[100, 100];
            for (int f = 0; f < mat.GetLength(0); f++)
            {
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    Random rnd = new Random();
                    int lina = rnd.Next(0);
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
            terreno ma = new terreno();
            ma.Cargar();
            ma.Imprimir();
            Console.ReadKey();
        }
    }
}
