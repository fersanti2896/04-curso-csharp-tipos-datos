using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposDeDatos.Codigo {
    public class _04_arreglos {
        public void Arreglos() {
            var vocales = new char[] { 'a', 'e', 'i', 'o', 'u' };

            foreach (var vocal in vocales) {
                Console.WriteLine($"Value: { vocal }");
            }

            var edades = new int[] { 24, 23, 25, 29, 17, 18, 30 };
            var rango = edades[..6];

            foreach (var elem in rango) {
                Console.WriteLine($"Value: {elem}");
            }

            var rango2 = edades[3..];

            foreach (var elem in rango2) {
                Console.WriteLine($"Value: {elem}");
            }
        }
    }
}
