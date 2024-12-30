using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaViajes
{
    internal class GestorViajes
    {
        List<Viaje> listaDeViajes = new List<Viaje>();

        // Metodo para agregar un viaje a la lista.
        public void AgregarViaje(Viaje unViaje)
        {
            if (noEstaEnLista_(unViaje))
            {
                listaDeViajes.Add(unViaje);

            } else
            {
                throw new ArgumentException("No se puede agregar un viaje que ya esta en la lista");
            }
        }


        //Metodo para evaluar si un viaje esta en la lista de viajes.
        public bool noEstaEnLista_(Viaje unViajeX)
        {
            foreach (Viaje viaje in listaDeViajes)
            {
                if (viaje.IdUnico == unViajeX.IdUnico)
                {
                    return false;
                } 
            }

            return true;
        }


        //Metodo para mostrar todos los viajes de la lista de viajes.

        public void MostrarDetalles ()
        {
            foreach (Viaje viaje in listaDeViajes)
            {
                Console.WriteLine(viaje.MostrarDetalles());
            }
        }
    }
}
