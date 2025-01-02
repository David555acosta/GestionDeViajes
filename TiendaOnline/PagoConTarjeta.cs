using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaOnline
{
    internal class PagoConTarjeta: IPago

    {
        public bool Pagado { get; private set; } = false;

        public void Pagar()
        {
            Console.WriteLine("Pago con Tarjeta realizado con exito");
            Pagado = true;  
        }

        public void CancelarPago()
        {
            Console.WriteLine("Pago con Tarjeta cancelado");
            Pagado = false; 
        }

        public string ObtenerMetodoPago()
        {
            return "Pago realizado con tarjeta";
        }
    }
}
