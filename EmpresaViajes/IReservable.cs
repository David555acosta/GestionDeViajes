using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Interfaz: IReservable
Método Reservar(): Imprime un mensaje indicando que el viaje ha sido reservado.
*/

namespace EmpresaViajes
{
    internal interface IReservable
    {
        string Reservar();
    }
}
