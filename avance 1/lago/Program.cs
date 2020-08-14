using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lago
{
    class lago
    {
        private int[,] mat;

        public void Cargar()
        {
            Console.Write("matrix de 15x15 para el lago");
            string linea;
            linea = Console.ReadLine();
            mat = new int[15, 15];
            for (int f = 0; f < mat.GetLength(0); f++)
            {
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    Random rnd = new Random();
                    int lina = rnd.Next(5, 5);
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
            lago ma = new lago();
            ma.Cargar();
            ma.Imprimir();
            Console.ReadKey();
        }
    }
}
