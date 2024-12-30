using System;
using System.Collections.Generic;

namespace EmpresaViajes
{
    internal class GestorViajes
    {
        List<Viaje> listaDeViajes = new List<Viaje>();

        // Metodo para agregar un viaje a la lista.
        public void AgregarViaje(Viaje unViaje)
        {
            if (!NoEstaEnLista_(unViaje))
            {
                listaDeViajes.Add(unViaje);

            }
            else
            {
                Console.WriteLine("Cagada");
            }
        }


        //Metodo para evaluar si un viaje esta en la lista de viajes.
        public bool NoEstaEnLista_(Viaje unViajeX)
        {
            foreach (Viaje viaje in listaDeViajes)
            {
                if (viaje.IdUnico == unViajeX.IdUnico)
                {
                    return true;
                }
            }

            return false;
        }


        //Metodo para mostrar todos los viajes de la lista de viajes.

        public void MostrarElementoDeLista()
        {
            int indice = 0;

            foreach (Viaje viaje in listaDeViajes)
            {
                Console.WriteLine($"{indice + 1 }) {viaje.MostrarDetalles()}");

                indice++;   
            }
        }
    }
}
