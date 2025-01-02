using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Interfaz para Pagos:
 Crear una interfaz IPago con los métodos Pagar() y CancelarPago().
*/

namespace TiendaOnline
{
    internal interface IPago
    {
        void Pagar();

        void CancelarPago();


        string ObtenerMetodoPago();
    }
}
