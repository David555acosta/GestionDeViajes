using System;
using System.Collections.Generic;

namespace EmpresaViajes
{
    internal class GestorViajes
    {
        List<Viaje> listaDeViajes = new List<Viaje>();


        // Método para agregar un viaje a la lista.
        public void AgregarViaje(Viaje unViaje)
        {
            if (!Viaje_EstaEnLista(unViaje)) // Cambié la condición a la inversa
            {
                listaDeViajes.Add(unViaje);
            }
            else
            {
                throw new ArgumentException("No se puede agregar un viaje existente en la lista");
            }
        }

        // Método para evaluar si un viaje está en la lista.
        public bool Viaje_EstaEnLista(Viaje unViajeX)
        {
            foreach (Viaje viaje in listaDeViajes)
            {
                if (viaje.IdUnico == unViajeX.IdUnico)
                {
                    return true; // Devuelve true si el viaje ya está en la lista
                }
            }

            return false; // Devuelve false si no se encuentra el viaje
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
