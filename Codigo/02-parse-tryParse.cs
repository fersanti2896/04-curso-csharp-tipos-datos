using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposDeDatos.Codigo {
    public class _02_parse_tryParse {
        public void parseTryParse() {
            var entrada = Console.ReadLine();

            int num = int.Parse(entrada!);
            Console.WriteLine($"Valor dado: { num }");

            var fechaString = "2022-10-03";
            var fecha = DateTime.Parse(fechaString);
            Console.WriteLine(fecha.AddDays(1));

            var nombre = "Fer Santi";
            int value;
            var flagParse = int.TryParse(nombre, out value);

            if (flagParse) {
                Console.WriteLine($"Valor: { value }");
            } else {
                Console.WriteLine($"El valor: { nombre } no tiene el formato correcto");
            }
        }   
    }
}
