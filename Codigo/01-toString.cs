using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposDeDatos.Codigo {
    public class _01_toString {
        public void toString() {
            var num = 25;

            if (num.ToString() == "5") { 
                Console.WriteLine("Valores iguales");
            } else {
                Console.WriteLine("Valores distintos");
            }

            var fecha = DateTime.Today.ToString("yy-MM-dd dddd");
            Console.WriteLine(fecha);
        }
    }
}
