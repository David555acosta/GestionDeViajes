using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

/*
 Ejercicio: Empresa de Viajes
Contexto:
Una empresa llamada MundoExplora ofrece viajes a diferentes partes del mundo. Los viajes pueden realizarse de diversas formas: en avión, en barco o en autobús.
Cada tipo de viaje tiene sus características específicas, pero todos comparten ciertos aspectos comunes.

Requerimientos:
Clase base abstracta: Viaje

Propiedades:
Destino (cadena)
Duracion (en días, entero)
CostoBase (decimal, costo inicial del viaje)
Métodos:
Método abstracto CalcularCostoTotal(): Calcula el costo total del viaje considerando los costos específicos de cada tipo de transporte.
Método concreto ImprimirDetalles(): Muestra la información general del viaje.



Clases derivadas:
ViajeEnAvion:
Propiedad adicional: ClaseVuelo (Económica, Ejecutiva, Primera Clase).
El costo total incluye un recargo dependiendo de la clase del vuelo.

ViajeEnBarco:
Propiedad adicional: TipoCabina (Interior, Exterior, Suite).
El costo total incluye un recargo dependiendo del tipo de cabina.

ViajeEnBus:
Propiedad adicional: Paradas (entero, número de paradas).
El costo total incluye un recargo por cada parada.

Interfaz: IReservable
Método Reservar(): Imprime un mensaje indicando que el viaje ha sido reservado.


Lista de viajes:
En el programa principal, crea una lista de viajes con diferentes tipos y muestra los detalles de cada viaje.
Objetivos del ejercicio:
Implementa las clases abstractas y las interfaces adecuadamente.
Usa polimorfismo para recorrer la lista de viajes y mostrar los detalles de cada uno.
Asegúrate de encapsular correctamente las propiedades y de validar los datos ingresados.
Calcula correctamente el costo total de cada tipo de viaje según sus características específicas.
*/

namespace EmpresaViajes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ViajeEnAvion viajeRaul = new ViajeEnAvion("Florianopolis", 7, 200, "Economica" ,234);
            ViajeEnAvion viajeDavid = new ViajeEnAvion("Cancun" , 5 , 300.55m , "Ejecutiva" , 156);
            ViajeEnBarco ViajeJose = new ViajeEnBarco("Bahamas", 21, 400, "Interior" , 777);  
            ViajeEnBus ViajeRogelio = new ViajeEnBus("Misiones", 7, 5000, 3 , 555);
       

           //Metodo para recorrer cada elemento de la lista y mostrar los detalles de cada viaje.
            
        }
    }
}
