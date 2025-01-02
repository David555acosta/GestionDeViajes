using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Crear una clase Producto con los atributos comunes de un producto como Nombre, Precio, Stock y Categoría.
Métodos: AjustarPrecio(), ActualizarStock().
Herencia:
*/

namespace TiendaOnline
{
    internal class Producto
    {
        public string Nombre { get; set; }

        public decimal Precio { get; set; }

        public int Stock { get; private set; }


        public string Categoria { get; set; }


        //Constructor stock
        public Producto(string nombre, decimal precio, int stock , string categoria)
        {
            this.Nombre = nombre;
            this.Precio = precio;
            this.Stock = stock; // Inicializamos el stock
            this.Categoria = categoria;
        }


        //Metodos 


        //Metodo sobre escribible para ajustar el precio de cada producto.
        public virtual void AjustarPrecio(decimal nuevoPrecio)
        {
            Precio = nuevoPrecio;   
        }



        //Metodo para poder acceder 
        public virtual void ActualizarStock (int stockActualizado)
        {
            Stock = stockActualizado;   
        }
    }
}
