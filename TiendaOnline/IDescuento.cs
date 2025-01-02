using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Crear una interfaz IDescuento con un método AplicarDescuento().
 La interfaz será implementada por las subclases Ropa y Tecnología, cada una con una lógica diferente para aplicar el descuento según su tipo.
*/

namespace TiendaOnline
{
    internal interface IDescuento
    {
        decimal AplicarDescuento();
    }
}
