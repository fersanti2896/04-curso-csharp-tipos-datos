using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposDeDatos.Codigo {
    public class _03_enums {
        public void enums() {
            var estatus = EstatusVenta.PendienteDePago;

            switch (estatus) {
                case EstatusVenta.PendienteDePago:
                    Console.WriteLine($"El estatus de compra es Pendiente de Pago");
                    break;
                case EstatusVenta.Exitoso:
                    Console.WriteLine($"El status de compra es existoso");
                    break;
                case EstatusVenta.Cancelada:
                    Console.WriteLine($"El status de compra es cancelada");
                    break;
                default:
                    Console.WriteLine("Estatus desconocido");
                    break;
            }
        }
    }
}
