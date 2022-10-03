using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposDeDatos.Codigo {
    public class _06_manipulando_strings {
        public void manipulandoStrings() {
            var mensaje = "21312Hola, ¿cuál es tu nombre?";
            char[] numeros = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            var mensajeBienvenida = mensaje.Trim(numeros);

            Console.WriteLine(mensajeBienvenida);

            var name = "Fernando Nicolás";
            var nameMin = name.ToLower();
            var nameMay = name.ToUpper();

            Console.WriteLine($"Nombre en mayúsculas: { nameMay }");
            Console.WriteLine($"Nombre en minúsculas: { nameMin }");

            long[] monto = new long[] { 123, 231231, 4252352532, 23 };

            for (int i = 0; i < monto.Length; i++) {
                var msg = monto[i].ToString().PadLeft(10, '0');
                Console.WriteLine(msg);
            }

            Console.WriteLine("¿Desea terminar el programa? (Y/N)");
            var entrada = Console.ReadLine();

            if (entrada?.ToUpper() == "Y") {
                Console.WriteLine("¡Terminando el programa!");
            } else {
                Console.WriteLine("¡El programa no va a terminar!");
            }
        }
    }
}
