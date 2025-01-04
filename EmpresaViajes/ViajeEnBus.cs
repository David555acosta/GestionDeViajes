using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 clase derivadas:

ViajeEnBus:
Propiedad adicional: Paradas (entero, número de paradas).
El costo total incluye un recargo por cada parada.
*/

namespace EmpresaViajes
{
    internal class ViajeEnBus : Viaje , IReservable
    {
        public int Paradas {  get; set; }

        //Constructor 
        public ViajeEnBus(string unDestino, decimal unCostoBase , int unaDuracion, int IdUnico , int unaCantParadas) : 
            base(unDestino , unCostoBase , unaDuracion , IdUnico)
        {
            this.Destino = unDestino;
            this.CostoBase = unCostoBase;
            this.Duracion = unaDuracion;
            this.IdUnico = IdUnico;
            this.Paradas = unaCantParadas;
        }


        //Metodo de interfaz.
        public override decimal CalcularCostoTotal()
        {
            decimal recargo = 0;

            if (CantidadDeParadasDe_(Paradas , 0 , 3)) //Pasamos como argumento la propiedad Paradas con otros 2 numeros.
            {

                recargo = 0.1m; // recargo 5%

            } else if (CantidadDeParadasDe_(Paradas , 4 , 7 ))
            {

                recargo = 0.2m; //Recargo 20%


            } else if (CantidadDeParadasDe_(Paradas, 8 , 11))
            {
                recargo = 0.3m; //recargo 30%

            } else
            {
                Console.WriteLine("No se pueden superar las 11 paradas");
            }


           
            return CostoBase + (CostoBase * recargo);
        }





        //Metodo para evaluar la cantidad de paradas
        public virtual bool CantidadDeParadasDe_ (int  unaCantidad , int unNumero , int otroNumero)
        {
            return unaCantidad >= unNumero && unaCantidad <= otroNumero; //Metodo booleano que evalua si *unaCantidad*
                                                                         //Es un numero que esta entre unNumero y otroNumero.
        }


        //Interzas devolviendo segun las nececidades de la clase.

        public string Reservar()
        {
            return "Su viaje en bus a sido reservado con exito¡";
        }



        //Metodo SobreEscrito para mostrar los detalles.

        public override string MostrarDetalles()
        {
            return $"Destino : {Destino} , Duracion : {Duracion} , Costo Base : {CostoBase} , Total mas recargos {CalcularCostoTotal()}";
        }
    }
}

