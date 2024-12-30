using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Clases derivadas:
ViajeEnAvion:
Propiedad adicional: ClaseVuelo (Económica, Ejecutiva, Primera Clase).
El costo total incluye un recargo dependiendo de la clase del vuelo.
*/

namespace EmpresaViajes
{
    internal class ViajeEnAvion : Viaje , IReservable
    {
        public string ClaseVuelo { get; set; }


        //Constructor 
        public ViajeEnAvion(string unDestino, int unaDuracion, decimal unCostoBase , string unaClase , int idUnico) : base()
        {
            this.Destino = unDestino;
            this.Duracion = unaDuracion;
            this.CostoBase = unCostoBase;
            this.ClaseVuelo = unaClase;
            this.IdUnico = IdUnico;
        }


        //Metodo de interfaz.
        public override decimal CalcularCostoTotal()
        {
            decimal recargo = 0;
            switch (ClaseVuelo)
            {
                case "Economica":
                    recargo = 0.1m; // 10% de recargo
                    break;
                case "Ejecutiva":
                    recargo = 0.2m; // 20% de recargo
                    break;
                case "Primera Clase":
                    recargo = 0.3m; // 30% de recargo
                    break;
                default:
                    throw new ArgumentException("Clase de vuelo no válida");
            }
            return CostoBase + (CostoBase * recargo);
        }


        //Interzas devolviendo segun las nececidades de la clase.
        public string Reservar()
        {
            return "Su viaje en avion a sido reservado con exito¡";
        }


        //Metodo SobreEscrito para mostrar los detalles.

        public override string MostrarDetalles()
        {
            return $"Destino : {Destino} , Duracion : {Duracion} , Costo Base : {CostoBase} , Total mas recargos {CalcularCostoTotal()}";
        }
    }
}
