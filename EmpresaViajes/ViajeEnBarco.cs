using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 clases derivadas : 

ViajeEnBarco:
Propiedad adicional: TipoCabina (Interior, Exterior, Suite).
El costo total incluye un recargo dependiendo del tipo de cabina.
*/

namespace EmpresaViajes
{
    internal class ViajeEnBarco: Viaje , IReservable
    {
        public string TipoCabina { get; set; }

        //Constructor 
        public ViajeEnBarco(string unDestino, int unaDuracion, decimal unCostoBase, string unaCabina, int IdUnico) : base()
        {
            this.Destino = unDestino;
            this.Duracion = unaDuracion;
            this.CostoBase = unCostoBase;
            this.TipoCabina = unaCabina;
            this.IdUnico = IdUnico;
        }


        //Metodo de interfaz.
        public override decimal CalcularCostoTotal()
        {
            decimal recargo;

            switch (TipoCabina)
            {
                case "Interior":
                    recargo = 0.1m; // 10% de recargo
                    break;
                case "Exterior":
                    recargo = 0.2m; // 20% de recargo
                    break;
                case "Suite":
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
            return "Su viaje en barco a sido reservado con exito¡";
        }


        //Metodo SobreEscrito para mostrar los detalles.

        public override string MostrarDetalles()
        {
            return $"Destino : {Destino} , Duracion : {Duracion} , Costo Base : {CostoBase} , Total mas recargos {CalcularCostoTotal()}";
        }
    }
}
