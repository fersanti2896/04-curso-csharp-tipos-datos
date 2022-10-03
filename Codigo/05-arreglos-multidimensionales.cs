using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposDeDatos.Codigo {
    public class _05_arreglos_multidimensionales {
        public void arreglosMultidimensionales() {
            int[,] matriz = new int[2, 2] { { 2, 1 }, { 1, 2 } };
            Console.WriteLine($"Tamaño de la matriz: { matriz.Rank }");

            Console.WriteLine("Elementos de la matriz: ");
            for (int i = 0; i < matriz.GetLength(0); i++) {
                for (int j = 0; j < matriz.GetLength(1); j++) {
                    Console.Write($"{ matriz[i, j] } ");
                }
                Console.WriteLine();
            }

            int[][] arregloDeArreglos = {
                new int[] { 1, 2, 3 },
                new int[] { 3, 4, 5 },
                new int[] { 6 },
                new int[] { 7, 8 }
            };

            Console.WriteLine("Elementos de segunda matriz: ");

            for (int i = 0; i < arregloDeArreglos.Length; i++) {
                var arreglo = arregloDeArreglos[i];

                for (int j = 0; j < arreglo.Length; j++) {
                    Console.Write($"{ arreglo[j] } ");
                }

                Console.WriteLine();
            }
        }
    }
}
