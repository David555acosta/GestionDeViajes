using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Requerimientos:
Clase base abstracta: Viaje

Propiedades:
Destino (cadena)
Duracion (en días, entero)
CostoBase (decimal, costo inicial del viaje)
Métodos:
Método abstracto CalcularCostoTotal(): Calcula el costo total del viaje considerando los costos específicos de cada tipo
de transporte.
Método concreto ImprimirDetalles(): Muestra la información general del viaje.
*/

namespace EmpresaViajes
{
    abstract class Viaje
    {
        public string Destino { get; set; }


        private int _duracion; // Campo privado para almacenar el valor.

        public int Duracion
        {
            get { return _duracion; } //Lectura
            set
            {
                if (value >= 3 && value <= 31 ) // Validación: por ejemplo, que la duración no sea negativa.
                {
                    _duracion = value; //Escritura
                }
                else
                {
                    throw new ArgumentException("La duración no puede ser negativa o mayor a 31 dias"); //Escritura-Error
                }
            }
        }


        public decimal CostoBase { get; set; } //Lectura , escritura.


        public int IdUnico { get; set; } //Agrego un id para hacer mas rapida las comparaciones en las listas.


        //Constructor

        public Viaje(string unDestino, decimal unCostoBase, int unaDuracion, int IdUnico)
        {
            this.Destino = unDestino;
            this.Duracion = unaDuracion;
            this.CostoBase = unCostoBase;
            this.IdUnico = IdUnico;
        }

        //Metodos:

        //Metodo para calcular el costo

        public abstract decimal CalcularCostoTotal();


        //Metodo sobreEscribible para mostrar los detalles de cada viaje segun la clase.
        public virtual string MostrarDetalles ()
        {
            return "";
        }
    }
}
