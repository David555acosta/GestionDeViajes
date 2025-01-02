using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Crear una clase base Producto y subclases para productos específicos como Ropa.
Ropa: Tiene un atributo adicional Tamaño y un método AplicarDescuento().
*/


namespace TiendaOnline
{
    internal class Ropa : Producto
    {
        public string Tamaño { get; set; }



        public Ropa(string nombre, decimal precio, int stock, string categoria , string tamaño) : base(nombre, precio, stock, categoria)
        {
            this.Nombre = nombre;
            this.Precio = precio;
            this.ActualizarStock(stock); // Al instanciar un nuevo Producto tipo Ropa mediante el metodo actualizar stock modificamos el stock.
            this.Categoria = categoria;
            this.Tamaño = tamaño;   
        }

        //Constructor Producto


        //Metodos

        public void AplicarDescuento()
        {
            decimal descuento;

            switch (Tamaño)
            {
                case "L":
                case "M":
                    descuento = 0.1m;
                    break;
                case "XL":
                    descuento = 0.2m;
                    break;
                case "XXL":
                    descuento = 0.3m;
                    break;
                default:
                    throw new ArgumentException("Tamaño no valido");
            }

            // Aplicar el descuento al precio del producto
            Precio -= Precio * descuento;
        }


        ////Sobre Escribir metodo AjustarPrecio.
        public decimal AjustarPrecio()
        {
            return Precio;
        }
    }
}
